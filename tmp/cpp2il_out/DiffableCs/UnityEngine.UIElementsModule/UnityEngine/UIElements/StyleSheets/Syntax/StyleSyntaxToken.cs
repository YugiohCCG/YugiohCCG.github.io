namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal struct StyleSyntaxToken
{
	public StyleSyntaxTokenType type; //Field offset: 0x0
	public string text; //Field offset: 0x8
	public int number; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleSyntaxToken(StyleSyntaxTokenType t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleSyntaxToken(StyleSyntaxTokenType type, string text) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleSyntaxToken(StyleSyntaxTokenType type, int number) { }

}

