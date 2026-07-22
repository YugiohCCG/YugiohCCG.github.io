namespace System.Runtime.Remoting.Activation;

internal class ActivationServices
{
	private static IActivator _constructionActivator; //Field offset: 0x0

	private static IActivator ConstructionActivator
	{
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 160
	}

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[Calls(Type = typeof(ActivationServices), Member = "RemoteActivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(RemotingProxy), Member = "AttachIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static object AllocateUninitializedClassInstance(Type type) { }

	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ActivationServices), Member = "get_ConstructionActivator", ReturnType = typeof(IActivator))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 47)]
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Object[] activationAttributes) { }

	[CalledBy(Type = typeof(ServerContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RemotingServices), Member = "GetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(Identity))]
	[Calls(Type = typeof(ServerIdentity), Member = "AttachServerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(Context)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingProxy), Member = "AttachIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsRemotelyActivatedClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ActivatedClientTypeEntry))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsWellKnownClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(WellKnownClientTypeEntry))]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownClientTypeEntry)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedClientTypeEntry), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static object CreateProxyForType(Type type) { }

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedClientTypeEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownClientTypeEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void EnableProxyActivation(Type type, bool enable) { }

	[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static IActivator get_ConstructionActivator() { }

	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

}

