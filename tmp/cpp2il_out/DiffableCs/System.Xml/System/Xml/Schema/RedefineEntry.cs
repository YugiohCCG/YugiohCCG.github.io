namespace System.Xml.Schema;

internal class RedefineEntry
{
	internal XmlSchemaRedefine redefine; //Field offset: 0x10
	internal XmlSchema schemaToUpdate; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public RedefineEntry(XmlSchemaRedefine external, XmlSchema schema) { }

}

