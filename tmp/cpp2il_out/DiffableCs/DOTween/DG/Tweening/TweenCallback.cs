namespace DG.Tweening;

public sealed class TweenCallback : MulticastDelegate
{

	[CallerCount(Count = 536)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TweenCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke() { }

}

