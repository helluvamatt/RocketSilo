using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RocketSilo.SourceGenerator;

public class TypesWithAttributeSyntaxReceiver : ISyntaxContextReceiver
{
    public List<TypeDeclarationSyntax> Types { get; } = new();

    private readonly string attributeName;

    public TypesWithAttributeSyntaxReceiver(string attributeName)
    {
        this.attributeName = attributeName;
    }

    public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
    {
        if (context.Node is not TypeDeclarationSyntax typeDeclarationSyntax) return;

        if (typeDeclarationSyntax.AttributeLists.Any(attributeList => attributeList.Attributes.Any(attribute => attribute.Name.ToString() == attributeName)))
        {
            Types.Add(typeDeclarationSyntax);
        }
    }
}