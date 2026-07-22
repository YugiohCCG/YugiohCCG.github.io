namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
{
	[Nullable(1)]
	private readonly XDocumentType _documentType; //Field offset: 0x18

	public override string InternalSubset
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[Nullable(1)]
	public override string Name
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 get { } //Length: 27
	}

	public override string Public
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	public override string System
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CalledBy(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	public XDocumentTypeWrapper(XDocumentType documentType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_InternalSubset() { }

	[CallerCount(Count = 0)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_Public() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_System() { }

}

