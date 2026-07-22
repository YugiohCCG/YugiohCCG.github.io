namespace System.Data;

[DefaultMember("Item")]
public class DataViewSettingCollection
{
	private readonly DataViewManager _dataViewManager; //Field offset: 0x10
	private readonly Hashtable _list; //Field offset: 0x18

	public override DataViewSetting Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 351
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 184
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public override DataViewSetting get_Item(DataTable table) { }

	[CalledBy(Type = typeof(DataSet), Member = "OnRemovedTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Remove(DataTable table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override void set_Item(DataTable table, DataViewSetting value) { }

}

