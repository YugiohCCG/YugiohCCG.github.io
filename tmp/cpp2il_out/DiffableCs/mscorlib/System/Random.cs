namespace System;

public class Random
{
	[ThreadStatic]
	private static Random t_threadRandom; //Field offset: 0x80000000
	private static readonly Random s_globalRandom; //Field offset: 0x0
	private int _inext; //Field offset: 0x10
	private int _inextp; //Field offset: 0x14
	private Int32[] _seedArray; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Random() { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<MassImportation>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.Dice+<Create>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.SQLiteConnectionString"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.BotCore", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.DecksManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Tips", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HashHelpers), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.MathUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Random), Member = "GenerateSeed", ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	public Random() { }

	[CalledBy(Type = "Manager.Packet", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), "Card.Deck"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Random), Member = "GenerateSeed", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Random), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Random(int Seed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private static int GenerateGlobalSeed() { }

	[CalledBy(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static int GenerateSeed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private double GetSampleForLargeRange() { }

	[CalledBy(Type = typeof(Random), Member = "Sample", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Random), Member = "Next", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Random), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Random), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private int InternalSample() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	public override int Next() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public override int Next(int minValue, int maxValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override int Next(int maxValue) { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override double NextDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	protected override double Sample() { }

}

