namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class HeaderHandler : MulticastDelegate
{

	[CallerCount(Count = 225)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public HeaderHandler(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override object Invoke(Header[] headers) { }

}

