namespace UnityEngine.UIElements;

internal static class MouseEventsHelper
{

	[CalledBy(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent), typeof(Vector2)}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	internal static void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	[CalledBy(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent), typeof(Vector2)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

