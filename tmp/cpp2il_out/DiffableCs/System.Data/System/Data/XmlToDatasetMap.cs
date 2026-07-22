namespace System.Data;

internal sealed class XmlToDatasetMap
{
	private sealed class TableSchemaInfo
	{
		public DataTable TableSchema; //Field offset: 0x10
		public XmlNodeIdHashtable ColumnsSchemaMap; //Field offset: 0x18

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(TableSchemaInfo))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(TableSchemaInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		public TableSchemaInfo(DataTable tableSchema) { }

	}

	private sealed class XmlNodeIdentety
	{
		public string LocalName; //Field offset: 0x10
		public string NamespaceURI; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public XmlNodeIdentety(string localName, string namespaceURI) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

	}

	[DefaultMember("Item")]
	public sealed class XmlNodeIdHashtable : Hashtable
	{
		private XmlNodeIdentety _id; //Field offset: 0x50

		public object Item
		{
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetSchemaForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 158
		}

		public object Item
		{
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetTableForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(DataTable))]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 158
		}

		public object Item
		{
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
			[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 140
		}

		public object Item
		{
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetSchemaForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
			[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetTableForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(DataTable))]
			[CallerCount(Count = 6)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 104
		}

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public XmlNodeIdHashtable(int capacity) { }

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetSchemaForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public object get_Item(XmlNode node) { }

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetTableForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public object get_Item(XmlReader dataReader) { }

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
		[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public object get_Item(DataTable table) { }

		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetSchemaForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetTableForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public object get_Item(string name) { }

	}

	private XmlNodeIdHashtable _tableSchemaMap; //Field offset: 0x10
	private TableSchemaInfo _lastTableSchemaInfo; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "ProcessXsdSchema", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "ProcessXsdSchema", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "get_EncodedColumnName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "HandleSpecialColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "HandleSpecialColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(TableSchemaInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(TableSchemaInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "GetSelfAndDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(TableSchemaInfo))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataColumn), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 37)]
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(TableSchemaInfo))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = typeof(TableSchemaInfo))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(TableSchemaInfo))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataColumn), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 37)]
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "FColumnElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetSchemaForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "get_EncodedTableName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "BuildIdentityMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataColumn), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsMappedColumn(DataColumn c) { }

}

