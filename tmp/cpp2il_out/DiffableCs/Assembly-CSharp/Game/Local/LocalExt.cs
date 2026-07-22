namespace Game.Local;

[Extension]
public static class LocalExt
{

	[CalledBy(Type = "Manager.P2PManager+<SendCtosDirectPacket>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Byte[] AddDirectHeader(Byte[] packet, DirectMessage header) { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<OnRematchRequest>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnUpdateDeck>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddExtra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Deck ReadDeck(BinaryReader reader, bool allowInvalid = false) { }

	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(User), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "ReadUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Packet), Member = "ReadASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static User ReadLocalUser(BinaryReader reader) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static ulong SetBit(ulong val, int pos, bool value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static byte SetBit(byte val, int pos, bool value) { }

	[CalledBy(Type = "Game.Local.LocalGame+<MoveToDuelist>d__156", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalGame+<SendDuelingPlayers>d__242", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnPlayerInfo>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<SendUpdatedPlayerInfo>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Write(BinaryWriter writer, LocalUser user) { }

	[CalledBy(Type = "Game.Local.LocalGame+<SendJoinGame>d__241", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(byte)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void Write(BinaryWriter writer, LocalGame duel) { }

}

