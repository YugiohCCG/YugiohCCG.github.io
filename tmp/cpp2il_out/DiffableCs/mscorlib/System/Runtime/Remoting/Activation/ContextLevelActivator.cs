namespace System.Runtime.Remoting.Activation;

internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator; //Field offset: 0x10

	public override IActivator NextActivator
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContextLevelActivator(IActivator next) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingServices), Member = "CreateContextBoundObjectIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ClientActivatedIdentity))]
	[Calls(Type = typeof(RemotingServices), Member = "SetMessageTargetIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(Identity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Context), Member = "CreateNewContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(Context), Member = "SwitchToContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[CallsUnknownMethods(Count = 7)]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override IActivator get_NextActivator() { }

}

