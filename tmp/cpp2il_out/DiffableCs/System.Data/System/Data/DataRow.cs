namespace System.Data;

[DefaultMember("Item")]
public class DataRow
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataTable _table; //Field offset: 0x10
	private readonly DataColumnCollection _columns; //Field offset: 0x18
	internal int _oldRecord; //Field offset: 0x20
	internal int _newRecord; //Field offset: 0x24
	internal int _tempRecord; //Field offset: 0x28
	internal long _rowID; //Field offset: 0x30
	internal DataRowAction _action; //Field offset: 0x38
	internal bool _inChangingEvent; //Field offset: 0x3C
	internal bool _inDeletingEvent; //Field offset: 0x3D
	internal bool _inCascade; //Field offset: 0x3E
	private DataColumn _lastChangedColumn; //Field offset: 0x40
	private int _countColumnChange; //Field offset: 0x48
	private DataError _error; //Field offset: 0x50
	private int _rbTreeNodeId; //Field offset: 0x58
	internal readonly int _objectID; //Field offset: 0x5C

	public bool HasErrors
	{
		[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 61
	}

	internal bool HasPropertyChanged
	{
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public string Item
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsInvalidInstructions]
		 set { } //Length: 146
	}

	public object Item
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
		[CalledBy(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "RowRemovedFromTheTable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DeletedRowInaccessible", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 257
		[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRowView), Member = "SetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "SetRowValueFromXmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "EditInRowChanging", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NoProposedData", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetToNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 30)]
		 set { } //Length: 1030
	}

	public object Item
	{
		[CalledBy(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LookupNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 210
	}

	public Object[] ItemArray
	{
		[CalledBy(Type = typeof(DataRowCollection), Member = "AddWithColumnEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ValueArrayLength", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetToNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataRow), Member = "GetProposedRecordNo", ReturnType = typeof(int))]
		[Calls(Type = typeof(DataColumn), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 25)]
		 set { } //Length: 1065
	}

	internal DataColumn LastChangedColumn
	{
		[CalledBy(Type = typeof(DataView), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 14
		[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 16
	}

	internal int RBTreeNodeId
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 163
	}

	public string RowError
	{
		[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		 get { } //Length: 34
		[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 460
	}

	internal long rowID
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 57
	}

	public DataRowState RowState
	{
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 411
	}

	public DataTable Table
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DataTable), Member = "NewRowFromBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowBuilder)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected private DataRow(DataRowBuilder builder) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public void AcceptChanges() { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void BeginEdit() { }

	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "BeginEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowView), Member = "SetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataTable), Member = "NewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "BeginEditInRowChanging", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DeletedRowInaccessible", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	private bool BeginEditInternal() { }

	[CalledBy(Type = typeof(DataTable), Member = "RollbackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CancelEditInRowChanging", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void CancelEdit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void CheckColumn(DataColumn column) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "GetNestedParentCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataRow), Member = "GetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "SetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NestedCircular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void CheckForLoops(DataRelation rel) { }

	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowNotInTheTable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void CheckInTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ClearError(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ClearErrors() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "CopyValueIntoStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

	[CalledBy(Type = typeof(DataView), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "DeleteRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DeleteInRowDeleting", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	public void Delete() { }

	[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckNotModifying", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowView), Member = "EndEdit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "EndEditInRowChanging", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public void EndEdit() { }

	[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasErrors() { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasPropertyChanged() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[CalledBy(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowRemovedFromTheTable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DeletedRowInaccessible", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public object get_Item(DataColumn column) { }

	[CalledBy(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LookupNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public object get_Item(DataColumn column, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataView), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal DataColumn get_LastChangedColumn() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_RBTreeNodeId() { }

	[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	public string get_RowError() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal long get_rowID() { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 7)]
	public DataRowState get_RowState() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public DataTable get_Table() { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AggregateNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationForeignTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowNotInTheDataSet", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public DataRow[] GetChildRows(DataRelation relation) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public string GetColumnError(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public DataColumn[] GetColumnsInError() { }

	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	internal Object[] GetColumnValues(DataColumn[] columns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	internal Object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataColumn), Member = "CheckMaxLength", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoCurrentData", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetCurrentRecordNo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal DataColumn GetDataColumn(string columnName) { }

	[CalledBy(Type = typeof(DataColumn), Member = "CheckColumnConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckMaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "GetColumnValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowRemovedFromTheTable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DeletedRowInaccessible", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetDefaultRecord() { }

	[CalledBy(Type = typeof(DataView), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "IndexOfDataRowView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	[CalledBy(Type = typeof(DataRow), Member = "SetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowRemovedFromTheTable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DeletedRowInaccessible", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal Object[] GetKeyValues(DataKey key) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	internal Object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "SaveDiffgramData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int GetNestedParentCount() { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoOriginalData", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetOriginalRecordNo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	public DataRow GetParentRow(DataRelation relation) { }

	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "GetNestedParentCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "SetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LookupNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RelationForeignRow", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "GetParentRowTableMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MultipleParents", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Range), Member = "get_Min", ReturnType = typeof(int))]
	[Calls(Type = typeof(Range), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRelation), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(Range), Member = "get_IsNull", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	public DataRow[] GetParentRows(DataRelation relation) { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "GetParentRowTableMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowNotInTheDataSet", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoProposedData", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private int GetProposedRecordNo() { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRowVersion", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoProposedData", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoOriginalData", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoCurrentData", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	internal int GetRecordFromVersion(DataRowVersion version) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRecordToIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "CompareDuplicateRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	internal DataViewRowState GetRecordState(int record) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	internal bool HasKeyChanged(DataKey key) { }

	[CalledBy(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "RecordsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	[CalledBy(Type = typeof(DataColumn), Member = "CheckMaxLength", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRecordToIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "HaveValuesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRowView), Member = "HasRecord", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LookupNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRowVersion", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool HasVersion(DataRowVersion version) { }

	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "RecordsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "RecordsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "RollbackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UDTImplementsIChangeTrackingButnotIRevertible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	public void RejectChanges() { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void ResetLastChangedColumn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RowErrorChanged() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public void set_Item(string columnName, object value) { }

	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowView), Member = "SetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "SetRowValueFromXmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoProposedData", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetToNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "EditInRowChanging", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 30)]
	public void set_Item(DataColumn column, object value) { }

	[CalledBy(Type = typeof(DataRowCollection), Member = "AddWithColumnEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetProposedRecordNo", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetToNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ValueArrayLength", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 25)]
	public void set_ItemArray(Object[] value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_LastChangedColumn(DataColumn value) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "ArrayRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_RBTreeNodeId(int value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_RowError(string value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_rowID(long value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataError), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 27)]
	public void SetColumnError(DataColumn column, string error) { }

	[CalledBy(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	public void SetColumnError(int columnIndex, string error) { }

	[CalledBy(Type = typeof(DataRow), Member = "SetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void SetKeyValues(DataKey key, Object[] keyValues) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "AttachRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetParentRowToDBNull", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetParentRowTableMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal void SetParentRowToDBNull(DataRelation relation) { }

	[CalledBy(Type = typeof(DataRow), Member = "SetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetParentRowTableMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	internal void SetParentRowToDBNull() { }

}

