namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerPanel : MonoBehaviour
{
	public Text nameLabel; //Field offset: 0x20
	public ScrollRect scrollRect; //Field offset: 0x28
	public RectTransform viewport; //Field offset: 0x30
	public DebugUIHandlerCanvas Canvas; //Field offset: 0x38
	private RectTransform m_ScrollTransform; //Field offset: 0x40
	private RectTransform m_ContentTransform; //Field offset: 0x48
	private RectTransform m_MaskTransform; //Field offset: 0x50
	private DebugUIHandlerWidget m_ScrollTarget; //Field offset: 0x58
	protected private Panel m_Panel; //Field offset: 0x60

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerPanel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerContainer), Member = "GetFirstItem", ReturnType = typeof(DebugUIHandlerWidget))]
	[CallsUnknownMethods(Count = 1)]
	internal DebugUIHandlerWidget GetFirstItem() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal Panel GetPanel() { }

	[CalledBy(Type = typeof(DebugUIHandlerPanel), Member = "UpdateScroll", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetYPosInScroll(RectTransform target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Mask), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "SetScrollTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnScrollbarClicked() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "Reset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ResetDebugManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerCanvas), Member = "ActivatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectNextItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerCanvas), Member = "SelectPreviousPanel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SelectPreviousItem() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetPanel(Panel panel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetScrollTarget(DebugUIHandlerWidget target) { }

	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DebugUIHandlerPanel), Member = "GetYPosInScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollRect), Member = "set_verticalNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateScroll() { }

}

