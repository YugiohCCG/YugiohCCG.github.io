namespace Extensions;

public class RoomReadyButton : AudibleObject, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Button Self; //Field offset: 0x28
	public TextMeshProUGUI Label; //Field offset: 0x30
	private bool IsHovering; //Field offset: 0x38
	private bool LastReady; //Field offset: 0x39

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RoomReadyButton() { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnPlayerStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomReadyButton), Member = "DefineReadyFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomReadyButton), Member = "DefineReadyString", ReturnType = typeof(void))]
	public void ChangeReady(bool ready) { }

	[CalledBy(Type = typeof(RoomReadyButton), Member = "ChangeReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomReadyButton), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DefineReadyFrame() { }

	[CalledBy(Type = typeof(RoomReadyButton), Member = "ChangeReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomReadyButton), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DefineReadyString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RoomReadyButton), Member = "DefineReadyFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(RoomReadyButton), Member = "DefineReadyString", ReturnType = typeof(void))]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AudibleObject), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "get_image", ReturnType = typeof(Image))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerExit(PointerEventData eventData) { }

}

