namespace UnityEngine.UIElements;

internal class EventCallbackRegistry
{
	public struct DynamicCallbackList
	{
		private TrickleDown m_UseTrickleDown; //Field offset: 0x0
		[NotNull]
		private EventCallbackList m_Callbacks; //Field offset: 0x8
		[CanBeNull]
		private EventCallbackList m_TemporaryCallbacks; //Field offset: 0x10
		[CanBeNull]
		private List<EventCallbackFunctorBase> m_UnregisteredCallbacksDuringInvoke; //Field offset: 0x18
		private int m_IsInvoking; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private void BeginInvoke() { }

		[CalledBy(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public static DynamicCallbackList Create(TrickleDown useTrickleDown) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "ReleaseCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "GetCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		private void EndInvoke() { }

		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[IsReadOnly]
		[NotNull]
		public EventCallbackList GetCallbackListForReading() { }

		[CalledBy(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EventCallbackRegistry), Member = "GetCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
		[CallsUnknownMethods(Count = 1)]
		[NotNull]
		public EventCallbackList GetCallbackListForWriting() { }

		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_TrickleDownCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArrayTypeMismatchException", ReturnType = typeof(void))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public void Invoke(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public bool UnregisterCallback(long eventTypeId, Delegate callback) { }

	}

	private static readonly EventCallbackListPool s_ListPool; //Field offset: 0x0
	internal DynamicCallbackList m_TrickleDownCallbacks; //Field offset: 0x10
	internal DynamicCallbackList m_BubbleUpCallbacks; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static EventCallbackRegistry() { }

	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public EventCallbackRegistry() { }

	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "EndInvoke", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventCallbackListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackList)}, ReturnType = typeof(EventCallbackList))]
	[CallsUnknownMethods(Count = 1)]
	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) { }

	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventCallbackRegistry), Member = "UnregisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", typeof(TrickleDown)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	private DynamicCallbackList GetDynamicCallbackList(TrickleDown useTrickleDown) { }

	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForReading", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackList), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(EventCallbackFunctorBase))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackFunctor`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy)}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`1<TEventType>")]
	[Calls(Type = typeof(EventCallbackList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackFunctorBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[CalledBy(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForReading", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackList), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(EventCallbackFunctorBase))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "GetCallbackListForWriting", ReturnType = typeof(EventCallbackList))]
	[Calls(Type = typeof(EventCallbackFunctor`2), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(InvokePolicy)}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`2<TEventType, TCallbackArgs>")]
	[Calls(Type = typeof(EventCallbackList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCallbackFunctorBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void RegisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.TabView+ViewState", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "EndInvoke", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "GetDynamicCallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(DynamicCallbackList&))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool UnregisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown = 0) { }

}

