namespace System.Xml;

internal class PositionInfo : IXmlLineInfo
{

	public override int LineNumber
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int LinePosition
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PositionInfo() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_LineNumber() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_LinePosition() { }

	[CalledBy(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(SchemaInfo), typeof(string), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(XmlSchema), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static PositionInfo GetPositionInfo(object o) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

}

