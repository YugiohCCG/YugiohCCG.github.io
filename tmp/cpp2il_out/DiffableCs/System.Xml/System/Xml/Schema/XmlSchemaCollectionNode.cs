namespace System.Xml.Schema;

internal sealed class XmlSchemaCollectionNode
{
	private string namespaceUri; //Field offset: 0x10
	private SchemaInfo schemaInfo; //Field offset: 0x18
	private XmlSchema schema; //Field offset: 0x20

	internal string NamespaceURI
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal XmlSchema Schema
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal SchemaInfo SchemaInfo
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaCollectionNode() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal XmlSchema get_Schema() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal SchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_NamespaceURI(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Schema(XmlSchema value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SchemaInfo(SchemaInfo value) { }

}

