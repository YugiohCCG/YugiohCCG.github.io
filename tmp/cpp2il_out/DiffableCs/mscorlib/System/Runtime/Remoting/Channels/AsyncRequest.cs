namespace System.Runtime.Remoting.Channels;

internal class AsyncRequest
{
	internal IMessageSink ReplySink; //Field offset: 0x10
	internal IMessage MsgRequest; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AsyncRequest(IMessage msgRequest, IMessageSink replySink) { }

}

