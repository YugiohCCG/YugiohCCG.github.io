namespace System.Runtime.Remoting;

internal abstract class Identity
{
	protected string _objectUri; //Field offset: 0x10
	protected IMessageSink _channelSink; //Field offset: 0x18
	protected IMessageSink _envoySink; //Field offset: 0x20
	private DynamicPropertyCollection _clientDynamicProperties; //Field offset: 0x28
	private DynamicPropertyCollection _serverDynamicProperties; //Field offset: 0x30
	protected ObjRef _objRef; //Field offset: 0x38
	private bool _disposed; //Field offset: 0x40

	public IMessageSink ChannelSink
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DynamicPropertyCollection ClientDynamicProperties
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 188
	}

	public bool Disposed
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public IMessageSink EnvoySink
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool HasServerDynamicSinks
	{
		[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 62
	}

	public bool IsConnected
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public string ObjectUri
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Identity(string objectUri) { }

	public abstract ObjRef CreateObjRef(Type requestedType) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public IMessageSink get_ChannelSink() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_Disposed() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public IMessageSink get_EnvoySink() { }

	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasServerDynamicSinks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsConnected() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_ObjectUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ServerObjectTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ServerObjectReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ChannelSink(IMessageSink value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Disposed(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ObjectUri(string value) { }

}

