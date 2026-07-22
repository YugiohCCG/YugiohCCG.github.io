namespace Data;

public struct GameSettings : ISerializable
{
	public static GameSettings TCGSettings; //Field offset: 0x0
	public static GameSettings OCGSettings; //Field offset: 0x40
	public static GameSettings SPDSettings; //Field offset: 0x80
	public static GameSettings DLSettings; //Field offset: 0xC0
	public static GameSettings GoatSettings; //Field offset: 0x100
	public static GameSettings EdisonSettings; //Field offset: 0x140
	public static GameSettings GenesysSettings; //Field offset: 0x180
	public static GameSettings RushSettings; //Field offset: 0x1C0
	public CardSet Region; //Field offset: 0x0
	public byte MasterRule; //Field offset: 0x4
	public DuelMode Mode; //Field offset: 0x5
	public byte StartHand; //Field offset: 0x6
	public byte DrawCount; //Field offset: 0x7
	public short Timer; //Field offset: 0x8
	public int StartLP; //Field offset: 0xC
	public DuelRules DuelRule; //Field offset: 0x10
	public ExtraRules ExtraRule; //Field offset: 0x18
	public bool IsPublic; //Field offset: 0x20
	public DateTime ReleasedFrom; //Field offset: 0x28
	public DateTime ReleasedTo; //Field offset: 0x30
	public int Budget; //Field offset: 0x38

	public bool NoShuffleDeck
	{
		[CalledBy(Type = typeof(RoomData), Member = "get_IsCustom", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RoomData), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static GameSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 1)]
	public GameSettings(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(RoomData), Member = "get_IsCustom", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RoomData), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public bool get_NoShuffleDeck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(HostSettings), Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static GameSettings GetSettingsForLimit(Limitation lm) { }

	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnCurrentDeckTap", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(General), Member = "IsRanked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelQueue)}, ReturnType = typeof(bool))]
	public static GameSettings GetSettingsForQueue(DuelQueue q) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "OnTryEnterSeletedRoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.RoomData+<GenPwd>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "CheckPwd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32, System.UInt64>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RoomData), Member = "CheckPwd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(byte)}, ReturnType = typeof(ulong))]
	[ContainsUnimplementedInstructions]
	public ulong ToUInt64() { }

}

