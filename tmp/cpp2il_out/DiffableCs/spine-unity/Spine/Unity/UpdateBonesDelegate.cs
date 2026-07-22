namespace Spine.Unity;

public sealed class UpdateBonesDelegate : MulticastDelegate
{

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public UpdateBonesDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(ISkeletonAnimation animated, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(ISkeletonAnimation animated) { }

}

