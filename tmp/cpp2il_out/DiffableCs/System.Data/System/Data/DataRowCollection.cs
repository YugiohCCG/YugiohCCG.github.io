namespace System.Data;

[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase
{
	private sealed class DataRowTree : RBTree<DataRow>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeAccessMethod)}, ReturnType = typeof(void))]
		internal DataRowTree() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual int CompareNode(DataRow record1, DataRow record2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

	}

	private readonly DataTable _table; //Field offset: 0x10
	private readonly DataRowTree _list; //Field offset: 0x18
	internal int _nullInList; //Field offset: 0x20

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RBTree`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	public DataRow Item
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "DoAssignments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 81
	}

	[CalledBy(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeAccessMethod)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataRowCollection(DataTable table) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "AttachRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Add(DataRow row) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DataRow AddWithColumnEvents(Object[] values) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataRow), Member = "set_RBTreeNodeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ArrayAdd(DataRow row) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ArrayClear() { }

	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "set_RBTreeNodeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ArrayInsert(DataRow row, int pos) { }

	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "RBDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "set_RBTreeNodeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	internal void ArrayRemove(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void CopyTo(Array ar, int index) { }

	[CalledBy(Type = typeof(AggregateNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void CopyTo(DataRow[] array, int index) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RBTree`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowInsertTwice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void DiffInsertAt(DataRow row, int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Count() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "DoAssignments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public DataRow get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsUnknownMethods(Count = 1)]
	public virtual IEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int IndexOf(DataRow row) { }

}

