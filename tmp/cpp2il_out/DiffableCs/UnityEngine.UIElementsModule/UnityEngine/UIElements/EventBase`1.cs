namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Default (0))]
public abstract class EventBase : EventBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		internal T <.cctor>b__15_0() { }

	}

	private static readonly long s_TypeId; //Field offset: 0x0
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0
	internal static readonly EventCategory EventCategory; //Field offset: 0x0
	private int m_RefCount; //Field offset: 0x0

	public virtual long eventTypeId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 119
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "RegisterEventType", ReturnType = typeof(long))]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetEventCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventCategory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	private static EventBase`1() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(EventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected EventBase`1() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual void Acquire() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "get_pooled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public virtual void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual long get_eventTypeId() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T GetPooled() { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DropdownMenu), typeof(IEventHandler), typeof(ContextualMenuManager)}, ReturnType = typeof(ContextualMenuPopulateEvent))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal static T GetPooled(EventBase e) { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransitionEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TooltipEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelChangedEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GeometryChangedEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMEEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChangeEvent`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCaptureEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "get_pooled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_pooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static void ReleasePooled(T evt) { }

	[CallerCount(Count = 55)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static void SetCreateFunction(Func<T> createMethod) { }

	[CallerCount(Count = 60)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static long TypeId() { }

}

