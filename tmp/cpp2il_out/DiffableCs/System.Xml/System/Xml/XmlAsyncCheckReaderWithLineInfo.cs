namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
{
	private readonly IXmlLineInfo readerAsIXmlLineInfo; //Field offset: 0x20

	public override int LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 73
	}

	public override int LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 73
	}

	[CalledBy(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public XmlAsyncCheckReaderWithLineInfo(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool HasLineInfo() { }

}

