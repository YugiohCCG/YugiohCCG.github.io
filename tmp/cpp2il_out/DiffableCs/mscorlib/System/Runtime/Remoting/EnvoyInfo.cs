namespace System.Runtime.Remoting;

internal class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks; //Field offset: 0x10

	public override IMessageSink EnvoySinks
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public EnvoyInfo(IMessageSink sinks) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override IMessageSink get_EnvoySinks() { }

}

