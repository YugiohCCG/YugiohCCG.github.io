namespace UnityEngine.UIElements;

internal static class EventDispatchUtilities
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void DefaultDispatch(EventBase evt, BaseVisualElementPanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool Disabled(EventBase evt, VisualElement target) { }

	[CalledBy(Type = typeof(MouseEnterEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOverEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOutEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEnterEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerLeaveEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerOverEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerOutEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static void DispatchToAssignedTarget(EventBase evt, BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToCapturingElementOrElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void DispatchToCachedElementUnderPointerOrPanelRoot(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static bool DispatchToCapturingElement(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[CalledBy(Type = typeof(MouseEventBase`1), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToCachedElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void DispatchToCapturingElementOrElementUnderPointer(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[CalledBy(Type = typeof(WheelEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEnterWindowEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void DispatchToElementUnderPointerOrPanelRoot(EventBase evt, BaseVisualElementPanel panel, int pointerId, Vector2 position) { }

	[CalledBy(Type = typeof(CommandEventBase`1), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationEventBase`1), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasSelfEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void DispatchToFocusedElementOrPanelRoot(EventBase evt, BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(IMGUIEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void DispatchToPanelRoot(EventBase evt, BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 18)]
	private static void HandleEvent_BubbleUpAllDefaultActions(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled, bool isCapturingTarget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void HandleEvent_BubbleUpCallbacks(EventBase evt, BaseVisualElementPanel panel, VisualElement element) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void HandleEvent_BubbleUpHandleEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private static void HandleEvent_DefaultAction(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private static void HandleEvent_DefaultActionAtTarget(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void HandleEvent_TrickleDownCallbacks(EventBase evt, BaseVisualElementPanel panel, VisualElement element) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void HandleEvent_TrickleDownHandleEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement element, bool disabled) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	private static void HandleEventAcrossPropagationPath(EventBase evt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ShouldSendCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 69)]
	[ContainsUnimplementedInstructions]
	private static void HandleEventAcrossPropagationPathWithCompatibilityEvent(EventBase evt, EventBase compatibilityEvt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DefaultDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "DispatchChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "DispatchMissedHierarchyChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "HasSelfEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "HasTrickleDownHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "HasBubbleUpEventCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	public static void HandleEventAtTargetAndDefaultPhase(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void PropagateEvent(EventBase evt, BaseVisualElementPanel panel, VisualElement target, bool isCapturingTarget) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToCachedElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static void PropagateToRemainingIMGUIContainerRecursive(EventBase evt, VisualElement root) { }

	[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void PropagateToRemainingIMGUIContainers(EventBase evt, VisualElement root) { }

}

