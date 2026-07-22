namespace System.Xml.Schema;

internal sealed class SchemaNotation
{
	private XmlQualifiedName name; //Field offset: 0x10
	private string systemLiteral; //Field offset: 0x18
	private string pubid; //Field offset: 0x20

	internal XmlQualifiedName Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string Pubid
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal string SystemLiteral
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SchemaNotation(XmlQualifiedName name) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_Name() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_Pubid() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string get_SystemLiteral() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Pubid(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SystemLiteral(string value) { }

}

