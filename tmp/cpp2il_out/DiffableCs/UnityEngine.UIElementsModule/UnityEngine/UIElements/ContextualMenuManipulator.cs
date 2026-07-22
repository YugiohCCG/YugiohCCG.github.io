namespace UnityEngine.UIElements;

public class ContextualMenuManipulator : PointerManipulator
{
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder; //Field offset: 0x28

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerManipulator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) { }

	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerDownEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerUpEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyUpEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void DoDisplayMenu(EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	protected bool IsOSXContextualMenuPlatform() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerDownEventOSX(IPointerEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerDown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerMoveEventOSX(PointerMoveEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnPointerUpEvent(IPointerEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerUpEventOSX(IPointerEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void ProcessPointerEvent(IPointerEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void RegisterCallbacksOnTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

