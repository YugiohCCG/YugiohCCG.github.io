namespace System.Data;

internal sealed class XmlDataTreeWriter
{
	private XmlWriter _xmlw; //Field offset: 0x10
	private DataSet _ds; //Field offset: 0x18
	private DataTable _dt; //Field offset: 0x20
	private ArrayList _dTables; //Field offset: 0x28
	private DataTable[] _topLevelTables; //Field offset: 0x30
	private bool _fFromTable; //Field offset: 0x38
	private bool _isDiffgram; //Field offset: 0x39
	private Hashtable _rowsOrder; //Field offset: 0x40
	private bool _writeHierarchy; //Field offset: 0x48

	[CalledBy(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "TopLevelTables", ReturnType = typeof(DataTable[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal XmlDataTreeWriter(DataSet ds) { }

	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "CreateToplevelTables", ReturnType = typeof(DataTable[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy) { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "CreateTablesHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void CreateTablesHierarchy(DataTable dt) { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	private DataTable[] CreateToplevelTables() { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private ArrayList GetNestedChildRelations(DataRow row) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool PreserveSpace(object value) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRow), Member = "get_HasErrors", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_RowError", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool RowHasErrors(DataRow row) { }

	[CalledBy(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MultipleParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "GetNestedParentCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable), typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "TopLevelTables", ReturnType = typeof(DataTable[]))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 30)]
	internal void Save(XmlWriter xw, bool writeSchema) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "GetNestedParentCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MultipleParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 24)]
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "SaveDiffgramData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataStorage), Member = "IsSqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTreeGen), Member = "XmlDataTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlWriter), typeof(XmlRootAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlRootAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "GetNestedChildRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "PolymorphismNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "PreserveSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = "get_IsCustomType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_EncodedColumnName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTreeGen), Member = "ValidateColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "RowHasErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "IsValueCustomTypeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 60)]
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

}

