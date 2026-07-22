namespace Scenes.Lobby;

public class Shop : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public ushort index; //Field offset: 0x10
		public Shop <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass26_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <UpdateProducts>b__0(PointerEventData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Shop <>4__this; //Field offset: 0x10
		public ShopItemData good; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass36_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shop), Member = "IsPurchasable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Lobby.Shop+ShopItemData"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "BuyGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnBuy>b__0(bool r) { }

	}

	[CompilerGenerated]
	private struct <Create>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private ResourceRequest <rr>5__2; //Field offset: 0x30
		private TaskAwaiter<Shop> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct ShopItemData
	{
		public ushort ID; //Field offset: 0x0
		public string Name; //Field offset: 0x8
		public string Description; //Field offset: 0x10
		public ushort Price; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetDescriptionForGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		public ShopItemData(ushort id, string name, ushort price, string description = "") { }

	}

	private const byte MAX_RARITY = 98; //Field offset: 0x0
	public static UInt16[] StorePrices; //Field offset: 0x0
	private static readonly string COIN; //Field offset: 0x8
	public static object ShopPrefab; //Field offset: 0x10
	public static Shop Instance; //Field offset: 0x18
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x20
	public GridLayoutGroup ShopItemsGrid; //Field offset: 0x20
	public Button LeaveButton; //Field offset: 0x28
	public Button ThemesButton; //Field offset: 0x30
	public TextMeshProUGUI CurrencyInfo; //Field offset: 0x38
	public TextMeshProUGUI CurrentGoodsName; //Field offset: 0x40
	public TextMeshProUGUI CurrentGoodsDescription; //Field offset: 0x48
	public TextMeshProUGUI CurrentGoodsPrice; //Field offset: 0x50
	public Button BuyButton; //Field offset: 0x58
	public Template PreviewCard; //Field offset: 0x60
	private BoxSlot[] ShopItems; //Field offset: 0x68
	private ShopItemData[] ShopItemsData; //Field offset: 0x70
	private ushort SelectedGood; //Field offset: 0x78

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "GetTMProSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Shop() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Shop() { }

	[AsyncStateMachine(typeof(<Create>d__20))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__20&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Create() { }

	[CalledBy(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "UpdateInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Shop), Member = "IsPurchasable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShopItemData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayGoodsInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "ToSleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(SleeveRarity))]
	[Calls(Type = typeof(Template), Member = "DefineCoverRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void DisplayPreview() { }

	[CalledBy(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	public Rarity GetGoodRarity(ushort id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ToSleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(SleeveRarity))]
	[ContainsUnimplementedInstructions]
	public SleeveRarity GetGoodSleeveRarity(ushort id) { }

	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "ReloadShop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Reload", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetRarityName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetDescriptionForGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void InitData() { }

	[CalledBy(Type = typeof(<>c__DisplayClass36_0), Member = "<OnBuy>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "DisplayGoodsInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "OnBuy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(User), Member = "HasSleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsPurchasable(ShopItemData goods) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shop), Member = "IsPurchasable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShopItemData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void OnBuy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyScreen), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void OnClose() { }

	[CalledBy(Type = typeof(<>c__DisplayClass26_0), Member = "<UpdateProducts>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "ReloadShop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Reload", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "DisplayGoodsInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "ToSleeve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(SleeveRarity))]
	[Calls(Type = typeof(Template), Member = "DefineCoverRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SleeveRarity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void OnSelectGoods(ushort id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	private void OnThemes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shop), Member = "InitData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateProducts", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UnselectAllGoods", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	public void Reload() { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shop), Member = "InitData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateProducts", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UnselectAllGoods", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ReloadShop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Shop), Member = "InitData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateProducts", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UpdateInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "UnselectAllGoods", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shop), Member = "OnSelectGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetRandomCard", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void Start() { }

	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "ReloadShop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Reload", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void UnselectAllGoods() { }

	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "ReloadShop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Reload", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnUpdatePlayerInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(User)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Shop), Member = "DisplayGoodsInfo", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInfo() { }

	[CalledBy(Type = typeof(Shop), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "ReloadShop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "Reload", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxSlot), Member = "SetRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public void UpdateProducts() { }

}

