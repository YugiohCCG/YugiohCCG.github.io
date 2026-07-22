namespace Game.Local;

public static class GamePacketFactory
{

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(StocMessage message) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(GameMessage message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BinaryWriter Create(CtosMessage message) { }

}

