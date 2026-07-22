namespace Data;

[Extension]
public static class BinaryExtensions
{
	public const string DATE_TIME_FORMAT = "dd-MM-yyyy"; //Field offset: 0x0

	[CalledBy(Type = typeof(HostSettings), Member = "LoadHostRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Packet), Member = "MakeLocalCreateGame", ReturnType = typeof(BinaryWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(General), Member = "GetLongPlayerPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[Calls(Type = typeof(General), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public static bool GetSettingsPref(out GameSettings gs, out string releasedFrom, out string releasedTo) { }

	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnCreateGame>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "ReadRoomData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(RoomData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryExtensions), Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings&), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tournament), Member = "DefineTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Tournament))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(byte), typeof(byte)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Packet), Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static GameSettings ReadGameSettings(BinaryReader reader) { }

	[CalledBy(Type = "Data.RoomData+<Setup>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(byte), typeof(byte)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void ReadRoomData(BinaryReader reader, RoomData rd) { }

	[CalledBy(Type = typeof(HostSettings), Member = "OnCreateRoomButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "SaveHostRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&)}, ReturnType = typeof(GameSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DateTime), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "SetULongPlayerPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void SetSettingsPref(GameSettings gs, string rf, string rt, uint banlist) { }

	[CalledBy(Type = typeof(Packet), Member = "MakeRoomSetupRulesPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(uint)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "CreateTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings), typeof(bool), typeof(bool), typeof(bool), typeof(Int64[])}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "CreateGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameSettings)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "MakeLocalCreateGame", ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalGame)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<SendNewRulesToAll>d__129", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameSettings), Member = "ToUInt64", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DateTime), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, GameSettings info) { }

}

