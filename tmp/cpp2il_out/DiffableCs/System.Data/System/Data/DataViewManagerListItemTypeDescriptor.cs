namespace System.Data;

internal sealed class DataViewManagerListItemTypeDescriptor
{
	private DataViewManager _dataViewManager; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetDataViewManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewManager)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DataView GetDataView(DataTable table) { }

}

