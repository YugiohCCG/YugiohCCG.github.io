namespace System.Data;

internal sealed class NewDiffgramGen
{
	internal XmlDocument _doc; //Field offset: 0x10
	internal DataSet _ds; //Field offset: 0x18
	internal DataTable _dt; //Field offset: 0x20
	internal XmlWriter _xmlw; //Field offset: 0x28
	private bool _fBefore; //Field offset: 0x30
	private bool _fErrors; //Field offset: 0x31
	internal Hashtable _rowsOrder; //Field offset: 0x38
	private ArrayList _tables; //Field offset: 0x40
	private bool _writeHierarchy; //Field offset: 0x48

	[CalledBy(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "DoAssignments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal NewDiffgramGen(DataSet ds) { }

	[CalledBy(Type = typeof(DataSet), Member = "GetRemotingDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "CreateTableHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "DoAssignments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal NewDiffgramGen(DataTable dt, bool writeHierarchy) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "CreateTableHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "CreateTableHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void CreateTableHierarchy(DataTable dt) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void DoAssignments(ArrayList tables) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool EmptyData() { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "PolymorphismNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "PreserveSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlRootAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlWriter), typeof(XmlRootAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "XmlDataTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataStorage), Member = "IsSqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = "IsValueCustomTypeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_IsCustomType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_EncodedColumnName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "GetColumnValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 7)]
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "GetNestedParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private void GenerateRow(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void GenerateTable(DataTable table) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "get_EncodedColumnName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_RowError", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_HasErrors", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void GenerateTableErrors(DataTable table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	internal static string QualifiedName(string prefix, string name) { }

	[CalledBy(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	internal void Save(XmlWriter xmlw) { }

	[CalledBy(Type = typeof(DataSet), Member = "GetRemotingDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "SaveDiffgramData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(Hashtable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 6)]
	internal void Save(XmlWriter xmlw, DataTable table) { }

}

