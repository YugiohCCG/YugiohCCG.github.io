namespace MS.Internal.Xml.XPath;

internal class Group : AstNode
{
	private AstNode _groupNode; //Field offset: 0x10

	public AstNode GroupNode
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Group(AstNode groupNode) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public AstNode get_GroupNode() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

}

