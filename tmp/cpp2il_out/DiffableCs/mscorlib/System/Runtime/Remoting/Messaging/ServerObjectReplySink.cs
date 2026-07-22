namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectReplySink : IMessageSink
{
	private IMessageSink _replySink; //Field offset: 0x10
	private ServerIdentity _identity; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override IMessage SyncProcessMessage(IMessage msg) { }

}

