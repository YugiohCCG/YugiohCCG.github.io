namespace System.Runtime.Remoting;

internal class DisposerReplySink : IMessageSink
{
	private IMessageSink _next; //Field offset: 0x10
	private IDisposable _disposable; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DisposerReplySink(IMessageSink next, IDisposable disposable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

