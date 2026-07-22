namespace SimpleFileBrowser;

public sealed class OnItemClickedHandler : MulticastDelegate
{

	[CallerCount(Count = 412)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public OnItemClickedHandler(object object, IntPtr method) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(ListItem item, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(ListItem item) { }

}

