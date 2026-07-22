namespace MS.Internal.Xml.XPath;

internal class Root : AstNode
{

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

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Root() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

}

