namespace Scenes.Battle.DuelLogging;

public class LogNewTurnData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player1; //Field offset: 0x18
	public PlayerDataLog Player2; //Field offset: 0x28
	public Color BackColor; //Field offset: 0x38
	public int Turn; //Field offset: 0x48
	public int LP1; //Field offset: 0x4C
	public int LP2; //Field offset: 0x50

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogNewTurnData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

