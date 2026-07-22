namespace Extensions;

public class CopyableCardText : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private Template CardTemplate; //Field offset: 0x20
	private BoxCollider2D NameBox; //Field offset: 0x28
	private BoxCollider2D PendDescBox; //Field offset: 0x30
	private BoxCollider2D DescBox; //Field offset: 0x38
	private BoxCollider2D CardCodeBox; //Field offset: 0x40

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CopyableCardText() { }

	[CalledBy(Type = typeof(CopyableCardText), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collider2D), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Bounds), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string HoveringBox(Vector2 pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CopyableCardText), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsUnknownMethods(Count = 8)]
	private void Start() { }

}

