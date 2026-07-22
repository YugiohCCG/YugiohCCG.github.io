namespace System.Data;

public class DataColumnChangeEventArgs : EventArgs
{
	private DataColumn _column; //Field offset: 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; //Field offset: 0x20

	public object ProposedValue
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DataColumnChangeEventArgs(DataRow row) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_ProposedValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ProposedValue(object value) { }

}

