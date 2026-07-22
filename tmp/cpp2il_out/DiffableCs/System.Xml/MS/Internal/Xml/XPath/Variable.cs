namespace MS.Internal.Xml.XPath;

internal class Variable : AstNode
{
	private string _localname; //Field offset: 0x10
	private string _prefix; //Field offset: 0x18

	public string Localname
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Prefix
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual AstType Type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Variable(string name, string prefix) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Localname() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

}

