namespace MS.Internal.Xml.XPath;

internal class Axis : AstNode
{
	internal enum AxisType
	{
		Ancestor = 0,
		AncestorOrSelf = 1,
		Attribute = 2,
		Child = 3,
		Descendant = 4,
		DescendantOrSelf = 5,
		Following = 6,
		FollowingSibling = 7,
		Namespace = 8,
		Parent = 9,
		Preceding = 10,
		PrecedingSibling = 11,
		Self = 12,
		None = 13,
	}

	private AxisType _axisType; //Field offset: 0x10
	private AstNode _input; //Field offset: 0x18
	private string _prefix; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private XPathNodeType _nodeType; //Field offset: 0x30
	protected bool abbrAxis; //Field offset: 0x34
	private string _urn; //Field offset: 0x38

	public bool AbbrAxis
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AstNode Input
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Name
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathNodeType NodeType
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Prefix
	{
		[CallerCount(Count = 12)]
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
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public AxisType TypeOfAxis
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Urn
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(DoubleLinkAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(DoubleLinkAxis)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DoubleLinkAxis), Member = "ConvertTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis)}, ReturnType = typeof(DoubleLinkAxis))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseNodeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(AxisType), typeof(XPathNodeType)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseRelativeLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Axis(AxisType axisType, AstNode input) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AbbrAxis() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public AstNode get_Input() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public XPathNodeType get_NodeType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public AxisType get_TypeOfAxis() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_Urn() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Input(AstNode value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Urn(string value) { }

}

