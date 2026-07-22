namespace System.Data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting
{
	private DataViewManager _dataViewManager; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x18
	private string _sort; //Field offset: 0x20
	private string _rowFilter; //Field offset: 0x28
	private DataViewRowState _rowStateFilter; //Field offset: 0x30
	private bool _applyDefaultSort; //Field offset: 0x34

	public bool ApplyDefaultSort
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string RowFilter
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public DataViewRowState RowStateFilter
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Sort
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataViewSetting() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ApplyDefaultSort() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_RowFilter() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public DataViewRowState get_RowStateFilter() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Sort() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetDataTable(DataTable table) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

}

