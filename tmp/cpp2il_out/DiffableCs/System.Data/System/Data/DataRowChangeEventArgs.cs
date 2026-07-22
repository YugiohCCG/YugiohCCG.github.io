namespace System.Data;

public class DataRowChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly DataRowAction <Action>k__BackingField; //Field offset: 0x18

	[CalledBy(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "OnRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "OnRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DataRowChangeEventArgs(DataRow row, DataRowAction action) { }

}

