using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace RocketSilo.SourceGenerator;

[Generator]
public class ClientSourceGenerator : ISourceGenerator
{
    private readonly TypesWithAttributeSyntaxReceiver typesWithRequestUrlAttributeSyntaxReceiver = new("RequestUrl");

    private readonly Regex extractRequestBase = new("([a-zA-Z]*)Request");
    
    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => typesWithRequestUrlAttributeSyntaxReceiver);
    }

    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxContextReceiver is not TypesWithAttributeSyntaxReceiver syntaxReceiver) return;
        
        List<string> namespaces = new();

        List<string> methodNames = new();

        foreach (TypeDeclarationSyntax typeSyntax in syntaxReceiver.Types)
        {
            SemanticModel model = context.Compilation.GetSemanticModel(typeSyntax.SyntaxTree);
            
            if (model.GetDeclaredSymbol(typeSyntax) is not ITypeSymbol typeSymbol) continue;
            
            string containingNamespace = $"{typeSymbol.ContainingNamespace.ContainingNamespace.ContainingNamespace.Name}.{typeSymbol.ContainingNamespace.ContainingNamespace.Name}.{typeSymbol.ContainingNamespace.Name}";
            namespaces.Add(containingNamespace);
            
            Match match = extractRequestBase.Match(typeSymbol.Name);
            string baseRequestName = match.Groups[1].Value;
            methodNames.Add(baseRequestName);
        }

        StringBuilder sb = new();
        sb.Append($@"//GENERATED FILE, DO NOT MODIFY
//generated {typesWithRequestUrlAttributeSyntaxReceiver.Types.Count} methods
");
        foreach (string distinctNamespace in namespaces.Distinct())
        {
            sb.Append($@"using {distinctNamespace};
");
        }
        sb.Append(@"
namespace RocketSilo.Api;

public partial class Client
{");
        foreach (string methodName in methodNames.Distinct())
        {
            sb.Append(GenerateMethod(methodName));
        }
        sb.Append('}');
        context.AddSource("Client.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
    }

    private static string GenerateMethod(string methodName)
    {
        return @$"
    public Task<{methodName}Response> {methodName}({methodName}Request request) => SendAsync<{methodName}Request, {methodName}Response>(request); 
";
    }
    
}