namespace Spine.Unity;

public class WaitForSpineAnimation : IEnumerator
{
	[Flags]
	internal enum AnimationEventTypes
	{
		Start = 1,
		Interrupt = 2,
		End = 4,
		Dispose = 8,
		Complete = 16,
	}

	private bool m_WasFired; //Field offset: 0x10

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineAnimation), Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaitForSpineAnimation(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private void HandleComplete(TrackEntry trackEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineAnimation), Member = "SafeSubscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	public WaitForSpineAnimation NowWaitFor(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor) { }

	[CalledBy(Type = typeof(WaitForSpineAnimation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitForSpineAnimation), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(AnimationEventTypes)}, ReturnType = typeof(WaitForSpineAnimation))]
	[CalledBy(Type = typeof(WaitForSpineAnimationComplete), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitForSpineAnimationComplete), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(bool)}, ReturnType = typeof(WaitForSpineAnimationComplete))]
	[CalledBy(Type = typeof(WaitForSpineAnimationEnd), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(WaitForSpineAnimationEnd))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TrackEntry), Member = "add_Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "add_Interrupt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "add_End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "add_Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackEntry), Member = "add_Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	protected void SafeSubscribe(TrackEntry trackEntry, AnimationEventTypes eventsToWaitFor) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	private override void System.Collections.IEnumerator.Reset() { }

}

