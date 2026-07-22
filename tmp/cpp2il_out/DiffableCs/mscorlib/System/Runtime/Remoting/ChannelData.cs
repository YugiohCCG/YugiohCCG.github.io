namespace System.Runtime.Remoting;

internal class ChannelData
{
	internal string Ref; //Field offset: 0x10
	internal string Type; //Field offset: 0x18
	internal string Id; //Field offset: 0x20
	internal string DelayLoadAsClientChannel; //Field offset: 0x28
	private ArrayList _serverProviders; //Field offset: 0x30
	private ArrayList _clientProviders; //Field offset: 0x38
	private Hashtable _customProperties; //Field offset: 0x40

	public ArrayList ClientProviders
	{
		[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	public Hashtable CustomProperties
	{
		[CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	internal ArrayList ServerProviders
	{
		[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ChannelData() { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelData), Member = "get_CustomProperties", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 44)]
	public void CopyFrom(ChannelData other) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ArrayList get_ClientProviders() { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Hashtable get_CustomProperties() { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal ArrayList get_ServerProviders() { }

}

