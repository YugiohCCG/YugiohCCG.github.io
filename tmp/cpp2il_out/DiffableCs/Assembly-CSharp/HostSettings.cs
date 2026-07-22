//Type is in global namespace

public class HostSettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Banlist, String> <>9__45_0; //Field offset: 0x8
		public static Func<Banlist, String> <>9__45_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "get_ListableName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <DefineBanlistDropdown>b__45_0(Banlist bl) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "get_ListableName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <DefineBanlistDropdown>b__45_1(Banlist bl) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public HostSettings <>4__this; //Field offset: 0x10
		public int idx; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass40_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SetHostSlotData>b__0(PointerEventData e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public uint banlist; //Field offset: 0x10
		public GameSettings settings; //Field offset: 0x18
		public HostSettings <>4__this; //Field offset: 0x58

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass44_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(Packet), Member = "CreateTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings), typeof(bool), typeof(bool), typeof(bool), typeof(Int64[])}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		internal void <OnCreateRoomButton>b__0(string s) { }

	}

	[Header("Host Tab")]
	public Button CustomPropertiesButton; //Field offset: 0x20
	public Button GamePropertiesButton; //Field offset: 0x28
	public VerticalLayoutGroup GamePropertiesTab; //Field offset: 0x30
	public GameObject CustomPropertiesTab; //Field offset: 0x38
	public TMP_Dropdown Banlist; //Field offset: 0x40
	public TMP_Dropdown DuelMode; //Field offset: 0x48
	public TMP_Dropdown MasterRule; //Field offset: 0x50
	public TMP_Dropdown DuelRule; //Field offset: 0x58
	public Button HostExtraRules; //Field offset: 0x60
	public TMP_InputField LifePoints; //Field offset: 0x68
	public TMP_InputField DrawCount; //Field offset: 0x70
	public TMP_InputField StartHand; //Field offset: 0x78
	public TMP_InputField Timer; //Field offset: 0x80
	public TMP_InputField Budget; //Field offset: 0x88
	public DatePicker ReleasedFrom; //Field offset: 0x90
	public DatePicker ReleasedTo; //Field offset: 0x98
	public Button CreateRoom; //Field offset: 0xA0
	public ToggleGroup CardPoolToggles; //Field offset: 0xA8
	public TextMeshProUGUI CardPoolLabel; //Field offset: 0xB0
	public Toggle TCGPool; //Field offset: 0xB8
	public Toggle OCGPool; //Field offset: 0xC0
	public Toggle WCSPool; //Field offset: 0xC8
	public Toggle AllPool; //Field offset: 0xD0
	public Toggle DLPool; //Field offset: 0xD8
	public Toggle IsPrivateRoom; //Field offset: 0xE0
	public TextMeshProUGUI PresetsLabel; //Field offset: 0xE8
	[Header("Host Slot Buttons")]
	public VerticalLayoutGroup HostPrefs; //Field offset: 0xF0
	public GameObject TournamentPrefs; //Field offset: 0xF8
	public Toggle TournyRewardTP; //Field offset: 0x100
	public Toggle TournyRequirePass; //Field offset: 0x108
	public Toggle SingleElimTouny; //Field offset: 0x110
	private ExtraRules CurrentExtraRules; //Field offset: 0x118
	private bool IsInTournamentDisplay; //Field offset: 0x120

	private bool CanDisplayTourny
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Tournament), Member = "get_HasTournament", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 106
	}

	public bool IsEditingRoom
	{
		[CalledBy(Type = typeof(HostSettings), Member = "UpdateLanguage", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "ShowHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 127
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HostSettings() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void <OnClickHostExtraRules>b__49_0(Enum e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__43_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__43_1() { }

	[CalledBy(Type = typeof(<>c__DisplayClass40_0), Member = "<SetHostSlotData>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameSettings), Member = "GetSettingsForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(GameSettings))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(BanlistManager), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClickOnHostSettingSlot(int slot, PointerEventData e) { }

	[CalledBy(Type = typeof(HostSettings), Member = "ShowHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DefineBanlistDropdown(bool custom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tournament), Member = "get_HasTournament", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_CanDisplayTourny() { }

	[CalledBy(Type = typeof(HostSettings), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ShowHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_IsEditingRoom() { }

	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SaveHostRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&)}, ReturnType = typeof(GameSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(MultiPick), Member = "ValidateExtraRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtraRules&), typeof(DuelRules)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializableDate), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializableDate), Member = "get_Date", ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void GetGameSettings(out GameSettings gs, out uint banlist) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DuelRules GetSelectedDuelRule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void HideCalendars() { }

	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(HostSettings), Member = "SetHostSlotData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void InitHostSlots() { }

	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ShowHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryExtensions), Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BanlistManager), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void LoadHostRoomInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiPick), Member = "ValidateExtraRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtraRules&), typeof(DuelRules)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiPick), Member = "get_EXTRA_RULES_CATEGORIES", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Enum>))]
	[Calls(Type = typeof(MultiPick), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Enum>), typeof(System.Func`2<System.Enum, System.String>), typeof(Enum), typeof(System.Collections.Generic.Dictionary`2<System.Enum, Enum[]>), typeof(Enum[][]), typeof(Enum[]), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Enum>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickHostExtraRules() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsInQueue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HostSettings), Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(UInt32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(BinaryExtensions), Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HostSettings), Member = "get_IsEditingRoom", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "CreateGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tournament), Member = "get_HasTournament", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(string), typeof(bool), typeof(string), typeof(bool), typeof(Action), typeof(bool), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameRoom), Member = "SetupNewRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnCreateRoomButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(Banlist))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ParseFilters(out DuelRules dr, out int lp, out short timer, out byte sh, out byte dc, out byte region, out byte mr, out uint banlist, out DuelMode mode, out int budget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "get_IsLocalConnected", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "get_GameModeNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetSelectors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HostSettings), Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(UInt32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker), Member = "get_Ref_InputField", ReturnType = typeof(TMP_InputField))]
	[Calls(Type = typeof(BinaryExtensions), Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public GameSettings SaveHostRoomInfo(out uint banlist) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetHostRules(GameSettings ri, Banlist bl) { }

	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(Banlist)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DatePicker), Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetHostRules(GameSettings ri, int blIndex, string releasedFrom, string releasedTo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlistForLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Limitation)}, ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BanlistManager), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HostSettings), Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetHostRules(GameSettings ri, string releasedFrom, string releasedTo) { }

	[CalledBy(Type = typeof(HostSettings), Member = "InitHostSlots", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SetHostSlotData(Transform t, string name, int idx) { }

	[CalledBy(Type = typeof(GameRoom), Member = "OnClickEditGame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnHostButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HostSettings), Member = "get_IsEditingRoom", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ToggleGroup), Member = "AnyTogglesOn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HostSettings), Member = "DefineBanlistDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ShowHost(bool isTournament) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HostSettings), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "get_IsLocalConnected", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Localization), Member = "get_GameModeNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HostSettings), Member = "InitHostSlots", ReturnType = typeof(void))]
	[Calls(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void Start() { }

	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetComponentInChildrenOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(HostSettings), Member = "get_IsEditingRoom", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateLanguage() { }

}

