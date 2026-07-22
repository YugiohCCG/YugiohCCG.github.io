namespace Spine.Unity;

public class WaitForSpineAnimationComplete : WaitForSpineAnimation, IEnumerator
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineAnimation), Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaitForSpineAnimationComplete(TrackEntry trackEntry, bool includeEndEvent = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineAnimation), Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry, bool includeEndEvent = false) { }

}

