namespace Scenes.Battle.DuelLogging;

public class LogCardSwapData : ILogEventData, IPooledData
{
	[CompilerGenerated]
	private readonly DuelLog <Event>k__BackingField; //Field offset: 0x10
	public PlayerDataLog Player; //Field offset: 0x18
	public CardDataLog Card1; //Field offset: 0x28
	public CardDataLog Card2; //Field offset: 0x40
	public Color BackColor; //Field offset: 0x58

	public override DuelLog Event
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LogManager), Member = "OnCardSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogCardSwapData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

