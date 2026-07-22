namespace DG.Tweening.Core;

public sealed class DOGetter : MulticastDelegate
{

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public DOGetter`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override T EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override T Invoke() { }

}

