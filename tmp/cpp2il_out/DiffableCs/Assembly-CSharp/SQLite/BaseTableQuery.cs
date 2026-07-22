namespace SQLite;

public abstract class BaseTableQuery
{
	internal class Ordering
	{
		[CompilerGenerated]
		private string <ColumnName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <Ascending>k__BackingField; //Field offset: 0x18

		public bool Ascending
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public string ColumnName
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Ordering() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_Ascending() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_ColumnName() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Ascending(bool value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_ColumnName(string value) { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected BaseTableQuery() { }

}

