namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public sealed class ChannelServices
{
	private static ArrayList registeredChannels; //Field offset: 0x0
	private static ArrayList delayedClientChannels; //Field offset: 0x8
	private static CrossContextChannel _crossContextSink; //Field offset: 0x10
	internal static string CrossContextUrl; //Field offset: 0x18
	private static IList oldStartModeTypes; //Field offset: 0x20

	internal static CrossContextChannel CrossContextChannel
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static ChannelServices() { }

	[CalledBy(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannelSender), typeof(string), typeof(Object[]), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Object[] channelDataArray, out string objectUri) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 35)]
	private static object CreateProvider(ProviderData prov) { }

	[CallerCount(Count = 0)]
	internal static CrossContextChannel get_CrossContextChannel() { }

	[CalledBy(Type = typeof(ChannelInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	internal static Object[] GetCurrentChannelInfo() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private static bool IsLocalCall(IMessage callMsg) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "RegisterCrossAppDomainChannel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel), typeof(bool)}, ReturnType = typeof(void))]
	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	public static void RegisterChannel(IChannel chnl) { }

	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 40)]
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelServices), Member = "CreateProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 98)]
	internal static void RegisterChannelConfig(ChannelData channel) { }

	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(ReturnMessage))]
	[Calls(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(ChannelServices), Member = "CheckReturnMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallsUnknownMethods(Count = 1)]
	public static IMessage SyncDispatchMessage(IMessage msg) { }

}

