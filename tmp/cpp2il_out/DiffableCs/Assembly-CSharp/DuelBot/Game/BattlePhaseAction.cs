namespace DuelBot.Game;

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

	[CalledBy(Type = typeof(AI_Custom), Member = "CustomResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectBattleCmdResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BattlePhaseAction(BattleAction action, int index) { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BattlePhaseAction(BattleAction action, Int32[] indexes) { }

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

