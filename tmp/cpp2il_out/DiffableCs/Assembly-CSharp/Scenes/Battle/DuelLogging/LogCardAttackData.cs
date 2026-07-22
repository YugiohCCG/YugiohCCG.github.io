namespace Scenes.Battle.DuelLogging;

public class LogCardAttackData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog PlayerAttacker; //Field offset: 0x18
	public CardDataLog Attacker; //Field offset: 0x28
	public CardDataLog Defender; //Field offset: 0x40
	public PlayerDataLog PlayerDefender; //Field offset: 0x58
	public bool DirectAttack; //Field offset: 0x68
	public Color BackColor; //Field offset: 0x6C

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogCardAttackData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

