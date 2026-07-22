namespace System.Runtime.Remoting;

internal class ProviderData
{
	internal string Ref; //Field offset: 0x10
	internal string Type; //Field offset: 0x18
	internal string Id; //Field offset: 0x20
	internal Hashtable CustomProperties; //Field offset: 0x28
	internal IList CustomData; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ProviderData() { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 29)]
	public void CopyFrom(ProviderData other) { }

}

