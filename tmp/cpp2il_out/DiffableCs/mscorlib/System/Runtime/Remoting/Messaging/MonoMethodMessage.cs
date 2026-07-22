namespace System.Runtime.Remoting.Messaging;

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
{
	private RuntimeMethodInfo method; //Field offset: 0x10
	private Object[] args; //Field offset: 0x18
	private String[] names; //Field offset: 0x20
	private Byte[] arg_types; //Field offset: 0x28
	public LogicalCallContext ctx; //Field offset: 0x30
	public object rval; //Field offset: 0x38
	public Exception exc; //Field offset: 0x40
	private AsyncResult asyncResult; //Field offset: 0x48
	private CallType call_type; //Field offset: 0x50
	private string uri; //Field offset: 0x58
	private MCMDictionary properties; //Field offset: 0x60
	private Identity identity; //Field offset: 0x68
	private Type[] methodSignature; //Field offset: 0x70

	public override int ArgCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RemotingServices), Member = "IsOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(bool))]
		 get { } //Length: 144
	}

	public override Object[] Args
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AsyncResult AsyncResult
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	internal CallType CallType
	{
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(RemotingServices), Member = "IsOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(bool))]
		internal get { } //Length: 108
	}

	public override Exception Exception
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override LogicalCallContext LogicalCallContext
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public override MethodBase MethodBase
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string MethodName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 86
	}

	public override object MethodSignature
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 324
	}

	public override int OutArgCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 94
	}

	public override Object[] OutArgs
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 374
	}

	public override IDictionary Properties
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MCMDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 109
	}

	public override object ReturnValue
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public override string TypeName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 110
	}

	public override string Uri
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public MonoMethodMessage(MethodBase method, Object[] out_args) { }

	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal MonoMethodMessage(MethodInfo minfo, Object[] in_args, Object[] out_args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public MonoMethodMessage(Type type, string methodName, Object[] in_args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingServices), Member = "IsOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(bool))]
	public override int get_ArgCount() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override Object[] get_Args() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public AsyncResult get_AsyncResult() { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RemotingServices), Member = "IsOneWay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(bool))]
	internal CallType get_CallType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override Exception get_Exception() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override LogicalCallContext get_LogicalCallContext() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override MethodBase get_MethodBase() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_MethodName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public override object get_MethodSignature() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_OutArgCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override Object[] get_OutArgs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MCMDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override IDictionary get_Properties() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public override object get_ReturnValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_TypeName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override string get_Uri() { }

	[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetArg(int arg_num) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Object[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	internal void InitMessage(RuntimeMethodInfo method, Object[] out_args) { }

	[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool NeedsOutProcessing(out int outCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_LogicalCallContext(LogicalCallContext value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Uri(string value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

}

