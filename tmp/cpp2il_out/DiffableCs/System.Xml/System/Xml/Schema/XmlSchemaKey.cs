namespace System.Xml.Schema;

public class XmlSchemaKey : XmlSchemaIdentityConstraint
{

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaIdentityConstraint), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSchemaKey() { }

}

