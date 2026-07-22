namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[ListBindable(False)]
public sealed class DataTableCollection : InternalDataCollectionBase
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataSet _dataSet; //Field offset: 0x10
	private readonly ArrayList _list; //Field offset: 0x18
	private int _defaultNameIndex; //Field offset: 0x20
	private DataTable[] _delayedAddRangeTables; //Field offset: 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x38
	private readonly int _objectID; //Field offset: 0x40

	public DataTable Item
	{
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TableOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 202
	}

	public DataTable Item
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.DataSetConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NamespaceNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 258
	}

	public DataTable Item
	{
		[CalledBy(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRelation), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataRelation))]
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 294
	}

	protected virtual ArrayList List
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal int ObjectID
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal DataTableCollection(DataSet dataSet) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataSetConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ResetIndexes", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Add(DataTable table) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ArrayAdd(DataTable table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	internal string AssignName() { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable[]), typeof(int), typeof(DataTable[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableAlreadyInTheDataSet", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableAlreadyInOtherDataSet", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DatasetConflictingName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "SetDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataTableCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(InternalDataCollectionBase), Member = "NamesEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void BaseAdd(DataTable table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable[]), typeof(int), typeof(DataTable[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "SetDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "OnRemovedTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void BaseRemove(DataTable table) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableInConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(Constraint)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableInRelation", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableNotInTheDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 38)]
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	[CalledBy(Type = typeof(DataSet), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public bool Contains(string name) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Contains(string name, bool caseSensitive) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataRelation))]
	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DataTable get_Item(string name, string tableNamespace) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataSetConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NamespaceNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DataTable get_Item(string name) { }

	[CallerCount(Count = 50)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DataTable get_Item(int index) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected virtual ArrayList get_List() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleRefTableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal DataTable GetTable(string name, string ns) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal DataTable GetTableSmart(string name, string ns) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public int IndexOf(DataTable table) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public int IndexOf(string tableName) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "AssignName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InternalDataCollectionBase), Member = "NamesEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal int InternalIndexOf(string tableName) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string MakeName(int index) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal void RegisterName(string name, string tbNamespace) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void Remove(DataTable table) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal void UnregisterName(string name) { }

}

