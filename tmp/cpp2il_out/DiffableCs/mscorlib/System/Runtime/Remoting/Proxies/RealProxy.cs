namespace System.Runtime.Remoting.Proxies;

[ComVisible(True)]
public abstract class RealProxy
{
	private Type class_to_proxy; //Field offset: 0x10
	internal Context _targetContext; //Field offset: 0x18
	internal MarshalByRefObject _server; //Field offset: 0x20
	private int _targetDomainId; //Field offset: 0x28
	internal string _targetUri; //Field offset: 0x30
	internal Identity _objectIdentity; //Field offset: 0x38
	private object _objTP; //Field offset: 0x40
	private object _stubData; //Field offset: 0x48

	internal Identity ObjectIdentity
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected RealProxy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected RealProxy(Type classToProxy) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal RealProxy(Type classToProxy, ClientIdentity identity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	protected RealProxy(Type classToProxy, IntPtr stub, object stubData) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void AttachServer(MarshalByRefObject s) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal Identity get_ObjectIdentity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal object GetAppDomainTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingServices), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "get_TypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "CanCastTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	public Type GetProxiedType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override object GetTransparentProxy() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Type InternalGetProxyType(object transparentProxy) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal override object InternalGetTransparentProxy(string className) { }

	public abstract IMessage Invoke(IMessage msg) { }

	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = "FixRemotingException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(LogicalCallContext), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(int), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(AsyncResult), Member = "EndInvoke", ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(ConstructionCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsConstructor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(CallType))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(MethodCall), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 40)]
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Object[] out_args) { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoMethodMessage), Member = "NeedsOutProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoMethodMessage), Member = "GetArg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "UpdateOutArgObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 31)]
	private static Object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ObjectIdentity(Identity value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal void SetTargetDomain(int domainId) { }

}

