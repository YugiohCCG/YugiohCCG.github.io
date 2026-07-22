namespace System.Xml.Schema;

public class XmlSchemaEnumerationFacet : XmlSchemaFacet
{

	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlSchemaEnumerationFacet() { }

}

