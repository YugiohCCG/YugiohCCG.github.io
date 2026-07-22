namespace Spine.Unity;

public class WaitForSpineAnimationEnd : WaitForSpineAnimation, IEnumerator
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public WaitForSpineAnimationEnd(TrackEntry trackEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineAnimation), Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	public WaitForSpineAnimationEnd NowWaitFor(TrackEntry trackEntry) { }

}

