namespace Scenes.Battle;

public class FieldCenter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__35_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
		internal void <OnLeftPhaseButton>b__35_0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public FieldCenter <>4__this; //Field offset: 0x10
		public Image left; //Field offset: 0x18
		public Image right; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass27_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Awake>b__0(PointerEventData e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Awake>b__1(PointerEventData e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Awake>b__2(PointerEventData e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Awake>b__3(PointerEventData e) { }

	}

	public static FieldCenter Instance; //Field offset: 0x0
	private EventTrigger LeftPhaseButton; //Field offset: 0x20
	public TextMeshProUGUI LeftPhaseLabel; //Field offset: 0x28
	public Image LeftPhaseShift; //Field offset: 0x30
	private EventTrigger RightPhaseButton; //Field offset: 0x38
	public TextMeshProUGUI RightPhaseLabel; //Field offset: 0x40
	public Image RightPhaseShift; //Field offset: 0x48
	public Image CurrentPhase; //Field offset: 0x50
	public TextMeshProUGUI PhaseText; //Field offset: 0x58
	public TextMeshProUGUI TurnCount; //Field offset: 0x60
	public FieldSlot LeftLinkSlot; //Field offset: 0x68
	public FieldSlot RightLinkSlot; //Field offset: 0x70
	private Canvas FieldCanvas; //Field offset: 0x78
	private byte HoldingState; //Field offset: 0x80
	private float HoldingTime; //Field offset: 0x84
	public bool HoldingRight; //Field offset: 0x88
	private string LPBSprite; //Field offset: 0x90
	private string RPBSprite; //Field offset: 0x98

	public static GameObject ObjectInstance
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 148
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FieldCenter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "set_SlotFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "set_BackgroundIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "OnSlotDataSet", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTrigger), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	private void Awake() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "OnStartHoldingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldCenter), Member = "CanPhaseShift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMainPhase", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	private bool CanLeftPhaseShift() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "OnTapCurrentPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CanPhaseShift() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "OnStartHoldingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldCenter), Member = "CanPhaseShift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMainPhase", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	private bool CanRightPhaseShift() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearAllTargeting() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "set_BackgroundIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "set_SlotFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeFieldZones() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void LocalRestart() { }

	[CalledBy(Type = typeof(<>c__DisplayClass27_0), Member = "<Awake>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass27_0), Member = "<Awake>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass27_0), Member = "<Awake>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass27_0), Member = "<Awake>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Restart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "LocalRestart", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnHoverPhase(Image img, bool hover, ref string sn) { }

	[CalledBy(Type = "PhaseSelect+<>c__DisplayClass19_0", Member = "<SetListeners>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhaseSelect), Member = "OnPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnStartHoldingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(string), typeof(bool), typeof(string), typeof(bool), typeof(Action), typeof(bool), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	public void OnLeftPhaseButton() { }

	[CalledBy(Type = "PhaseSelect+<>c__DisplayClass19_0", Member = "<SetListeners>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhaseSelect), Member = "OnPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnStartHoldingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void OnRightPhaseButton() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldCenter), Member = "CanLeftPhaseShift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnStartHoldingLeft(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldCenter), Member = "CanRightPhaseShift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnStartHoldingRight(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnStopHolding(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldCenter), Member = "CanPhaseShift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PhaseSelect), Member = "ToggleState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void OnTapCurrentPhase(PointerEventData data) { }

	[CalledBy(Type = typeof(CustomTheme), Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(FieldCenter), Member = "OnHoverPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(bool), typeof(String&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Restart() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "OnSlotDataSet", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetSlotCode(FieldSlot target, int code, byte sequence) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldCenter), Member = "OnRightPhaseButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "UpdatePhase", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PhaseChange), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public void UpdatePhase(DuelPhase phase) { }

	[CalledBy(Type = "Game.DuelManager+<OnNewPhase>d__127", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldCenter), Member = "UpdatePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePhase() { }

	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PhaseChange), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateTurn(ushort turn) { }

}

