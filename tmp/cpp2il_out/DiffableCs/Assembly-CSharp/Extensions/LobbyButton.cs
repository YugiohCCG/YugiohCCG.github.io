namespace Extensions;

public class LobbyButton : IconButton, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public bool IsUnique; //Field offset: 0x40
	public Button[] GroupButtons; //Field offset: 0x48
	private bool IsActive; //Field offset: 0x50

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LobbyButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyButton), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IconButton), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IconButton), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CalledBy(Type = typeof(LobbyButton), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IconButton), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerExit(PointerEventData eventData) { }

}

