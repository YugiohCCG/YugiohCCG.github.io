namespace System.Runtime.Remoting;

internal class SingletonIdentity : ServerIdentity
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SingletonIdentity(string objectUri, Context context, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[CallsUnknownMethods(Count = 3)]
	public virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public MarshalByRefObject GetServerObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[Calls(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[CallsUnknownMethods(Count = 3)]
	public virtual IMessage SyncObjectProcessMessage(IMessage msg) { }

}

