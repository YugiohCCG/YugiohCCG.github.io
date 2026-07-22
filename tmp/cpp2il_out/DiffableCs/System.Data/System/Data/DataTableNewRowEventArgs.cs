namespace System.Data;

public sealed class DataTableNewRowEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x10

	[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DataTableNewRowEventArgs(DataRow dataRow) { }

}

