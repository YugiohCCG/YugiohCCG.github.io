namespace System.Runtime.Remoting;

[ComVisible(True)]
public static class RemotingConfiguration
{
	private static string applicationID; //Field offset: 0x0
	private static string applicationName; //Field offset: 0x8
	private static string processGuid; //Field offset: 0x10
	private static bool defaultConfigRead; //Field offset: 0x18
	private static bool defaultDelayedConfigRead; //Field offset: 0x19
	private static CustomErrorsModes _errorMode; //Field offset: 0x1C
	private static Hashtable wellKnownClientEntries; //Field offset: 0x20
	private static Hashtable activatedClientEntries; //Field offset: 0x28
	private static Hashtable wellKnownServiceEntries; //Field offset: 0x30
	private static Hashtable activatedServiceEntries; //Field offset: 0x38
	private static Hashtable channelTemplates; //Field offset: 0x40
	private static Hashtable clientProviderTemplates; //Field offset: 0x48
	private static Hashtable serverProviderTemplates; //Field offset: 0x50

	public static string ApplicationName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 110
	}

	public static string ProcessId
	{
		[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 219
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static RemotingConfiguration() { }

	[CallerCount(Count = 0)]
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	[CallerCount(Count = 0)]
	public static string get_ApplicationName() { }

	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_ProcessId() { }

	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsActivationAllowed(Type svrType) { }

	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetMachineConfigPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal static void LoadDefaultDelayedChannels() { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivationServices), Member = "EnableProxyActivation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallXmlParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 57)]
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallXmlParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedClientTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedServiceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedServiceTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownClientTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownServiceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownServiceTypeEntry)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	internal static void RegisterTypes(ArrayList types) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivationServices), Member = "EnableProxyActivation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(WellKnownObjectMode)}, ReturnType = typeof(ServerIdentity))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void set_ApplicationName(string value) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal static void SetCustomErrorsMode(string mode) { }

}

