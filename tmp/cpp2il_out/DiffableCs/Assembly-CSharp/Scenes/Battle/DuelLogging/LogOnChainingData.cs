namespace Scenes.Battle.DuelLogging;

public class LogOnChainingData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public CardDataLog Card; //Field offset: 0x28
	public Color BackColor; //Field offset: 0x40
	public int ChainCount; //Field offset: 0x50
	public int Description; //Field offset: 0x54
	public CardLocation Location; //Field offset: 0x58
	public int Sequence; //Field offset: 0x5C
	public bool IsOpp; //Field offset: 0x60
	public bool IsOppSide; //Field offset: 0x61

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogOnChainingData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

