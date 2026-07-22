namespace Scenes.Battle.DuelLogging;

public class LogCardMovedData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public CardDataLog Card; //Field offset: 0x28
	public Color BackColor; //Field offset: 0x40
	public Reason MoveReason; //Field offset: 0x50
	public byte PrevCont; //Field offset: 0x54
	public CardLocation PrevLoc; //Field offset: 0x58
	public byte PrevSeq; //Field offset: 0x5C
	public byte CurCont; //Field offset: 0x5D
	public CardLocation CurLoc; //Field offset: 0x60
	public byte CurSeq; //Field offset: 0x64

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LogManager), Member = "OnCardMoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Reason), typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(byte), typeof(CardLocation), typeof(byte), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogCardMovedData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

