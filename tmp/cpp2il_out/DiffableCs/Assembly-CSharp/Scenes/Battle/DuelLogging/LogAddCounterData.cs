namespace Scenes.Battle.DuelLogging;

public class LogAddCounterData : ILogEventData, IPooledData
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

	[CalledBy(Type = typeof(LogManager), Member = "OnAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogAddCounterData() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DuelLog get_Event() { }

}

