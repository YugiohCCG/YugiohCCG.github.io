namespace Extensions;

public class DeckTrunk : DragClone, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Template, Boolean> <>9__30_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <get_SwapReady>b__30_0(Template x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public DeckType fromtype; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass25_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <SwapFromList>b__0(Template x) { }

	}

	private static BoxCollider2D MainDeckBox; //Field offset: 0x0
	private const float TrunkEnterSize = 0.125; //Field offset: 0x0
	private const float NonTrunkEnterSize = 0.125; //Field offset: 0x0
	private const float TrunkLeaveSize = 0.1; //Field offset: 0x0
	private const float NonTrunkLeaveSize = 0.1; //Field offset: 0x0
	private const float MarkedSize = 0.09; //Field offset: 0x0
	private const float MarkedEnter = 0.095; //Field offset: 0x0
	private static BoxCollider2D ExtraDeckBox; //Field offset: 0x8
	private static BoxCollider2D SideDeckBox; //Field offset: 0x10
	private static BoxCollider2D ReferenceFilterBox; //Field offset: 0x18
	private static GameObject DeckBox; //Field offset: 0x20
	private static DeckTrunk SelectedTrunk; //Field offset: 0x28
	private static readonly Dictionary<DeckType, List`1<Template>> MarkedCards; //Field offset: 0x30
	public bool IsFromTrunk; //Field offset: 0xD0
	private BoxCollider2D DragStart; //Field offset: 0xD8

	public static bool CanSwap
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 450
	}

	public static bool SwapReady
	{
		[CalledBy(Type = typeof(DeckTrunk), Member = "SwapCall", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 818
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DeckTrunk() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DeckTrunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(DeckType))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void CheckMark(Template c) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnResetSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnEmptyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearMarks() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void DisableCard() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_CanSwap() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_SwapReady() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static bool HasMarks() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "CheckMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnRightTap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnHoldTap", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DeckType))]
	[CallsUnknownMethods(Count = 2)]
	public static DeckType HoveringBox(Transform t) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(DeckType))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(DeckType))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collider2D), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Bounds), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static DeckType HoveringBox(Vector2 pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DeckType))]
	[CallsUnknownMethods(Count = 1)]
	public static DeckType HoveringBox(RectTransform t) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "ScaleForEnter", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "ScaleForExit", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsCardMarked(Template c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DragClone), Member = "MakeClone", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "DefinePermanent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void MakeClone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider2D), Member = "set_offset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void MakeDragStartBox() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider2D), Member = "set_offset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DragClone), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DragClone), Member = "ResetCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckEdit), Member = "OnApplyButton", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DragClone), Member = "PlaceCloneBackAnimation", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "IsFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DeckEdit), Member = "InsertCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsSingleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Bounds), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collider2D), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DeckType))]
	[Calls(Type = typeof(DragClone), Member = "ResetCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	public override void OnEndDrag(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(DeckType))]
	[Calls(Type = typeof(DeckEdit), Member = "InsertCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DragClone), Member = "EndLife", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnHoldTap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "RefreshDisplayPic", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForEnter", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "RefreshDisplayPic", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForExit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerExit(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckTrunk), Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(DeckType))]
	[Calls(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_IsHoldingCtrl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DragClone), Member = "EndLife", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "CheckMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnRightTap() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "ChangeCardID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "UpdateFavorite", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshDisplayPic() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "UpdateMarkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(DeckType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckTrunk), Member = "IsCardMarked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	public void ScaleForEnter() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "UpdateMarkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(DeckType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "MakeClone", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DeckTrunk), Member = "IsCardMarked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	private void ScaleForExit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void Start() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckTrunk), Member = "SwapFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void SwapAllCards() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeckTrunk), Member = "get_SwapReady", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckTrunk), Member = "SwapAllCards", ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SwapCall() { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapAllCards", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void SwapFromList(DeckType fromtype) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapAllCards", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "CheckMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DeckTrunk), Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void UnmarkCard(Template c, bool unlist = false) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeckTrunk), Member = "ScaleForEnter", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "SwapChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateMarkOrder(Template c, DeckType dt, bool disable) { }

	[CalledBy(Type = typeof(DeckTrunk), Member = "ClearMarks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "UnmarkCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "SwapAllCards", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "CheckMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeckTrunk), Member = "UpdateMarkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(DeckType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateMarkOrders(bool disable = false) { }

}

