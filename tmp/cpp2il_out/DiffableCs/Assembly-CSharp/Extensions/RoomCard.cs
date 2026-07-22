namespace Extensions;

public class RoomCard : MonoBehaviour, IPooledView
{
	[CompilerGenerated]
	private struct <>c__DisplayClass35_0
	{
		public Image slot; //Field offset: 0x0
		public bool e; //Field offset: 0x8
		public string i; //Field offset: 0x10
		public string a; //Field offset: 0x18

	}

	private static readonly Color Waiting; //Field offset: 0x0
	private static readonly Color Playing; //Field offset: 0x10
	private static readonly Color StripeTCG; //Field offset: 0x20
	private static readonly Color StripeOCG; //Field offset: 0x30
	private static readonly Color StripeWCS; //Field offset: 0x40
	private static readonly Color StripeDL; //Field offset: 0x50
	private static readonly Color StripeUnlimited; //Field offset: 0x60
	private static readonly Color StripeCustom; //Field offset: 0x70
	private static readonly Color OtherColor; //Field offset: 0x80
	public TextMeshProUGUI Ratings; //Field offset: 0x20
	public Button BaseButton; //Field offset: 0x28
	public Image Frame; //Field offset: 0x30
	public Image Borders; //Field offset: 0x38
	public Image Avatar; //Field offset: 0x40
	public Image Custom; //Field offset: 0x48
	public Image BanlistStripe; //Field offset: 0x50
	public TextMeshProUGUI Name; //Field offset: 0x58
	public TextMeshProUGUI Pool; //Field offset: 0x60
	public TextMeshProUGUI MR; //Field offset: 0x68
	public TextMeshProUGUI Rule; //Field offset: 0x70
	public TextMeshProUGUI Banlist; //Field offset: 0x78
	public TextMeshProUGUI PlayerCount; //Field offset: 0x80
	public TextMeshProUGUI DuelType; //Field offset: 0x88
	public HorizontalLayoutGroup DuelsLayout; //Field offset: 0x90
	public Image Selected; //Field offset: 0x98
	public Image[] DuelSlot; //Field offset: 0xA0
	[CompilerGenerated]
	private RoomData <BaseData>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private IPooledData <Data>k__BackingField; //Field offset: 0xB0

	public private RoomData BaseData
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public override IPooledData Data
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	private static RoomCard() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RoomCard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_SafeMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <PostSetData>b__37_0(Texture2D t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static void <SetData>g__checkslots|35_0(Image[] slots, byte count, ref <>c__DisplayClass35_0 unnamed_param_2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "OnRoomSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomCard)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__34_0() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RoomData get_BaseData() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override IPooledData get_Data() { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "get_FilterName", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "FilterStringWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Player), Member = "get_SafeMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DiscordController), Member = "DoGetPlayerAvatarFromWeb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(System.Action`1<UnityEngine.Texture2D>), typeof(ushort)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void PostSetData(long id, string name, string avatar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public void PostSetData(User u) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BaseData(RoomData value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_Data(IPooledData value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetGameModeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelMode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "get_Mode", ReturnType = typeof(DuelMode))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "get_IsMatch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "get_IsCustom", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Localization), Member = "GetRuleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelRules)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Banlist), Member = "get_IsUnlimited", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsCustomBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_RuleString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomData), Member = "GetFormatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "GetPlayerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.Action`1<Discord.User>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public override void SetData(IPooledData data) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnSearchButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnHostButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "<Start>b__94_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

}

