namespace System.Runtime.Remoting.Messaging;

internal class StackBuilderSink : IMessageSink
{
	private MarshalByRefObject _target; //Field offset: 0x10
	private RealProxy _rp; //Field offset: 0x18

	[CalledBy(Type = typeof(Context), Member = "CreateServerObjectSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RealProxy))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackBuilderSink), Member = "ExecuteAsyncMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <AsyncProcessMessage>b__4_0(object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CalledBy(Type = typeof(StackBuilderSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(StackBuilderSink), Member = "ExecuteAsyncMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 35)]
	private void CheckParameters(IMessage msg) { }

	[CalledBy(Type = typeof(StackBuilderSink), Member = "<AsyncProcessMessage>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StackBuilderSink), Member = "CheckParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void ExecuteAsyncMessage(object ob) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackBuilderSink), Member = "CheckParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

