namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	private static object s_lock; //Field offset: 0x0

	public override object ChannelData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 get { } //Length: 89
	}

	public override string ChannelName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public override int ChannelPriority
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static CrossAppDomainChannel() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CrossAppDomainChannel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
	[Calls(Type = typeof(CrossAppDomainSink), Member = "GetSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CrossAppDomainSink))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override object get_ChannelData() { }

	[CallerCount(Count = 0)]
	public override string get_ChannelName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int get_ChannelPriority() { }

	[CalledBy(Type = typeof(RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingServices), Member = "RegisterInternalChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void RegisterCrossAppDomainChannel() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void StartListening(object data) { }

}

