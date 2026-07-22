namespace Scenes.Battle.DuelLogging;

public class LogCardSpSummonedData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public CardDataLog Card; //Field offset: 0x28
	public Color BackColor; //Field offset: 0x40
	public CardType SPSumType; //Field offset: 0x50
	public ushort MatCount; //Field offset: 0x54

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LogManager), Member = "OnCardSpSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogCardSpSummonedData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

