namespace UnityEngine.UIElements;

[EventCategory(EventCategory::PointerDown (3))]
public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		internal MouseDownEvent <.cctor>b__0_0() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static MouseDownEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	public MouseDownEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

