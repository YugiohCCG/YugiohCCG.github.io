namespace Scenes.Battle.DuelLogging;

public class LogChainNegatedData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public CardDataLog Negator; //Field offset: 0x28
	public CardDataLog Negated; //Field offset: 0x40
	public Color BackColor; //Field offset: 0x58
	public bool IsDisabled; //Field offset: 0x68
	public int ChainCount; //Field offset: 0x6C
	public bool IsOpp; //Field offset: 0x70

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LogManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogChainNegatedData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

