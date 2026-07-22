namespace System.Xml.Schema;

public class XmlSchemaDocumentation : XmlSchemaObject
{
	private static XmlSchemaSimpleType languageType; //Field offset: 0x0
	private string source; //Field offset: 0x38
	private string language; //Field offset: 0x40
	private XmlNode[] markup; //Field offset: 0x48

	[XmlAttribute("xml:lang")]
	public string Language
	{
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildDocumentation_XmlLang", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 236
	}

	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromXsdType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallsUnknownMethods(Count = 1)]
	private static XmlSchemaDocumentation() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaDocumentation() { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildDocumentation_XmlLang", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_Language(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Markup(XmlNode[] value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Source(string value) { }

}

