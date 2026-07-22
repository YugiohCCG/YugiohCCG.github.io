namespace Game;

public class BattlePhaseAction
{
	[CompilerGenerated]
	private BattleAction <Action>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x14

	public private BattleAction Action
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int Index
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BattlePhaseAction(BattleAction action) { }

	[CallerCount(Count = 79)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BattlePhaseAction(BattleAction action, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public BattlePhaseAction(BattleAction action, IList<Int32> indexes) { }

	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BattlePhaseAction(BattleAction action, ClientCard card) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BattleAction get_Action() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Action(BattleAction value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Index(int value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public int ToValue() { }

}

