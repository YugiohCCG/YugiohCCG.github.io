namespace MS.Internal.Xml.XPath;

internal class Filter : AstNode
{
	private AstNode _input; //Field offset: 0x10
	private AstNode _condition; //Field offset: 0x18

	public AstNode Condition
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AstNode Input
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Filter(AstNode input, AstNode condition) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public AstNode get_Condition() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public AstNode get_Input() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

}

