using System.Collections.Immutable;
using Luthetus.TextEditor.RazorLib.CompilerServices.Syntax.Nodes;
using Luthetus.TextEditor.RazorLib.CompilerServices.Syntax.Tokens;
using Luthetus.TextEditor.RazorLib.Lexers.Models;

namespace Luthetus.TextEditor.Tests.Basis.CompilerServices.Syntax.SyntaxNodes;

/// <summary>
/// <see cref="ConstructorDefinitionNode"/>
/// </summary>
public class ConstructorDefinitionNodeTests
{
    /// <summary>
    /// <see cref="ConstructorDefinitionNode(TypeClauseNode, IdentifierToken, RazorLib.CompilerServices.Syntax.SyntaxNodes.GenericArgumentsListingNode?, FunctionArgumentsListingNode, Luthetus.TextEditor.RazorLib.CompilerServices.Syntax.Nodes.CodeBlockNode?, RazorLib.CompilerServices.Syntax.SyntaxNodes.ConstraintNode?)"/>
    /// <br/>----<br/>
    /// <see cref="ConstructorDefinitionNode.ReturnTypeClauseNode"/>
    /// <see cref="ConstructorDefinitionNode.FunctionIdentifier"/>
    /// <see cref="ConstructorDefinitionNode.GenericArgumentsListingNode"/>
    /// <see cref="ConstructorDefinitionNode.FunctionArgumentsListingNode"/>
    /// <see cref="ConstructorDefinitionNode.FunctionBodyCodeBlockNode"/>
    /// <see cref="ConstructorDefinitionNode.ConstraintNode"/>
    /// <see cref="ConstructorDefinitionNode.ChildList"/>
    /// <see cref="ConstructorDefinitionNode.IsFabricated"/>
    /// <see cref="ConstructorDefinitionNode.SyntaxKind"/>
    /// </summary>
    [Fact]
	public void Constructor()
    {
        var sourceText = @"public class MyClass
{
    public MyClass()
    {
    }
}";

        TypeClauseNode myClassTypeClauseNode;
        {
            var myClassTypeIdentifier = new IdentifierToken(
                TextEditorTextSpan.FabricateTextSpan("MyClass"));

            myClassTypeClauseNode = new TypeClauseNode(
                myClassTypeIdentifier,
                null,
                null);
        }
        
        IdentifierToken functionIdentifierToken;
        {
            functionIdentifierToken = new IdentifierToken(
                TextEditorTextSpan.FabricateTextSpan("MyClass"));
        }

        FunctionArgumentsListingNode functionArgumentsListingNode;
        {
            var openParenthesisText = "(";
            int indexOfOpenParenthesisText = sourceText.IndexOf(openParenthesisText);
            var openParenthesisToken = new OpenParenthesisToken(new TextEditorTextSpan(
                indexOfOpenParenthesisText,
                indexOfOpenParenthesisText + openParenthesisText.Length,
                0,
                new ResourceUri("/unitTesting.txt"),
                sourceText));

            var functionArgumentEntryNodes = ImmutableArray<FunctionArgumentEntryNode>.Empty;

            var closeParenthesisText = ")";
            int indexOfCloseParenthesisText = sourceText.IndexOf(closeParenthesisText);
            var closeParenthesisToken = new CloseParenthesisToken(new TextEditorTextSpan(
                indexOfCloseParenthesisText,
                indexOfCloseParenthesisText + closeParenthesisText.Length,
                0,
                new ResourceUri("/unitTesting.txt"),
                sourceText));

            functionArgumentsListingNode = new FunctionArgumentsListingNode(
                openParenthesisToken,
                functionArgumentEntryNodes.AsReadOnly(),
                closeParenthesisToken);
        }

        GenericArgumentsListingNode? genericArgumentsListingNode = null;

        CodeBlockNode codeBlockNode;
        {
            codeBlockNode = new CodeBlockNode(
                ImmutableArray<RazorLib.CompilerServices.Syntax.ISyntax>.Empty);
        }

        ConstraintNode? constraintNode = null;

        var constructorDefinitionNode = new ConstructorDefinitionNode(
            myClassTypeClauseNode,
            functionIdentifierToken,
            genericArgumentsListingNode,
            functionArgumentsListingNode,
            codeBlockNode,
            constraintNode);

        Assert.Equal(myClassTypeClauseNode, constructorDefinitionNode.ReturnTypeClauseNode);
        Assert.Equal(functionIdentifierToken, constructorDefinitionNode.FunctionIdentifier);
        Assert.Equal(genericArgumentsListingNode, constructorDefinitionNode.GenericArgumentsListingNode);
        Assert.Equal(functionArgumentsListingNode, constructorDefinitionNode.FunctionArgumentsListingNode);
        Assert.Equal(codeBlockNode, constructorDefinitionNode.FunctionBodyCodeBlockNode);
        Assert.Equal(constraintNode, constructorDefinitionNode.ConstraintNode);

        Assert.Equal(4, constructorDefinitionNode.GetChildList().Length);
        Assert.Equal(myClassTypeClauseNode, constructorDefinitionNode.GetChildList()[0]);
        Assert.Equal(functionIdentifierToken, constructorDefinitionNode.GetChildList()[1]);
        Assert.Equal(functionArgumentsListingNode, constructorDefinitionNode.GetChildList()[2]);
        Assert.Equal(codeBlockNode, constructorDefinitionNode.GetChildList()[3]);

        Assert.False(constructorDefinitionNode.IsFabricated);

        Assert.Equal(
            RazorLib.CompilerServices.Syntax.SyntaxKind.ConstructorDefinitionNode,
            constructorDefinitionNode.SyntaxKind);
    }
}
