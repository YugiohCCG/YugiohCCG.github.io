namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory::EnterLeave (4))]
public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent>
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
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		internal PointerOutLinkTagEvent <.cctor>b__0_0() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static PointerOutLinkTagEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	public PointerOutLinkTagEvent() { }

	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerOutEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void LocalInit() { }

}

