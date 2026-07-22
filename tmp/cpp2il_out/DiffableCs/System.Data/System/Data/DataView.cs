namespace System.Data;

[DefaultEvent("PositionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
{
	private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
	{
		internal static readonly DataRowReferenceComparer s_default; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static DataRowReferenceComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private DataRowReferenceComparer() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Equals(DataRow x, DataRow y) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override int GetHashCode(DataRow obj) { }

	}

	internal static ListChangedEventArgs s_resetEventArgs; //Field offset: 0x0
	private static int s_objectTypeCount; //Field offset: 0x8
	private DataViewManager _dataViewManager; //Field offset: 0x20
	private DataTable _table; //Field offset: 0x28
	private bool _locked; //Field offset: 0x30
	private Index _index; //Field offset: 0x38
	private Dictionary<String, Index> _findIndexes; //Field offset: 0x40
	private string _sort; //Field offset: 0x48
	private Comparison<DataRow> _comparison; //Field offset: 0x50
	private IFilter _rowFilter; //Field offset: 0x58
	private DataViewRowState _recordStates; //Field offset: 0x60
	private bool _shouldOpen; //Field offset: 0x64
	private bool _open; //Field offset: 0x65
	private bool _allowNew; //Field offset: 0x66
	private bool _allowEdit; //Field offset: 0x67
	private bool _allowDelete; //Field offset: 0x68
	private bool _applyDefaultSort; //Field offset: 0x69
	internal DataRow _addNewRow; //Field offset: 0x70
	private ListChangedEventArgs _addNewMoved; //Field offset: 0x78
	private ListChangedEventHandler _onListChanged; //Field offset: 0x80
	private string _delayedSort; //Field offset: 0x88
	private DataViewRowState _delayedRecordStates; //Field offset: 0x90
	private bool _fInitInProgress; //Field offset: 0x94
	private bool _fEndInitInProgress; //Field offset: 0x95
	private Dictionary<DataRow, DataRowView> _rowViewCache; //Field offset: 0x98
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; //Field offset: 0xA0
	private DataViewListener _dvListener; //Field offset: 0xA8
	private readonly int _objectID; //Field offset: 0xB0

	[DefaultValue(True)]
	public bool AllowDelete
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	public bool AllowEdit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	public bool AllowNew
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Browsable(False)]
	public override int Count
	{
		[CalledBy(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 71
	}

	private int CountFromIndex
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 40
	}

	[Browsable(False)]
	public DataViewManager DataViewManager
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[Browsable(False)]
	protected bool IsOpen
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public DataRowView Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 94
	}

	internal int ObjectID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[DefaultValue(DataViewRowState::CurrentRows (22))]
	public DataViewRowState RowStateFilter
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	public string Sort
	{
		[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataTable), Member = "FormatSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 84
		[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.ApplySort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(ListSortDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.RemoveSort", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DataTable), Member = "ParseSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IndexField[]))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotUse", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 459
	}

	internal Comparison<DataRow> SortComparison
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 94
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "SetIListObject", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 39
	}

	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataTable), Member = "FormatSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 94
	}

	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 61
	}

	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 142
	}

	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DataView() { }

	[CalledBy(Type = typeof(DataTablePropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewManagerListItemTypeDescriptor), Member = "GetDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataView))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView), typeof(DataKey), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal DataView(DataTable table, bool locked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	public DataView(DataTable table) { }

	[CalledBy(Type = typeof(RelatedView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRowView), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AddNewNotAllowNull", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NotOpen", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public override DataRowView AddNew() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NotOpen", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private void CheckOpen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "ParseSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotUse", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private void CheckSort(string sort) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "ChildRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRelationPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	protected override void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	[CalledBy(Type = typeof(DataView), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Data.RBTree`1+RBTreeEnumerator<System.Int32>))]
	[Calls(Type = typeof(RBTreeEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataView), Member = "GetRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRowView))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 12)]
	private void CopyTo(DataRowView[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Data.RBTree`1+RBTreeEnumerator<System.Int32>))]
	[Calls(Type = typeof(RBTreeEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataView), Member = "GetRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRowView))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Delete(int index) { }

	[CalledBy(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataRow), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotDelete", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NotOpen", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 9)]
	internal void Delete(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MarshalByValueComponent), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(DataRowView), Member = "EndEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "IndexListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void FinishAddNew(bool success) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowDelete() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowEdit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowNew() { }

	[CalledBy(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private int get_CountFromIndex() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DataViewManager get_DataViewManager() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected bool get_IsOpen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DataRowView get_Item(int recordIndex) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public DataViewRowState get_RowStateFilter() { }

	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "FormatSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_Sort() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal Comparison<DataRow> get_SortComparison() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public DataTable get_Table() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal override IFilter GetFilter() { }

	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.AddIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.RemoveIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Index GetFindIndex(string column, bool keepIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private int GetRecord(int recordIndex) { }

	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataView), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRowView))]
	[CalledBy(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "GetElementIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	internal DataRow GetRow(int index) { }

	[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private DataRowView GetRowView(int record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private DataRowView GetRowView(DataRow dr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal PropertyDescriptor GetSortProperty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void IndexListChanged(object sender, ListChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	[CalledBy(Type = typeof(DataView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "System.Collections.IList.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRowVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(DataRowVersion))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal int IndexOf(DataRowView rowview) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRowVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(DataRowVersion))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int IndexOfDataRowView(DataRowView rowview) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRowVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(DataRowVersion))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataView), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "get_LastChangedColumn", ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRowView), Member = "RaisePropertyChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnListChanged(ListChangedEventArgs e) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "ParentRelationCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRelationPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(PropertyDescriptor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[CalledBy(Type = typeof(RelatedView), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void Reset() { }

	[CalledBy(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView), typeof(DataKey), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Data.RBTree`1+RBTreeEnumerator<System.Int32>))]
	[Calls(Type = typeof(RBTreeEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void ResetRowViewCache() { }

	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.ApplySort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(ListSortDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.RemoveSort", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "ParseSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotUse", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_Sort(string value) { }

	[CalledBy(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	[CalledBy(Type = typeof(DataTablePropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataViewManagerListItemTypeDescriptor), Member = "GetDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataView))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotUse", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	[CalledBy(Type = typeof(DataTablePropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewManagerListItemTypeDescriptor), Member = "GetDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataView))]
	[CalledBy(Type = typeof(RelatedView), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AddExternalObject", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotClear", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IList.Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.IList.Contains(object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.IList.get_Item(int recordIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InsertExternalObject", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RemoveExternalObject", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetIListObject", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IList.set_Item(int recordIndex, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetFindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Index))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override object System.ComponentModel.IBindingList.AddNew() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DataView), Member = "set_Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Range), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(Range), Member = "get_Min", ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "FormatSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "GetFindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Index))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "set_Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = "FindTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(PropertyDescriptor[]), typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = "FindTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(PropertyDescriptor[]), typeof(int)}, ReturnType = typeof(DataTable))]
	[CallsUnknownMethods(Count = 1)]
	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	[CalledBy(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataView), Member = "get_Sort", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataViewListener), Member = "RegisterListChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	internal void UpdateIndex(bool force, bool fireEvent) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void UpdateIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	protected override void UpdateIndex(bool force) { }

}

