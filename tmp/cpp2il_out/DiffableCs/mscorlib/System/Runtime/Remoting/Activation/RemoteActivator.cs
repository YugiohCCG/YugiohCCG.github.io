namespace System.Runtime.Remoting.Activation;

internal class RemoteActivator : MarshalByRefObject, IActivator
{

	public override IActivator NextActivator
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingConfiguration), Member = "IsActivationAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject)}, ReturnType = typeof(ObjRef))]
	[Calls(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(LogicalCallContext), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override IActivator get_NextActivator() { }

}

