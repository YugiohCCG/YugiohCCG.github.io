namespace Scenes.Battle.DuelLogging;

public class LogRemoveCounterData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public Color BackColor; //Field offset: 0x28
	public CounterTypes Counter; //Field offset: 0x38
	public ushort Amount; //Field offset: 0x3C
	public ushort Previous; //Field offset: 0x3E
	public ushort Current; //Field offset: 0x40
	public CardDataLog Card; //Field offset: 0x48

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogRemoveCounterData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

