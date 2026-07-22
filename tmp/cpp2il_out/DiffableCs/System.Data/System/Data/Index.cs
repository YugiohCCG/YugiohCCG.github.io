namespace System.Data;

internal sealed class Index
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DataViewListener, DataViewListener, Boolean> <>9__22_0; //Field offset: 0x8
		public static Action<DataViewListener, DataViewListener, ListChangedEventArgs, Boolean, Boolean> <>9__85_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <.ctor>b__22_0(DataViewListener listener) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataViewListener), Member = "IndexListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public ListChangedType changedType; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass86_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataViewListener), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

	}

	private sealed class IndexTree : RBTree<Int32>
	{
		private readonly Index _index; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RBTree`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeAccessMethod)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal IndexTree(Index index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual int CompareNode(int record1, int record2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Index), Member = "CompareDuplicateRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual int CompareSateliteTreeNode(int record1, int record2) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataTable _table; //Field offset: 0x10
	internal readonly IndexField[] _indexFields; //Field offset: 0x18
	private readonly Comparison<DataRow> _comparison; //Field offset: 0x20
	private readonly DataViewRowState _recordStates; //Field offset: 0x28
	private WeakReference _rowFilter; //Field offset: 0x30
	private IndexTree _records; //Field offset: 0x38
	private int _recordCount; //Field offset: 0x40
	private int _refCount; //Field offset: 0x44
	private Listeners<DataViewListener> _listeners; //Field offset: 0x48
	private bool _suspendEvents; //Field offset: 0x50
	private readonly bool _isSharable; //Field offset: 0x51
	private readonly bool _hasRemoteAggregate; //Field offset: 0x52
	private readonly int _objectID; //Field offset: 0x54

	private bool DoListChanged
	{
		[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 105
	}

	public bool HasDuplicates
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	internal bool HasRemoteAggregate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int ObjectID
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public int RecordCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public DataViewRowState RecordStates
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int RefCount
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public IFilter RowFilter
	{
		[CalledBy(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "InsertRecordToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 126
	}

	internal DataTable Table
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Data.Listeners`1<TElem>+Func`2<TElem, TElem, Boolean>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataExpression), Member = "HasRemoteAggregate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "InitRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFilter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RecordStateRange", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InitRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecordToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool AcceptRecord(int record, IFilter filter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "get_RowFilter", ReturnType = typeof(IFilter))]
	[Calls(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFilter)}, ReturnType = typeof(bool))]
	private bool AcceptRecord(int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "GetFindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterListChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "ConstraintIndexInitialize", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterWriteLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ShadowIndexCopy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitWriteLock", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void AddRef() { }

	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "get_RowFilter", ReturnType = typeof(IFilter))]
	[Calls(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFilter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckUnique", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckUnique() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int CompareDataRows(int record1, int record2) { }

	[CalledBy(Type = typeof(IndexTree), Member = "CompareSateliteTreeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int CompareDuplicateRecords(int record1, int record2) { }

	[CalledBy(Type = typeof(IndexTree), Member = "CompareNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyRecordInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataRowCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int CompareRecords(int record1, int record2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumn), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int CompareRecordToKey(int record1, Object[] vals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	private void DeleteRecord(int recordIndex) { }

	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "DeleteByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	[CalledBy(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public void DeleteRecordFromIndex(int recordIndex) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Range))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "ConvertValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RBTree`1), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(DataColumn), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "IndexKeyLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	private int FindNodeByKey(object originalKey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindNodeByKeyRecord(int record) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Range))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "IndexKeyLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RBTree`1), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(DataColumn), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	private int FindNodeByKeys(Object[] originalKey) { }

	[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	public Range FindRecords(Object[] key) { }

	[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	public Range FindRecords(object key) { }

	[CalledBy(Type = typeof(DataTable), Member = "RestoreIndexEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FireResetEvent() { }

	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_DoListChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_HasDuplicates() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasRemoteAggregate() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_RecordCount() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public DataViewRowState get_RecordStates() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public int get_RefCount() { }

	[CalledBy(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecordToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IFilter get_RowFilter() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal DataTable get_Table() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RBTreeEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>", typeof(int)}, ReturnType = typeof(void))]
	public RBTreeEnumerator<Int32> GetEnumerator(int startIndex) { }

	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	private int GetIndex(int record, int changeRecord) { }

	[CalledBy(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "IndexOfDataRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetIndex(int record) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Range))]
	[CalledBy(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Range))]
	[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "SubTreeSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RangeArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private Range GetRangeFromNode(int nodeId) { }

	[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RBTree`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[CallsUnknownMethods(Count = 1)]
	public int GetRecord(int recordIndex) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int GetReplaceAction(DataViewRowState oldState) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[CallsUnknownMethods(Count = 2)]
	public DataRow GetRow(int i) { }

	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	public DataRow[] GetRows(Object[] values) { }

	[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(RBTreeEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTreeEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullRange", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public DataRow[] GetRows(Range range) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Object[] GetUniqueKeyValues() { }

	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = "Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 7)]
	private void GetUniqueKeyValues(List<Object[]> list, int curNodeId) { }

	[CalledBy(Type = typeof(Listeners`1), Member = "IndexOfReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElem"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Listeners`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElem"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int IndexOfReference(List<T> list, T item) { }

	[CalledBy(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeAccessMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFilter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RBTree`1), Member = "InsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K", typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void InitRecords(IFilter filter) { }

	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "InsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K", typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "get_DoListChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int InsertRecord(int record, bool fireEvent) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRecordToIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "get_RowFilter", ReturnType = typeof(IFilter))]
	[Calls(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFilter)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	public int InsertRecordToIndex(int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool IsKeyInIndex(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool IsKeyInIndex(Object[] key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "Left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsKeyRecordInIndex(int record) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterListChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Listeners`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElem"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ListChangedAdd(DataViewListener listener) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Listeners`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElem"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ListChangedRemove(DataViewListener listener) { }

	[CalledBy(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Action`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = "Notify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "System.Data.Listeners`1<TElem>+Action`4<TElem, TElem, T1, T2, T3>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	[CalledBy(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnListChanged(ListChangedType changedType, int index) { }

	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	[CalledBy(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Data.Listeners`1+Action`4<System.Object, System.Object, System.Object, System.Boolean, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Data.Listeners`1<System.Object>), Member = "Notify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(bool), typeof(System.Data.Listeners`1+Action`4<System.Object, System.Object, System.Object, System.Boolean, System.Boolean>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnListChanged(ListChangedEventArgs e) { }

	[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RecordChanged(int record) { }

	[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RecordChanged(int oldIndex, int newIndex) { }

	[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3", "T4", "T5", "T6"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1", "T2", "T3", "T4", "T5", "T6"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "get_RowFilter", ReturnType = typeof(IFilter))]
	[Calls(Type = typeof(Index), Member = "AcceptRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFilter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "UpdateNodeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K", "K"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "DeleteByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[Calls(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "ConstraintIndexClear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterListChangedEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "GetFindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRecordToIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[CalledBy(Type = "System.Data.TypeLimiter+Scope+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitWriteLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterWriteLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ShadowIndexCopy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 7)]
	public int RemoveRef() { }

	[CalledBy(Type = typeof(DataTable), Member = "RestoreIndexEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "get_RowFilter", ReturnType = typeof(IFilter))]
	[Calls(Type = typeof(Index), Member = "InitRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFilter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = "get_HasListeners", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_AreIndexEventsSuspended", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

}

