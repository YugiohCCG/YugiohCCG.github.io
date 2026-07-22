namespace System.Data;

[DefaultMember("Item")]
internal sealed class RecordManager
{
	private readonly DataTable _table; //Field offset: 0x10
	private int _lastFreeRecord; //Field offset: 0x18
	private int _minimumCapacity; //Field offset: 0x1C
	private int _recordCapacity; //Field offset: 0x20
	private readonly List<Int32> _freeRecordList; //Field offset: 0x28
	private DataRow[] _rows; //Field offset: 0x30

	internal DataRow Item
	{
		[CalledBy(Type = typeof(DataColumn), Member = "GetDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataView), Member = "GetRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRowView))]
		[CalledBy(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 43
		[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 6)]
		internal set { } //Length: 123
	}

	internal int LastFreeRecord
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int MinimumCapacity
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NegativeMinimumCapacity", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 64
	}

	internal int RecordCapacity
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[Calls(Type = typeof(DataColumn), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 167
	}

	[CalledBy(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal RecordManager(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void Clear(bool clearAll) { }

	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(RecordManager), Member = "ImportRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataTable), Member = "NewUninitializedRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	internal int CopyRecord(DataTable src, int record, int copy) { }

	[CalledBy(Type = "Mono.Unity.UnityTls+unitytls_interface_struct+unitytls_x509verify_explicit_ca_t", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void FreeRecord(ref int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "GetDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataView), Member = "GetRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRowView))]
	[CalledBy(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	internal DataRow get_Item(int record) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_LastFreeRecord() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_MinimumCapacity() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal int get_RecordCapacity() { }

	[CalledBy(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void GrowRecordCapacity() { }

	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	internal int ImportRecord(DataTable src, int record) { }

	[CallerCount(Count = 0)]
	internal static int NewCapacity(int capacity) { }

	[CalledBy(Type = typeof(DataTable), Member = "NewRecord", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "NewUninitializedRecord", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "NewUninitializedRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RecordManager), Member = "GrowRecordCapacity", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal int NewRecordBase() { }

	[CallerCount(Count = 0)]
	private int NormalizedMinimumCapacity(int capacity) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 6)]
	internal void set_Item(int record, DataRow value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NegativeMinimumCapacity", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void set_MinimumCapacity(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_RecordCapacity(int value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetRowCache(DataRow[] newRows) { }

}

