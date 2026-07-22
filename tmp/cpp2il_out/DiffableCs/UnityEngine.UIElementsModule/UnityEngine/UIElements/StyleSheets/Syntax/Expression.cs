namespace UnityEngine.UIElements.StyleSheets.Syntax;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Expression
{
	public ExpressionType type; //Field offset: 0x10
	public ExpressionMultiplier multiplier; //Field offset: 0x14
	public DataType dataType; //Field offset: 0x20
	public ExpressionCombinator combinator; //Field offset: 0x24
	public Expression[] subExpressions; //Field offset: 0x28
	public string keyword; //Field offset: 0x30

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Expression(ExpressionType type) { }

}

