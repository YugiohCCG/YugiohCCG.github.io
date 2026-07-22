namespace Mono.Nat.Upnp;

internal abstract class RequestMessage : IRequestMessage
{
	[CompilerGenerated]
	private readonly UpnpNatDevice <Device>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <RequestType>k__BackingField; //Field offset: 0x18

	protected UpnpNatDevice Device
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private string RequestType
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected RequestMessage(UpnpNatDevice device, string requestType) { }

	[CalledBy(Type = typeof(RequestMessage), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&)}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	protected HttpWebRequest CreateRequest(string upnpMethod, string methodParameters, out Byte[] body) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<SendMessageAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(RequestMessage), Member = "CreateRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Byte[]&)}, ReturnType = typeof(HttpWebRequest))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override HttpWebRequest Encode(out Byte[] body) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Encode(XmlWriter writer) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected UpnpNatDevice get_Device() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private string get_RequestType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static void WriteFullElement(XmlWriter writer, string element, IPAddress value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void WriteFullElement(XmlWriter writer, string element, Protocol value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void WriteFullElement(XmlWriter writer, string element, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void WriteFullElement(XmlWriter writer, string element, string value) { }

}

