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

        StringWriter iface = new();
        StringWriter impl = new();

        // Write header
        WriteLineToAll("// GENERATED FILE, DO NOT MODIFY", iface, impl);
        WriteLineToAll($"// generated {typesWithRequestUrlAttributeSyntaxReceiver.Types.Count} methods", iface, impl);

        // Write usings
        foreach (string distinctNamespace in namespaces.Distinct())
        {
            WriteLineToAll($@"using {distinctNamespace};", iface, impl);
        }

        // Write namespace declaration
        WriteEmptyLineToAll(iface, impl);
        WriteLineToAll("namespace RocketSilo.Api;", iface, impl);
        WriteEmptyLineToAll(iface, impl);

        // Write class/interface declaration
        iface.WriteLine("public partial interface IClient");
        impl.WriteLine("internal partial class Client");
        WriteLineToAll("{", iface, impl);

        // Write method declarations
        foreach (string methodName in methodNames.Distinct())
        {
            impl.Write('\t');
            impl.WriteLine(GenerateImplMethod(methodName));
            iface.Write('\t');
            iface.WriteLine(GenerateIfaceMethod(methodName));
        }

        // Write close and finish
        WriteLineToAll("}", iface, impl);
        context.AddSource("Client.cs", SourceText.From(impl.ToString(), Encoding.UTF8));
        context.AddSource("IClient.cs", SourceText.From(iface.ToString(), Encoding.UTF8));
    }

    private static string GenerateImplMethod(string methodName)
    {
        return $"public Task<{methodName}Response> {methodName}Async({methodName}Request request) => SendAsync<{methodName}Request, {methodName}Response>(request);";
    }

    private static string GenerateIfaceMethod(string methodName)
    {
        return $"Task<{methodName}Response> {methodName}Async({methodName}Request request);";
    }

    private static void WriteLineToAll(string line, params TextWriter[] writers)
    {
        foreach (TextWriter writer in writers)
        {
            writer.WriteLine(line);
        }
    }

    private static void WriteEmptyLineToAll(params TextWriter[] writers)
    {
        foreach (TextWriter writer in writers)
        {
            writer.WriteLine();
        }
    }
}
