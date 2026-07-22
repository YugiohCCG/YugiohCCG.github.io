namespace Scenes.Battle;

public class FieldSide : MonoBehaviour
{
	public HandCards PlayerHand; //Field offset: 0x20
	public FieldSlot[] MonsterZones; //Field offset: 0x28
	public FieldSlot[] SpellZones; //Field offset: 0x30
	public FieldSlot FieldSpellZone; //Field offset: 0x38
	public FieldSlot Graveyard; //Field offset: 0x40
	public FieldSlot BanishedZone; //Field offset: 0x48
	public FieldSlot MainDeck; //Field offset: 0x50
	public FieldSlot ExtraDeck; //Field offset: 0x58
	public FieldSlot PendulumLeft; //Field offset: 0x60
	public FieldSlot PendulumRight; //Field offset: 0x68
	public FieldSlot SplitPendulumLeft; //Field offset: 0x70
	public FieldSlot SplitPendulumRight; //Field offset: 0x78
	public GridLayoutGroup MonsterZonesLayout; //Field offset: 0x80
	public GridLayoutGroup SpellZonesLayout; //Field offset: 0x88
	public GridLayoutGroup LeftZonesLayout; //Field offset: 0x90
	public GridLayoutGroup RightZonesLayout; //Field offset: 0x98
	public ClientField FieldData; //Field offset: 0xA0
	public List<FieldSlot> AllSlots; //Field offset: 0xA8
	public Player CurrentOwner; //Field offset: 0xB0
	private byte _controller; //Field offset: 0xB8
	private Canvas FieldCanvas; //Field offset: 0xC0

	public byte Controller
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 294
	}

	public bool IsPlayerSide
	{
		[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_IsMine", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 201
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public FieldSide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "OnSlotDataSet", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private void Awake() { }

	[CalledBy(Type = typeof(DuelZone), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "ClearAllTargeting", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ClearAllTargeting() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Zones), Member = "IsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "set_BackgroundIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void FixedUpdate() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public byte get_Controller() { }

	[CalledBy(Type = typeof(FieldSide), Member = "InitializeFieldZones", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_IsMine", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsPlayerSide() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSide), Member = "get_IsPlayerSide", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "set_SlotFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "set_BackgroundIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeFieldZones() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 27)]
	public void OnUpdatedMonsterZone(object sender, NotifyCollectionChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldSlot), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 27)]
	public void OnUpdatedSpellZone(object sender, NotifyCollectionChangedEventArgs e) { }

	[CalledBy(Type = "Game.DuelManager+<OnStart>d__110", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void set_Controller(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "OnSlotDataSet", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetSlotCode(FieldSlot target, int code, CardLocation location, byte sequence) { }

}

