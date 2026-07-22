namespace System.Runtime.Remoting;

internal abstract class ServerIdentity : Identity
{
	protected Type _objectType; //Field offset: 0x48
	protected MarshalByRefObject _serverObject; //Field offset: 0x50
	protected IMessageSink _serverSink; //Field offset: 0x58
	protected Context _context; //Field offset: 0x60
	protected Lease _lease; //Field offset: 0x68

	public Context Context
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Lease Lease
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type ObjectType
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ServerIdentity(string objectUri, Context context, Type objectType) { }

	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Type), typeof(string)}, ReturnType = typeof(ClientActivatedIdentity))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjRef), Member = "UpdateChannelInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	[CalledBy(Type = typeof(ServerIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "OnLifetimeExpired", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MarshalByRefObject), Member = "set_ObjectIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackingServices), Member = "NotifyDisconnectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void DisposeServerObject() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public Context get_Context() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public Lease get_Lease() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Type get_ObjectType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	public override void OnLifetimeExpired() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Context(Context value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void StartTrackingLifetime(ILease lease) { }

	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

}

