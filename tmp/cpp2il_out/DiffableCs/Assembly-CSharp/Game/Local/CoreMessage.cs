namespace Game.Local;

public class CoreMessage
{
	[CompilerGenerated]
	private GameMessage <Message>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private BinaryReader <Reader>k__BackingField; //Field offset: 0x18
	private readonly Byte[] _raw; //Field offset: 0x20
	private readonly MemoryStream _stream; //Field offset: 0x28
	public readonly int _startPosition; //Field offset: 0x30
	private int _endPosition; //Field offset: 0x34
	private int _length; //Field offset: 0x38

	public private GameMessage Message
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private BinaryReader Reader
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public CoreMessage(GameMessage msg, BinaryReader reader, Byte[] raw) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnConfirmCards>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnHint>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnReloadField>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<SendToAll>d__55", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<SendToPlayer>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<SendToTeam>d__59", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Byte[] CreateBuffer() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameMessage get_Message() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BinaryReader get_Reader() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Message(GameMessage value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Reader(BinaryReader value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetEndPosition() { }

}

