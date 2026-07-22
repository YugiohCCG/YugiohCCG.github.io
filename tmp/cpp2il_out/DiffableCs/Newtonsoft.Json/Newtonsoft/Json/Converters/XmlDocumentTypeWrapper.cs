namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
{
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; //Field offset: 0x28

	public override string InternalSubset
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 get { } //Length: 39
	}

	public override string Public
	{
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public override string System
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public XmlDocumentTypeWrapper(XmlDocumentType documentType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_InternalSubset() { }

	[CallerCount(Count = 0)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override string get_Name() { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Public() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_System() { }

}

