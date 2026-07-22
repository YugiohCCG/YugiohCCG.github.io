namespace System.Runtime.Remoting.Activation;

internal class ConstructionLevelActivator : IActivator
{

	public override IActivator NextActivator
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConstructionLevelActivator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "GetServerContextSinkChain", ReturnType = typeof(IMessageSink))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IActivator get_NextActivator() { }

}

