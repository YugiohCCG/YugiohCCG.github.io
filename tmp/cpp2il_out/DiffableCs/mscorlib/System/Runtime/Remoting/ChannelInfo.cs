namespace System.Runtime.Remoting;

internal class ChannelInfo : IChannelInfo
{
	private Object[] channelData; //Field offset: 0x10

	public override Object[] ChannelData
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChannelServices), Member = "GetCurrentChannelInfo", ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ChannelInfo() { }

	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ChannelInfo(object remoteChannelData) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override Object[] get_ChannelData() { }

}

