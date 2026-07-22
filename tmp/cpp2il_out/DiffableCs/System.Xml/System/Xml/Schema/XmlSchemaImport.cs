namespace System.Xml.Schema;

public class XmlSchemaImport : XmlSchemaExternal
{
	private string ns; //Field offset: 0x68
	private XmlSchemaAnnotation annotation; //Field offset: 0x70

	[XmlAttribute("namespace", DataType = "anyURI")]
	public string Namespace
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitImport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlSchemaImport() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

}

