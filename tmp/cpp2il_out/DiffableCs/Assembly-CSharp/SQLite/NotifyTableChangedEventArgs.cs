namespace SQLite;

public class NotifyTableChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private TableMapping <Table>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private NotifyTableChangedAction <Action>k__BackingField; //Field offset: 0x18

	public private NotifyTableChangedAction Action
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private TableMapping Table
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NotifyTableChangedEventArgs(TableMapping table, NotifyTableChangedAction action) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public NotifyTableChangedAction get_Action() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TableMapping get_Table() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Action(NotifyTableChangedAction value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Table(TableMapping value) { }

}

