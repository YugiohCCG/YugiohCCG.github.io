namespace System.Data;

internal sealed class XMLDiffLoader
{
	private ArrayList _tables; //Field offset: 0x10
	private DataSet _dataSet; //Field offset: 0x18
	private DataTable _dataTable; //Field offset: 0x20

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XMLDiffLoader() { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void CreateTablesHierarchy(DataTable dt) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private DataTable GetTable(string tableName, string ns) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTextReader), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTextReader), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_RowDiffId", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(DataTable), Member = "NewEmptyRow", ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DiffgramMissingSQL", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_RowDiffId", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(DataTable), Member = "NewEmptyRow", ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DiffgramMissingSQL", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_RowDiffId", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DiffgramMissingSQL", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 4)]
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_RowDiffId", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DiffgramMissingSQL", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 6)]
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlRootAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_IsCustomType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_EncodedColumnName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "NewRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTableCollection), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DiffgramMissingTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 52)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void SkipWhitespaces(XmlReader reader) { }

}

