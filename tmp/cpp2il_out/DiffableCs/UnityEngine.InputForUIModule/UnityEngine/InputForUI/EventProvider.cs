namespace UnityEngine.InputForUI;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class EventProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Registration> <>9__5_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		internal int <Subscribe>b__5_0(Registration a, Registration b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public EventConsumer handler; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		internal bool <Unsubscribe>b__0(Registration x) { }

	}

	private struct Registration
	{
		public EventConsumer handler; //Field offset: 0x0
		public int priority; //Field offset: 0x8
		public Nullable<Int32> playerId; //Field offset: 0xC
		public HashSet<Type> _types; //Field offset: 0x18

	}

	private static IEventProviderImpl s_impl; //Field offset: 0x0
	private static EventSanitizer s_sanitizer; //Field offset: 0x8
	private static IEventProviderImpl s_implMockBackup; //Field offset: 0x10
	private static bool s_focusChangedRegistered; //Field offset: 0x18
	private static bool m_IsEnabled; //Field offset: 0x19
	private static bool m_IsInitialized; //Field offset: 0x1A
	private static List<Registration> _registrations; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManagerProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static EventProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	private static void Bootstrap() { }

	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckIfIMEChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "SubmitCancelNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "NextPreviousNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(EventSanitizer), Member = "Inspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal static void Dispatch(in Event ev) { }

	[CalledBy(Type = typeof(EventProvider), Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventConsumer), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(Type[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "Bootstrap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "SetInputSystemProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventProviderImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventSanitizer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "add_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSanitizer), Member = "BeforeProviderUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSanitizer), Member = "AfterProviderUpdate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	internal static void NotifyUpdate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void OnFocusChanged(bool focus) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventProvider), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	public static void SetEnabled(bool enable) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventProvider), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetInputSystemProvider(IEventProviderImpl impl) { }

	[CalledBy(Type = typeof(EventProvider), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventProvider), Member = "SetInputSystemProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventProviderImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Application), Member = "remove_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void Shutdown() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "InitInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventProvider), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void Subscribe(EventConsumer handler, int priority = 0, Nullable<Int32> playerId = null, Type[] type) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "RemoveInputProcessor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Unsubscribe(EventConsumer handler) { }

}

