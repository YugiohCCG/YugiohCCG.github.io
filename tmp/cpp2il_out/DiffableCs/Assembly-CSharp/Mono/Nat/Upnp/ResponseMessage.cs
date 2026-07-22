namespace Mono.Nat.Upnp;

internal class ResponseMessage
{
	[CompilerGenerated]
	private static readonly Logger <Log>k__BackingField; //Field offset: 0x0

	private static Logger Log
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Logger))]
	[CallsUnknownMethods(Count = 1)]
	private static ResponseMessage() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ResponseMessage() { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DecodeMessageFromResponse>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "SelectSingleNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(Logger), Member = "ErrorFormatted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GetSpecificPortMappingEntryResponseMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GetGenericPortMappingEntryResponseMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MappingException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 23)]
	public static ResponseMessage Decode(UpnpNatDevice device, string message) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static Logger get_Log() { }

}

