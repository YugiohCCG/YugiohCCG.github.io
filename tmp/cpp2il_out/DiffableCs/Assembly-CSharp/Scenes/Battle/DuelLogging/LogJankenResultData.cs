namespace Scenes.Battle.DuelLogging;

public class LogJankenResultData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player1; //Field offset: 0x18
	public PlayerDataLog Player2; //Field offset: 0x28
	public Color BackColor; //Field offset: 0x38
	public byte P1Selection; //Field offset: 0x48
	public byte P2Selection; //Field offset: 0x49

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogJankenResultData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

