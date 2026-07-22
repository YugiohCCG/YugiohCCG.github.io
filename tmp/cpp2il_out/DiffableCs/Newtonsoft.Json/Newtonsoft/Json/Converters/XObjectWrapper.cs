namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XObjectWrapper : IXmlNode
{
	private readonly XObject _xmlObject; //Field offset: 0x10

	[Nullable(1)]
	public override List<IXmlNode> Attributes
	{
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		 get { } //Length: 78
	}

	[Nullable(1)]
	public override List<IXmlNode> ChildNodes
	{
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		 get { } //Length: 78
	}

	public override string LocalName
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string NamespaceUri
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 29
	}

	public override IXmlNode ParentNode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string Value
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public override object WrappedNode
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XObjectWrapper(XObject xmlObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public override List<IXmlNode> get_Attributes() { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public override List<IXmlNode> get_ChildNodes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override string get_LocalName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override string get_NamespaceUri() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override XmlNodeType get_NodeType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IXmlNode get_ParentNode() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override string get_Value() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override object get_WrappedNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void set_Value(string value) { }

}

