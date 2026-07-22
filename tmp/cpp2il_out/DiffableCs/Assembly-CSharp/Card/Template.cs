namespace Card;

public class Template : DraggableFrame, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Template> <>9__94_0; //Field offset: 0x8
		public static Action<Template> <>9__94_1; //Field offset: 0x10
		public static Action<Template> <>9__94_2; //Field offset: 0x18
		public static Action<Template> <>9__94_3; //Field offset: 0x20
		public static Action<Template> <>9__94_4; //Field offset: 0x28
		public static Action<Template> <>9__94_5; //Field offset: 0x30
		public static Action<Template> <>9__94_6; //Field offset: 0x38
		public static Action<Template> <>9__94_7; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_0(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_1(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_2(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_3(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_4(Template t) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void <RefreshAllCards>b__94_5(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_6(Template t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RefreshAllCards>b__94_7(Template t) { }

	}

	[CompilerGenerated]
	private struct <Create>d__130 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientCard cardData; //Field offset: 0x20
		private TaskAwaiter<Template> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DefineArt>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Template <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const bool FLIP_OP_CARD = False; //Field offset: 0x0
	private static readonly Vector3 FUA_ROT; //Field offset: 0x0
	private const byte MAX_CHAIN_ORDERS = 1; //Field offset: 0x0
	private static readonly Vector3 FDA_ROT; //Field offset: 0xC
	private static readonly Vector3 FDD_ROT; //Field offset: 0x18
	private static readonly Vector3 FUD_ROT; //Field offset: 0x24
	private static readonly Dictionary<CardLinkMarker, ValueTuple`2<Vector2, Vector2>> ArrowsPositions; //Field offset: 0x30
	public static CardLayout _cardLayout; //Field offset: 0x38
	public static CardLayout _readableCardLayout; //Field offset: 0x3C
	private static readonly Vector3 INVERT_SCALE; //Field offset: 0x40
	private static readonly Vector2 TargetingFull; //Field offset: 0x4C
	private static readonly Vector2 TargetingHalf; //Field offset: 0x54
	private static Vector2 CHAIN_ORDER_INVERT; //Field offset: 0x5C
	private static Vector2 CHAIN_ORDER; //Field offset: 0x64
	public static Template CurrentHovering; //Field offset: 0x70
	private static Template _selectedCard; //Field offset: 0x78
	private static Template _lastHighlighted; //Field offset: 0x80
	public static float FontSize; //Field offset: 0x88
	public static object CardPrefab; //Field offset: 0x90
	private static readonly String[] FONT_SHADER_NAMES; //Field offset: 0x98
	private static Template _lasTap; //Field offset: 0xA0
	public static bool RefreshDisplayOnHover; //Field offset: 0xA8
	public Image Cover; //Field offset: 0x98
	public Image Border; //Field offset: 0xA0
	public Image Art; //Field offset: 0xA8
	public Image LegendMark; //Field offset: 0xB0
	public Image SpeedSpellMark; //Field offset: 0xB8
	public Image Frame; //Field offset: 0xC0
	public Image Attribute; //Field offset: 0xC8
	public Image Limitation; //Field offset: 0xD0
	public Image Errataed; //Field offset: 0xD8
	public Image OT; //Field offset: 0xE0
	public Image Targeting; //Field offset: 0xE8
	public Image TargetingFade; //Field offset: 0xF0
	public Image ChainOrder; //Field offset: 0xF8
	public HorizontalLayoutGroup MultiChainLayout; //Field offset: 0x100
	public ParticleSystem ChainPS; //Field offset: 0x108
	public Image[] FadeChainOrders; //Field offset: 0x110
	public Image RushStar; //Field offset: 0x118
	public Image RushStatusLabel; //Field offset: 0x120
	public Image RushMAXLabel; //Field offset: 0x128
	public Image RushDuelLogo; //Field offset: 0x130
	public Image PendulumBottom; //Field offset: 0x138
	public TextMeshProUGUI RushATK; //Field offset: 0x140
	public TextMeshProUGUI RushDEF; //Field offset: 0x148
	public TextMeshProUGUI RushLevel; //Field offset: 0x150
	public TextMeshProUGUI RushMAX; //Field offset: 0x158
	public TextMeshProUGUI[] ChainValues; //Field offset: 0x160
	public Image LocationImage; //Field offset: 0x168
	public TextMeshProUGUI Copyright; //Field offset: 0x170
	public TextMeshProUGUI CardNumber; //Field offset: 0x178
	public Dictionary<CardLinkMarker, Image> Arrows; //Field offset: 0x180
	public Dictionary<CardLinkMarker, Image> RushArrows; //Field offset: 0x188
	public ExtendedText Name; //Field offset: 0x190
	public TextMeshProUGUI StarLabel; //Field offset: 0x198
	public TextMeshProUGUI MonsterType; //Field offset: 0x1A0
	public ScrollRect CardDescription; //Field offset: 0x1A8
	public TextMeshProUGUI CardDescriptionText; //Field offset: 0x1B0
	public ScrollRect PendulumDescription; //Field offset: 0x1B8
	public TextMeshProUGUI PendulumDescriptionText; //Field offset: 0x1C0
	public TextMeshProUGUI PowerLabel; //Field offset: 0x1C8
	public TextMeshProUGUI LinkLevel; //Field offset: 0x1D0
	public GameObject ArrowsContainer; //Field offset: 0x1D8
	public GameObject RushArrowsContainer; //Field offset: 0x1E0
	public TextMeshProUGUI ScaleLeftBlue; //Field offset: 0x1E8
	public TextMeshProUGUI ScaleRightRed; //Field offset: 0x1F0
	[CompilerGenerated]
	private ClientCard <CardData>k__BackingField; //Field offset: 0x1F8
	public GraphicRaycaster Raycaster; //Field offset: 0x200
	public Canvas DrawCanvas; //Field offset: 0x208
	public Canvas StatsCanvas; //Field offset: 0x210
	public Image HandLevelImage; //Field offset: 0x218
	public TextMeshProUGUI HandLevelValue; //Field offset: 0x220
	public bool CantShowOptions; //Field offset: 0x228
	[CompilerGenerated]
	private Rarity <CurrentRarity>k__BackingField; //Field offset: 0x22C
	[CompilerGenerated]
	private SleeveRarity <CurrentCoverRarity>k__BackingField; //Field offset: 0x230
	public CopyableCardText CCT; //Field offset: 0x238
	private Player powner; //Field offset: 0x240
	public bool IsReadableCard; //Field offset: 0x248
	[SerializeField]
	public bool IsPermanent; //Field offset: 0x249
	public Action OnSelect; //Field offset: 0x250
	[CompilerGenerated]
	private FieldSlot <CurrentZone>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private bool <DisplayFlip>k__BackingField; //Field offset: 0x260
	public CardPosition CurrentDisplayPosition; //Field offset: 0x264
	private readonly SemaphoreSlim ArtSem; //Field offset: 0x268
	public byte ActiveChainOrders; //Field offset: 0x270
	public List<ValueTuple`3<Boolean, Int32, Boolean>> CurrentChainOrders; //Field offset: 0x278
	public bool InstantFlip; //Field offset: 0x280
	public bool HoverFlip; //Field offset: 0x281
	public bool SortingIncreased; //Field offset: 0x282
	public int OldSorting; //Field offset: 0x284
	public bool HasCCT; //Field offset: 0x288

	public ClientCard CardData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public CardLayout CardLayout
	{
		[CalledBy(Type = typeof(<DefineArt>d__151), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "get_UseClassicLayout", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "get_UseRushLayout", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "get_UseAnimeLayout", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "DefineCardTypes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "CalculateStringsColors", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "SetCardArtAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineAttribute", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineArrows", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "<DefineAttribute>b__155_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		 get { } //Length: 133
	}

	public private SleeveRarity CurrentCoverRarity
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Rarity CurrentRarity
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public FieldSlot CurrentZone
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public bool DisplayFlip
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsCardInverted
	{
		[CalledBy(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 148
	}

	public bool IsDisplayingFace
	{
		[CalledBy(Type = typeof(ClientCard), Member = "UpdateTemplateLevelInHand", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 349
	}

	public bool IsDuelDisplayCard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 239
	}

	public bool IsFacingCamera
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
		 get { } //Length: 173
	}

	public bool IsInvalid
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OrganizeCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_7", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapZoomCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass88_0", Member = "<AnimateDeckTop>b__0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "set_ShowLevelInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_IsInOppHand", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 55
	}

	public bool IsInWorldSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 140
	}

	private bool IsTranslated
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 131
	}

	public Player PlayerOwner
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(ArtDisplay), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SelectCardPosition), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.DisplayCard+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DragClone), Member = "MakeClone", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.CardPool+<RequestNewCard>d__12", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public static Template SelectedCard
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot+<OnEventTrigger>d__128", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ChatWindow), Member = "OnCardTextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RunEffectMethod", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 14)]
		 set { } //Length: 1688
	}

	public string TargetingIcon
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
		[CalledBy(Type = typeof(HandCards), Member = "ClearAllTargeting", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "DefineTargetIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "IsOpponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 432
	}

	public bool UseAnimeLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	public bool UseClassicLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 21
	}

	public bool UseRushLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private static Template() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Template() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private void <DefineAttribute>b__155_0(Sprite s, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <DefineOTLimit>b__138_0(Sprite s, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <DefineOTLimit>b__138_1(Sprite s, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <RefreshGenesys>b__139_0(Sprite s, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__181_0() { }

	[CalledBy(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.ValueTuple`3<System.Boolean, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void ActivateChainOrder(bool active, int order, bool forceStatic, int orgOrder, bool isTribute, bool isExtraTribute) { }

	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string AttributeDefinition(Card data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void BuildCardData(ClientCard reference) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void BuildCardData(int initialId) { }

	[CalledBy(Type = typeof(OptionBox), Member = "SetupCardPrompt", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void BuildCardData(Template reference) { }

	[CalledBy(Type = typeof(Template), Member = "BuildCardText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "GetAllRaces", ReturnType = typeof(System.Collections.Generic.List`1<Enumerator.CardRace>))]
	[Calls(Type = typeof(ClientCard), Member = "get_HasAllRaces", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "GetTMProSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "GetAllAttributes", ReturnType = typeof(System.Collections.Generic.List`1<Enumerator.CardAttribute>))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 10)]
	public string BuildCardDescription() { }

	[CalledBy(Type = typeof(DisplayCard), Member = "SetupBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 23)]
	public string BuildCardText(bool empty) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnCardTextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Template), Member = "BuildCardText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "GetParsedDefense", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "GetParsedAttack", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "StarText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "GetSetCodesData", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "get_DateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "get_HighlightedName", ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 36)]
	public string BuildPlainEntireCardText() { }

	[CalledBy(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	private void CalculateStringsColors() { }

	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DisplayCard), Member = "UpdateCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "RefreshDisplayPic", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArtDisplay), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshTrunkDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshDeckCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template[]), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "<InsertCard>g__DoCardChange|414_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(<>c__DisplayClass414_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Template)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ChangeCardID(int cardId, bool clone = false) { }

	[CalledBy(Type = "Scenes.General.HandCards+<DestroyHand>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<DestroySlotCards>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "ClearTargeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClientCard), Member = "get_HasCopyCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearAllChainOrders() { }

	[AsyncStateMachine(typeof(<Create>d__130))]
	[CalledBy(Type = "Card.ClientCard+<Create>d__261", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__130)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__130&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task Create(ClientCard cardData) { }

	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SwapChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ClearAllChainOrders", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DeactiveChainOrder() { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector2, UnityEngine.Vector2>))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasLinkMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLinkMarker)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLinkMarkerName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLinkMarker)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public void DefineArrows() { }

	[AsyncStateMachine(typeof(<DefineArt>d__151))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineArt>d__151)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineArt>d__151&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DefineArt() { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasOneType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineAttribute() { }

	[CalledBy(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineBorder(string border = "") { }

	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Template), Member = "CalculateStringsColors", ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "get_IsLanguageUsingRTL", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Localization), Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void DefineCardStrings() { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(TMP_Text), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void DefineCardTypes() { }

	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ActivateChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DefineChainAngle() { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleDeck>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleExtra>d__117", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleHand>d__116", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_PlayerOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Player), Member = "get_CanDisplayInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "SetImageSpriteAndEnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void DefineCover() { }

	[CalledBy(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "DisplayPreview", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnFlipDisplayCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "ResetCoverRarity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "SetDisplayRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(User), Member = "HasSleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DefineCoverRarity(SleeveRarity rar = 0) { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(General), Member = "GetAssetSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineFrame() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	public static void DefineLayouts(CardLayout normal, CardLayout read) { }

	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Banlist), Member = "get_IsDLBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsBeta", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Template), Member = "RefreshGenesys", ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsIllegal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsScriptless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushLegend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsRushBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "get_IsTCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Card), Member = "get_IsDLExclusive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void DefineOTLimit() { }

	[CalledBy(Type = typeof(Template), Member = "SetCardArtAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(General), Member = "GetAssetSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void DefinePendulumBottom() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "SetupCards", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "MakeClone", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsInvalidInstructions]
	public void DefinePermanent(bool state) { }

	[CalledBy(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "SetDisplayRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "ResetRarity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnFlipDisplayCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "DisplayPreview", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Template), Member = "CalculateStringsColors", ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Template), Member = "DefineBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Deck), Member = "RarityCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Template), Member = "DefineCoverRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void DefineRarity(Rarity rar = 0) { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "GetAssetSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ChangeOutline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(Color32), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TMP_Text), Member = "get_alignment", ReturnType = typeof(TextAlignmentOptions))]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "GetTMProSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetSpellTrapTypeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasOneCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public void DefineStars() { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "set_overflowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextOverflowModes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Card), Member = "HasOneType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_characterSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "GetAssetSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetPowerString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 7)]
	public void DefineStatus() { }

	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_TargetingIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineTargetIcon(string icon) { }

	[CalledBy(Type = typeof(Template), Member = "SetTargetingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineTargetIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SwapChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ClearAllChainOrders", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineTargetingSize() { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DisplayLocation() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnClickXyzMaterialList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "HasXyzMaterial", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayOverlays() { }

	[CalledBy(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOLocalRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FlipCard(CardPosition position = 1) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ClientCard get_CardData() { }

	[CalledBy(Type = typeof(<DefineArt>d__151), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "get_UseClassicLayout", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "get_UseRushLayout", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "get_UseAnimeLayout", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardTypes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "CalculateStringsColors", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SetCardArtAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineAttribute", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineArrows", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "<DefineAttribute>b__155_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	public CardLayout get_CardLayout() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public SleeveRarity get_CurrentCoverRarity() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Rarity get_CurrentRarity() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public FieldSlot get_CurrentZone() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_DisplayFlip() { }

	[CalledBy(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCardInverted() { }

	[CalledBy(Type = typeof(ClientCard), Member = "UpdateTemplateLevelInHand", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsDisplayingFace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsDuelDisplayCard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
	public bool get_IsFacingCamera() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OrganizeCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_7", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapZoomCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass88_0", Member = "<AnimateDeckTop>b__0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "set_ShowLevelInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_IsInOppHand", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[ContainsUnimplementedInstructions]
	public bool get_IsInvalid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsInWorldSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_IsTranslated() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Player get_PlayerOwner() { }

	[CallerCount(Count = 0)]
	public static Template get_SelectedCard() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_TargetingIcon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[ContainsUnimplementedInstructions]
	public bool get_UseAnimeLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[ContainsUnimplementedInstructions]
	public bool get_UseClassicLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[ContainsUnimplementedInstructions]
	public bool get_UseRushLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "get_IsLanguageUsingRTL", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Localization), Member = "DefineRTLText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void HandleRTL() { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void HideLocation() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "ManualTargetSelf", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ManualMarkTap() { }

	[CalledBy(Type = typeof(Template), Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnHalfClick(bool hover, PointerEventData eventData, bool activate) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DraggableFrame), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CalledBy(Type = "Scenes.Battle.FieldSlot+<OnEventTrigger>d__128", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DraggableFrame), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardOptionList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(System.Action`1<Scenes.Battle.CardOptionList+ReasonOptionFinish>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "OnHalfClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(PointerEventData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "ManualTargetSelf", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void OnTapping(PointerEventData eventData) { }

	[CalledBy(Type = "Data.CustomTheme+<PostThemeSelectionOperations>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static void RefreshAllCards() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "CameraBootstrap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BanlistManager), Member = "set_CurrentBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<CardLocaleInit>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnNewTurn>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "SetCanDisplayInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineLayouts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLayout), typeof(CardLayout)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetLayouts", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[ContainsInvalidInstructions]
	public static void RefreshAllCards(RefreshCardTemplateAction type = 0, bool activeOnly = true) { }

	[CalledBy(Type = typeof(HandCards), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "FlipCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<RefreshAllCards>b__94_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArtDisplay), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "MakeClone", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "SetFaceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineCardTypes", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineArrows", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineArt>d__151)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineArt>d__151&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(Template), Member = "get_IsDisplayingFace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Template), Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineAttribute", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RefreshCard() { }

	[CalledBy(Type = typeof(Template), Member = "DefineOTLimit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Banlist), Member = "GetGenesysCost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void RefreshGenesys() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<PostLoading>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	public static void ResetLayouts() { }

	[CalledBy(Type = "Card.CardPool+<RequestNewCard>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DragClone), Member = "EndLife", ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "IsOpponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineTargetIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_HasCopyCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "ClearTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ClientCard), Member = "UpdateTemplateLevelInHand", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public void ResetState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CardData(ClientCard value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentCoverRarity(SleeveRarity value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_CurrentRarity(Rarity value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_CurrentZone(FieldSlot value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_DisplayFlip(bool value) { }

	[CalledBy(Type = typeof(ArtDisplay), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectCardPosition), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DisplayCard+<Create>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "MakeClone", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.CardPool+<RequestNewCard>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_PlayerOwner(Player value) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnLogMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short), typeof(ClientCard[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot+<OnEventTrigger>d__128", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "RunEffectMethod", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChatWindow), Member = "OnCardTextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static void set_SelectedCard(Template value) { }

	[CalledBy(Type = typeof(HandCards), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DefineTargetIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Duel), Member = "IsOpponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_TargetingIcon(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_CardLayout", ReturnType = typeof(CardLayout))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefinePendulumBottom", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetCardArtAsync(Sprite newTex, object callBack) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ClearAllChainOrders", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "SwapChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<OverlayAdded>d__285", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<CopyCard>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleHand>d__116", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainSolving>d__102", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_1", Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_0", Member = "<OnSelectSum>g__clear|1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_1", Member = "<OnSelectCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass143_1", Member = "<OnCardSorting>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass143_0", Member = "<OnCardSorting>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Template), Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_HasCopyCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "ActivateChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetChainOrder(bool active, int order = -1, bool forceStatic = false) { }

	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "SelfActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetFaceState(bool enabled) { }

	[CalledBy(Type = typeof(Template), Member = "SetTargetingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "set_TargetingIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineTargetIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Template), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetTargetingScale() { }

	[CalledBy(Type = "Scenes.Battle.ArtDisplay+<ProcessEvent>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<OverlayAdded>d__285", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Template), Member = "SetTargetingScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetTargetingState(bool enabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "UpdateMarkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(DeckType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_HasCopyCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineTargetingSize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SwapChainOrder(bool active, int order = -1, bool forceStatic = false) { }

	[CalledBy(Type = typeof(HandCards), Member = "PostAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HandCards), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(General), Member = "GetRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateChainValuePosition(bool bottom) { }

	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass143_1", Member = "<OnCardSorting>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_1", Member = "<OnSelectCard>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_1", Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.ValueTuple`3<System.Boolean, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateLastChainOrder(int order) { }

	[CalledBy(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Template), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnFlipDisplayCard", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AnimateDeckTop>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardListDisplay), Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "DisplayPreview", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ClientCard), Member = "IsInDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "HasPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "FlipCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePosition(CardPosition position = 0) { }

	[CalledBy(Type = "Scenes.General.HandCards+<OnShuffle>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HandCards), Member = "PostAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HandCards), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HoverZoom), Member = "SetZoomState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateStatsCanvasOrdering(int order = 3) { }

}

