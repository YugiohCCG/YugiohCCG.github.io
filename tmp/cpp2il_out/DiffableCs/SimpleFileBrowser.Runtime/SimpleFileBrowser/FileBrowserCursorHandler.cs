namespace SimpleFileBrowser;

public class FileBrowserCursorHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IBeginDragHandler, IEndDragHandler
{
	[SerializeField]
	private Texture2D resizeCursor; //Field offset: 0x20
	private bool isHovering; //Field offset: 0x28
	private bool isResizing; //Field offset: 0x29

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FileBrowserCursorHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	private void ShowDefaultCursor() { }

	[CalledBy(Type = typeof(FileBrowserCursorHandler), Member = "UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserCursorHandler), Member = "UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ShowResizeCursor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowserCursorHandler), Member = "ShowResizeCursor", ReturnType = typeof(void))]
	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowserCursorHandler), Member = "ShowResizeCursor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

