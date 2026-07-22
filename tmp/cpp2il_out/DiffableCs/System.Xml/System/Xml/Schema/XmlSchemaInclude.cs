namespace System.Xml.Schema;

public class XmlSchemaInclude : XmlSchemaExternal
{
	private XmlSchemaAnnotation annotation; //Field offset: 0x68

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitInclude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlSchemaInclude() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

