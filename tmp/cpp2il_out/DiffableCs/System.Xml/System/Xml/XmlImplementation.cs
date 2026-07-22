namespace System.Xml;

public class XmlImplementation
{
	private XmlNameTable nameTable; //Field offset: 0x10

	internal XmlNameTable NameTable
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XmlImplementation() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlImplementation(XmlNameTable nt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlImplementation)}, ReturnType = typeof(void))]
	public override XmlDocument CreateDocument() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlNameTable get_NameTable() { }

}

