namespace MS.Internal.Xml.XPath;

internal class Operand : AstNode
{
	private XPathResultType _type; //Field offset: 0x10
	private object _val; //Field offset: 0x18

	public object OperandValue
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual AstType Type
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Operand(string val) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseUnaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Operand(double val) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public object get_OperandValue() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

}

