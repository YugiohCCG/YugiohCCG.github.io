namespace System.Runtime.Remoting;

internal class ClientActivatedIdentity : ServerIdentity
{
	private MarshalByRefObject _targetThis; //Field offset: 0x70

	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientActivatedServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Type), typeof(string)}, ReturnType = typeof(ClientActivatedIdentity))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ClientActivatedIdentity(string objectUri, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public MarshalByRefObject GetServerObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "DisposeIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	public virtual void OnLifetimeExpired() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetClientProxy(MarshalByRefObject obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

