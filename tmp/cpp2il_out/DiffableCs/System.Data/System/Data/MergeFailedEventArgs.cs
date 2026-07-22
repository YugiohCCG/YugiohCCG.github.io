namespace System.Data;

public class MergeFailedEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; //Field offset: 0x18

	public string Conflict
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DataSet), Member = "RaiseMergeFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public MergeFailedEventArgs(DataTable table, string conflict) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Conflict() { }

}

