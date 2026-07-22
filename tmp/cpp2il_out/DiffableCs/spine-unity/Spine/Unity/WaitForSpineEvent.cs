namespace Spine.Unity;

public class WaitForSpineEvent : IEnumerator
{
	private EventData m_TargetEvent; //Field offset: 0x10
	private string m_EventName; //Field offset: 0x18
	private AnimationState m_AnimationState; //Field offset: 0x20
	private bool m_WasFired; //Field offset: 0x28
	private bool m_unsubscribeAfterFiring; //Field offset: 0x29

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	public bool WillUnsubscribeAfterFiring
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "add_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public WaitForSpineEvent(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "add_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, EventData eventDataReference, bool unsubscribeAfterFiring = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineEvent), Member = "SubscribeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaitForSpineEvent(AnimationState state, string eventName, bool unsubscribeAfterFiring = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineEvent), Member = "SubscribeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = true) { }

	[CalledBy(Type = typeof(WaitForSpineEvent), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(EventData), typeof(bool)}, ReturnType = typeof(WaitForSpineEvent))]
	[CalledBy(Type = typeof(WaitForSpineEvent), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(WaitForSpineEvent))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "remove_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Clear(AnimationState state) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_WillUnsubscribeAfterFiring() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "remove_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void HandleAnimationStateEvent(TrackEntry trackEntry, Event e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "remove_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void HandleAnimationStateEventByName(TrackEntry trackEntry, Event e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineEvent), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "add_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public WaitForSpineEvent NowWaitFor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSpineEvent), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitForSpineEvent), Member = "SubscribeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public WaitForSpineEvent NowWaitFor(AnimationState state, string eventName, bool unsubscribeAfterFiring = true) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_WillUnsubscribeAfterFiring(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "add_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Subscribe(AnimationState state, EventData eventDataReference, bool unsubscribe) { }

	[CalledBy(Type = typeof(WaitForSpineEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitForSpineEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonAnimation), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitForSpineEvent), Member = "NowWaitFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationState), typeof(string), typeof(bool)}, ReturnType = typeof(WaitForSpineEvent))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "add_Event", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryEventDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SubscribeByName(AnimationState state, string eventName, bool unsubscribe) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	private override void System.Collections.IEnumerator.Reset() { }

}

