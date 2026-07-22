namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor
{

	public static CursorLockMode lockState
	{
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", "UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", "UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static CursorLockMode get_lockState() { }

	[CalledBy(Type = "Manager.Helper+<LoadPointer>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CursorManager", Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Cursor"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CursorManager", Member = "ResetCursor", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "UnityEngine.EventSystems.IEndDragHandler.OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "ShowDefaultCursor", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "ShowResizeCursor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetCursor_Injected(IntPtr texture, in Vector2 hotspot, CursorMode cursorMode) { }

}

