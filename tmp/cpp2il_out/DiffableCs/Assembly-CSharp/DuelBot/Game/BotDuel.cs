namespace DuelBot.Game;

public class BotDuel
{
	private GameSettings _settings; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsFirst>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsNewRule>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <IsNewRule2020>k__BackingField; //Field offset: 0x52
	[CompilerGenerated]
	private bool <IsManual>k__BackingField; //Field offset: 0x53
	[CompilerGenerated]
	private BotClientField[] <Fields>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <Turn>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <Player>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private DuelPhase <Phase>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private BotMainPhase <BotMainPhase>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private BotBattlePhase <BotBattlePhase>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <LastChainPlayer>k__BackingField; //Field offset: 0x80
	public readonly IList<BotClientCard> CurrentChain; //Field offset: 0x88
	public readonly IList<BotClientCard> ChainTargets; //Field offset: 0x90
	public readonly IList<BotClientCard> ChainTargetOnly; //Field offset: 0x98
	[CompilerGenerated]
	private int <LastSummonPlayer>k__BackingField; //Field offset: 0xA0
	public readonly IList<BotClientCard> SummoningCards; //Field offset: 0xA8
	public readonly IList<BotClientCard> LastSummonedCards; //Field offset: 0xB0

	public BotBattlePhase BotBattlePhase
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public BotMainPhase BotMainPhase
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private BotClientField[] Fields
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool IsFirst
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsManual
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsNewRule
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IsNewRule2020
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int LastChainPlayer
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

	public int LastSummonPlayer
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public DuelPhase Phase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int Player
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GameSettings Settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 35
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 62
	}

	public int Turn
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(GameBehavior), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public BotDuel() { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BotClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void AddCard(CardLocation loc, BotClientCard card, int player, int seq, int pos, int id) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotClientCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void AddCard(CardLocation loc, int cardId, int player, int seq, int pos) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotBattlePhase get_BotBattlePhase() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotMainPhase get_BotMainPhase() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BotClientField[] get_Fields() { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsFirst() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsManual() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsNewRule() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsNewRule2020() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LastChainPlayer() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LastSummonPlayer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DuelPhase get_Phase() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Player() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GameSettings get_Settings() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Turn() { }

	[CallerCount(Count = 34)]
	[CallsUnknownMethods(Count = 5)]
	public BotClientCard GetCard(int player, int loc, int seq, int subSeq) { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnBotFieldCardInfo>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BotDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BotClientCard))]
	public BotClientCard GetCard(int player, CardLocation loc, int seq) { }

	[CallerCount(Count = 0)]
	public int GetLocalPlayer(int player) { }

	[CalledBy(Type = typeof(GameBehavior), Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameBehavior), Member = "OnSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveCard(CardLocation loc, BotClientCard card, int player, int seq) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_BotBattlePhase(BotBattlePhase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_BotMainPhase(BotMainPhase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Fields(BotClientField[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsFirst(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsManual(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsNewRule(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsNewRule2020(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_LastChainPlayer(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_LastSummonPlayer(int value) { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Phase(DuelPhase value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Player(int value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_Settings(GameSettings value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Turn(int value) { }

}

