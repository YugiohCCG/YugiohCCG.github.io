namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
public abstract class PointerCaptureEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IEventHandler <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <pointerId>k__BackingField; //Field offset: 0x0

	public private override int pointerId
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	private IEventHandler relatedTarget
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureOutEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(PointerCaptureOutEvent))]
	[CalledBy(Type = typeof(PointerCaptureOutEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(PointerCaptureEvent))]
	[CalledBy(Type = typeof(PointerCaptureEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected PointerCaptureEventBase`1() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override int get_pointerId() { }

	[CalledBy(Type = typeof(PointerDispatchState), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_pointerId(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_relatedTarget(IEventHandler value) { }

}

