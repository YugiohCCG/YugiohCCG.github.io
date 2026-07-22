namespace Scenes.Battle;

public class FieldSlot : InteractableObject, IPointerEnterHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass106_0
	{
		public Template card; //Field offset: 0x10
		public FieldSlot <>4__this; //Field offset: 0x18
		public TweenerCore<Vector3, Vector3, VectorOptions> scaleTween; //Field offset: 0x20
		public Template lastCard; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass106_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <AddCard>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <AddCard>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public float timer; //Field offset: 0x10
		public FieldSlot <>4__this; //Field offset: 0x18
		public TweenCallback <>9__3; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass112_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnShuffle>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_1
	{
		public Template t; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18
		public <>c__DisplayClass112_0 CS$<>8__locals1; //Field offset: 0x28
		public TweenCallback <>9__2; //Field offset: 0x30
		public TweenCallback <>9__1; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass112_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void <OnShuffle>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void <OnShuffle>b__1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void <OnShuffle>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public FieldSlot <>4__this; //Field offset: 0x10
		public string value; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass71_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <set_SlotFrame>b__0(Sprite b, object o) { }

	}

	[CompilerGenerated]
	private struct <DestroySlotCards>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FieldSlot <>4__this; //Field offset: 0x20
		private Enumerator<Template> <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "ClearAllChainOrders", ReturnType = typeof(void))]
		[Calls(Type = typeof(CardPool), Member = "DisableCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnEventTrigger>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EventTriggerType ev; //Field offset: 0x28
		public FieldSlot <>4__this; //Field offset: 0x30
		public PointerEventData data; //Field offset: 0x38
		private TaskAwaiter<LineArc> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "OnClickFinish", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "SendAttack", ReturnType = typeof(void))]
		[Calls(Type = typeof(LineArc), Member = "ClearBattleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.LineArc+<Create>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(LineArc), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(LineArc), Member = "SetBattleState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "set_SelectedCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CardOptionList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "set_SlotFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 40)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const bool UsePlayableSize = True; //Field offset: 0x0
	private static readonly Vector3 UnplayableSize; //Field offset: 0x0
	public const float ZoneScaling = 1.15; //Field offset: 0x0
	private static readonly Vector3 PlayableSize; //Field offset: 0xC
	public static FieldSlot SelectedZone; //Field offset: 0x18
	public static FieldSlot HoveringZone; //Field offset: 0x20
	public static ClientCard SelectedCard; //Field offset: 0x28
	private static readonly Vector2 PWR_OFFSET_BOT; //Field offset: 0x30
	private static readonly Vector2 PWR_OFFSET_TOP; //Field offset: 0x38
	private static readonly Color GreenColor; //Field offset: 0x40
	private static readonly Color RedColor; //Field offset: 0x50
	private static readonly Color YellowColor; //Field offset: 0x60
	public static bool DisplayStatus; //Field offset: 0x70
	private static readonly Vector3 INVERTED_CARD; //Field offset: 0x74
	public Canvas MainCanvas; //Field offset: 0x70
	public Image ZoneSlot; //Field offset: 0x78
	public Transform CardHolder; //Field offset: 0x80
	public Canvas SlotData; //Field offset: 0x88
	public Image ZoneButton; //Field offset: 0x90
	public Hologram Closeup; //Field offset: 0x98
	[Header("Base Objects")]
	public Image Background; //Field offset: 0xA0
	public Image Power; //Field offset: 0xA8
	public Image Level; //Field offset: 0xB0
	public Image Scale; //Field offset: 0xB8
	public Image Race; //Field offset: 0xC0
	public Image Attribute; //Field offset: 0xC8
	public Transform Counters; //Field offset: 0xD0
	public Image CardCount; //Field offset: 0xD8
	public TextMeshProUGUI CardCountValue; //Field offset: 0xE0
	[Header("Power Objects")]
	public Image ATKSword; //Field offset: 0xE8
	public Image DEFShield; //Field offset: 0xF0
	public TextMeshProUGUI ATKValue; //Field offset: 0xF8
	public TextMeshProUGUI DEFValue; //Field offset: 0x100
	[Header("Level Objects")]
	public TextMeshProUGUI LevelValue; //Field offset: 0x108
	[Header("Counter Objects")]
	public Image[] Counter; //Field offset: 0x110
	public TextMeshProUGUI[] CounterValue; //Field offset: 0x118
	public int SlotCode; //Field offset: 0x120
	[CompilerGenerated]
	private byte <Controller>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private CardLocation <Location>k__BackingField; //Field offset: 0x128
	public byte Sequence; //Field offset: 0x12C
	public FieldSide Side; //Field offset: 0x130
	public List<Template> Cards; //Field offset: 0x138
	public bool IsInCenter; //Field offset: 0x140
	private bool hologramOverride; //Field offset: 0x141
	private string LBGIcon; //Field offset: 0x148
	private string FSpriteName; //Field offset: 0x150
	public bool InverterLock; //Field offset: 0x158
	private CardAttribute LAST_AT; //Field offset: 0x15C
	private CardRace LAST_RC; //Field offset: 0x160
	public bool IsShuffling; //Field offset: 0x164

	public byte AmountOfCards
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapBanish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hotkey), Member = "TapExtraDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>b__6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_2", Member = "<ManualSelectPlace>b__10", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass79_0+<<OnSwapGraveDeck>g__doSwap|0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnConfirmTop>d__87", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	public string BackgroundIcon
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 181
		[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "InitializeFieldZones", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSide), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "Restart", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 693
	}

	private Vector3 CardScale
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 99
	}

	public byte Controller
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Template CurrentCard
	{
		[CalledBy(Type = "Scenes.General.Hologram+<DefineHologram>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "get_IsDisplayingFace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_GPS", ReturnType = typeof(int))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__8", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>b__6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "get_DisplayHologram", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hologram), Member = "<DefineHologram>b__16_0", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		 get { } //Length: 61
	}

	public bool DisplayHologram
	{
		[CalledBy(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 415
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool IsCardInverted
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsCenterOppCard", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 498
	}

	public bool IsCenterOppCard
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 238
	}

	public bool IsExtra
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 416
	}

	public bool IsFieldSpellZone
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsFieldSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte)}, ReturnType = typeof(bool))]
		 get { } //Length: 21
	}

	public bool IsLeftSide
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	public bool IsMain
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 416
	}

	public bool IsMainOrExtra
	{
		[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__45", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_7", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 811
	}

	public bool IsMyExtraDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 210
	}

	public bool IsMyMainDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 210
	}

	public bool IsOppExtraDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 210
	}

	public bool IsOppMainDeck
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "get_IsOppMainDeck", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 210
	}

	public bool IsOpponent
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsRightSide
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	public bool IsUnplayable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
		 get { } //Length: 13
	}

	public CardLocation Location
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	private bool SHOW_AT
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "get_SHOW_AT_RC", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_AttributeChanged", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 226
	}

	private bool SHOW_AT_RC
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_AT", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_RC", ReturnType = typeof(bool))]
		private get { } //Length: 43
	}

	private bool SHOW_RC
	{
		[CalledBy(Type = typeof(FieldSlot), Member = "get_SHOW_AT_RC", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_RaceChanged", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 226
	}

	public static bool ShowHologram
	{
		[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		 get { } //Length: 134
	}

	public string SlotFrame
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 41
		[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldCenter), Member = "InitializeFieldZones", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldSlot), Member = "Restart", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 335
	}

	public float ZoneScale
	{
		[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "PlayActivateFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "<OnMove>g__playDestroyFX|133_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "<OnBattle>g__addCrack|136_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	private static FieldSlot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public FieldSlot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "ClearTextures", ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <set_BackgroundIcon>b__68_0(Material b, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "ClearTextures", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CompilerGenerated]
	private void <set_BackgroundIcon>b__68_1(Sprite b, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_0(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_1(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_2(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_3(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_4(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_5(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "OnEventTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventTriggerType), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <Start>b__76_6(PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__76_7() { }

	[CalledBy(Type = "Card.ClientCard+<OverlayAdded>d__285", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "OnUpdatedMonsterZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "OnUpdatedSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "SlotUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<OnOverlayChanged>d__287", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "SetFieldBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSide), typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "IsFieldSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "set_Location", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardListDisplay), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsFromSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "ClearTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DORotateQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Quaternion), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>))]
	[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(CardListDisplay), Member = "UpdateOldCardSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(sbyte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	public void AddCard(Template card, int index = -1) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Template), Member = "UpdateChainValuePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(FieldSlot), Member = "SetLvPwrBot", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsCenterOppCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsLeftSide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsRightSide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_RC", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_AT", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void CheckZoneInverter() { }

	[CalledBy(Type = typeof(DuelZone), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_TargetingIcon", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "set_TargetingIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ClearAllTargeting() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "<set_BackgroundIcon>b__68_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<set_BackgroundIcon>b__68_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ClearTextures() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DefineLabelColor(TextMeshProUGUI label, int org, int cur) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "UpdateStatsCanvasOrdering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "IsTweening", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DefineLayers(bool positions) { }

	[AsyncStateMachine(typeof(<DestroySlotCards>d__108))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<ClearAllCards>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnTagSwap>d__125", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DestroySlotCards>d__108)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DestroySlotCards>d__108&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task DestroySlotCards() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(ClientCard), Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void DisplaySlotInfo(bool refresh = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteractableObject), Member = "FixedUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapGraveyard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapBanish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkey), Member = "TapExtraDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>b__6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_2", Member = "<ManualSelectPlace>b__10", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass79_0+<<OnSwapGraveDeck>g__doSwap|0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnConfirmTop>d__87", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 1)]
	public byte get_AmountOfCards() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_BackgroundIcon() { }

	[CallerCount(Count = 0)]
	private Vector3 get_CardScale() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_Controller() { }

	[CalledBy(Type = "Scenes.General.Hologram+<DefineHologram>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "OnTapSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hologram), Member = "<DefineHologram>b__16_0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "get_DisplayHologram", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__8", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_GPS", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "get_IsDisplayingFace", ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>b__6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	public Template get_CurrentCard() { }

	[CalledBy(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_DisplayHologram() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_IsCenterOppCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCardInverted() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCenterOppCard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsExtra() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "IsFieldSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte)}, ReturnType = typeof(bool))]
	public bool get_IsFieldSpellZone() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsLeftSide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMain() { }

	[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardOptionList+<Create>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMainOrExtra", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ShouldAppear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_7", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMainOrExtra() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMyExtraDeck", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMyExtraDeck() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_IsMyMainDeck", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsMyMainDeck() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_IsOppExtraDeck", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsOppExtraDeck() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "get_IsOppMainDeck", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardOptionList), Member = "ManualModeInit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsOppMainDeck() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsOpponent() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsRightSide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	public bool get_IsUnplayable() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CardLocation get_Location() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "get_SHOW_AT_RC", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_AttributeChanged", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_SHOW_AT() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_AT", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_RC", ReturnType = typeof(bool))]
	private bool get_SHOW_AT_RC() { }

	[CalledBy(Type = typeof(FieldSlot), Member = "get_SHOW_AT_RC", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_RaceChanged", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_SHOW_RC() { }

	[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	public static bool get_ShowHologram() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_SlotFrame() { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PlayActivateFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "<OnMove>g__playDestroyFX|133_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "<OnBattle>g__addCrack|136_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public float get_ZoneScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "HasXyzMaterial", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "DisplayOverlays", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickXyzMaterialList(PointerEventData data) { }

	[AsyncStateMachine(typeof(<OnEventTrigger>d__128))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "<Start>b__76_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEventTrigger>d__128)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEventTrigger>d__128&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void OnEventTrigger(EventTriggerType ev, PointerEventData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteractableObject), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CalledBy(Type = "Game.DuelManager+<OnShuffleDeck>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleExtra>d__117", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "ClearTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void OnShuffle() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "SetSlotCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "SetSlotCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnSlotDataSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "ManualMarkTap", ReturnType = typeof(void))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsCopyListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardListDisplay), Member = "IsListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
	[Calls(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "DisplaySlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "IsRightTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(InteractableObject), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InteractableObject), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InteractableObject), Member = "OnClickButton", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnTapSlot(BaseEventData data) { }

	[CalledBy(Type = typeof(FieldSide), Member = "OnUpdatedMonsterZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "OnUpdatedSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "SlotUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NotifyCollectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Duel+<OverlayCard>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard+<OnOverlayChanged>d__287", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "OverlayRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Template), Member = "RefreshCard", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "SetFieldBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSide), typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "IsFieldSpellZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardListDisplay), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public void RemoveCard(Template card) { }

	[CalledBy(Type = typeof(CustomTheme), Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FieldSlot), Member = "set_SlotFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "set_BackgroundIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Restart() { }

	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "InitializeFieldZones", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "Restart", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_BackgroundIcon(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Controller(byte value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_DisplayHologram(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Location(CardLocation value) { }

	[CalledBy(Type = typeof(FieldCenter), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "InitializeFieldZones", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnEventTrigger>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "Restart", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void set_SlotFrame(string value) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetLvPwrBot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(AnchorExtensions), Member = "SetAnchorAndPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(PivotPresets)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetLvPwrTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public void SlotUpdated(object sender, NotifyCollectionChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	private void Start() { }

	[CalledBy(Type = typeof(CameraController), Member = "CameraBootstrap", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Hologram), Member = "CalculateMovementRoute", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateHologramsState() { }

	[CalledBy(Type = typeof(ClientCard), Member = "ClearCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DestroySlotCards>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SetPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "AddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(ClientCard), Member = "RemoveCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_AT", ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "SetY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(FieldSlot), Member = "DefineLabelColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "FadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ClientCard), Member = "IsInDefense", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_FirstAddedAttribute", ReturnType = typeof(CardAttribute))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ClientCard), Member = "get_FirstAddedRace", ReturnType = typeof(CardRace))]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.UInt16>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt16, System.UInt16>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt16, System.UInt16>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "GetCounterImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Image&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "get_SHOW_RC", ReturnType = typeof(bool))]
	[Calls(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ChangeOutline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(Color32), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "HasXyzMaterial", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public void UpdateSlotInfo(bool positions = false) { }

}

