namespace System.Data;

[DefaultEvent("RowChanging")]
[DefaultProperty("TableName")]
[DesignTimeVisible(False)]
[ToolboxItem(False)]
[XmlSchemaProvider("GetDataTableSchema")]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable
{
	public struct DSRowDiffIdUsageSection
	{
		private DataSet _targetDS; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void Prepare(DataSet ds) { }

	}

	public struct RowDiffIdUsageSection
	{
		private DataTable _targetTable; //Field offset: 0x0

		[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void Prepare(DataTable table) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private DataSet _dataSet; //Field offset: 0x20
	private DataView _defaultView; //Field offset: 0x28
	internal long _nextRowID; //Field offset: 0x30
	internal readonly DataRowCollection _rowCollection; //Field offset: 0x38
	internal readonly DataColumnCollection _columnCollection; //Field offset: 0x40
	private readonly ConstraintCollection _constraintCollection; //Field offset: 0x48
	private int _elementColumnCount; //Field offset: 0x50
	internal DataRelationCollection _parentRelationsCollection; //Field offset: 0x58
	internal DataRelationCollection _childRelationsCollection; //Field offset: 0x60
	internal readonly RecordManager _recordManager; //Field offset: 0x68
	internal readonly List<Index> _indexes; //Field offset: 0x70
	private List<Index> _shadowIndexes; //Field offset: 0x78
	private int _shadowCount; //Field offset: 0x80
	internal PropertyCollection _extendedProperties; //Field offset: 0x88
	private string _tableName; //Field offset: 0x90
	internal string _tableNamespace; //Field offset: 0x98
	private string _tablePrefix; //Field offset: 0xA0
	internal DataExpression _displayExpression; //Field offset: 0xA8
	internal bool _fNestedInDataset; //Field offset: 0xB0
	private CultureInfo _culture; //Field offset: 0xB8
	private bool _cultureUserSet; //Field offset: 0xC0
	private CompareInfo _compareInfo; //Field offset: 0xC8
	private CompareOptions _compareFlags; //Field offset: 0xD0
	private IFormatProvider _formatProvider; //Field offset: 0xD8
	private StringComparer _hashCodeProvider; //Field offset: 0xE0
	private bool _caseSensitive; //Field offset: 0xE8
	private bool _caseSensitiveUserSet; //Field offset: 0xE9
	internal string _encodedTableName; //Field offset: 0xF0
	internal DataColumn _xmlText; //Field offset: 0xF8
	internal DataColumn _colUnique; //Field offset: 0x100
	internal decimal _minOccurs; //Field offset: 0x108
	internal decimal _maxOccurs; //Field offset: 0x118
	internal bool _repeatableElement; //Field offset: 0x128
	private object _typeName; //Field offset: 0x130
	internal UniqueConstraint _primaryKey; //Field offset: 0x138
	internal IndexField[] _primaryIndex; //Field offset: 0x140
	private DataColumn[] _delayedSetPrimaryKey; //Field offset: 0x148
	private Index _loadIndex; //Field offset: 0x150
	private Index _loadIndexwithOriginalAdded; //Field offset: 0x158
	private Index _loadIndexwithCurrentDeleted; //Field offset: 0x160
	private int _suspendIndexEvents; //Field offset: 0x168
	private bool _inDataLoad; //Field offset: 0x16C
	private bool _schemaLoading; //Field offset: 0x16D
	private bool _enforceConstraints; //Field offset: 0x16E
	internal bool _suspendEnforceConstraints; //Field offset: 0x16F
	protected private bool fInitInProgress; //Field offset: 0x170
	private bool _inLoad; //Field offset: 0x171
	internal bool _fInLoadDiffgram; //Field offset: 0x172
	private byte _isTypedDataTable; //Field offset: 0x173
	private DataRow[] _emptyDataRowArray; //Field offset: 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; //Field offset: 0x180
	private DataRelation[] _nestedParentRelations; //Field offset: 0x188
	internal List<DataColumn> _dependentColumns; //Field offset: 0x190
	private bool _mergingData; //Field offset: 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; //Field offset: 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; //Field offset: 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; //Field offset: 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; //Field offset: 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; //Field offset: 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; //Field offset: 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; //Field offset: 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; //Field offset: 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; //Field offset: 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; //Field offset: 0x1E8
	private readonly DataRowBuilder _rowBuilder; //Field offset: 0x1F0
	internal readonly List<DataView> _delayedViews; //Field offset: 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; //Field offset: 0x200
	internal Hashtable _rowDiffId; //Field offset: 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; //Field offset: 0x210
	internal int _ukColumnPositionForInference; //Field offset: 0x218
	private SerializationFormat _remotingFormat; //Field offset: 0x21C
	private readonly int _objectID; //Field offset: 0x220

	internal bool AreIndexEventsSuspended
	{
		[CalledBy(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "get_DoListChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	public bool CaseSensitive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 163
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataRelationCollection ChildRelations
	{
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 113
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataColumnCollection Columns
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private CompareInfo CompareInfo
	{
		[CalledBy(Type = typeof(DataTable), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DataTable), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareInfo)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 97
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public ConstraintCollection Constraints
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataSet DataSet
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal string DisplayExpressionInternal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
		internal get { } //Length: 42
	}

	internal int ElementColumnCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MappingType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TableCannotAddToSimpleContent", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 69
	}

	internal string EncodedTableName
	{
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(DataTable), typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = "System.Data.XmlToDatasetMap+TableSchemaInfo")]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = "System.Data.XmlToDatasetMap+TableSchemaInfo")]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "SaveDiffgramData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 130
	}

	internal bool EnforceConstraints
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniqueConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		internal get { } //Length: 36
		[CalledBy(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
		internal set { } //Length: 60
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 115
	}

	internal IFormatProvider FormatProvider
	{
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 163
	}

	private bool IsTypedDataTable
	{
		[CalledBy(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
		[CalledBy(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataTable), Member = "OnRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
		[CalledBy(Type = typeof(DataTable), Member = "OnRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
		[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
		[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 164
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	internal List<Index> LiveIndexes
	{
		[CalledBy(Type = typeof(DataTable), Member = "RestoreIndexEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetShadowIndexes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 149
	}

	public CultureInfo Locale
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataSet), Member = "ValidateLocaleConstraint", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		 set { } //Length: 977
	}

	internal decimal MaxOccurs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 14
		[CallerCount(Count = 0)]
		internal set { } //Length: 11
	}

	internal bool MergingData
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	[DefaultValue(50)]
	public int MinimumCapacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RecordManager), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	internal decimal MinOccurs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 14
		[CallerCount(Count = 0)]
		internal set { } //Length: 11
	}

	public string Namespace
	{
		[CallerCount(Count = 140)]
		[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 121
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "CheckNamespaceValidityForNestedRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		 set { } //Length: 635
	}

	internal bool NeedColumnChangeEvents
	{
		[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 55
	}

	internal DataRelation[] NestedParentRelations
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal int NestedParentsCount
	{
		[CalledBy(Type = typeof(DataSet), Member = "TopLevelTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DataTable[]))]
		[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 11)]
		internal get { } //Length: 583
	}

	internal int ObjectID
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataRelationCollection ParentRelations
	{
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 113
	}

	[DefaultValue(null)]
	public string Prefix
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 358
	}

	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey
	{
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 103
		[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(Constraint))]
		[CalledBy(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TableForeignPrimaryKey", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
		[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstraintCollection), Member = "FindConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(Constraint))]
		[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 18)]
		 set { } //Length: 1187
	}

	internal int RecordCapacity
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 26
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	public SerializationFormat RemotingFormat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(DataSet), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSetRemotingFormat", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 113
	}

	internal Hashtable RowDiffId
	{
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	[Browsable(False)]
	public DataRowCollection Rows
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal bool SchemaLoading
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	internal bool SelfNested
	{
		[CalledBy(Type = typeof(DataSet), Member = "TopLevelTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DataTable[]))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		internal get { } //Length: 483
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public virtual ISite Site
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal bool SuspendEnforceConstraints
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string TableName
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NoTableName", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddDuplicate2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DatasetConflictingName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataTableCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
		[Calls(Type = typeof(DataColumnCollection), Member = "CanRegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataTableCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 35)]
		 set { } //Length: 1383
	}

	internal XmlQualifiedName TypeName
	{
		[CalledBy(Type = typeof(XmlTreeGen), Member = "FindTargetNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 168
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal int UKColumnPositionForInference
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	internal DataColumn XmlText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MappingType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
		[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "MultipleTextOnlyColumns", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
		[Calls(Type = typeof(ADP), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 25)]
		internal set { } //Length: 1201
	}

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataRowCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public DataTable() { }

	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public DataTable(string tableName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected DataTable(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataColumn), Member = "AddDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "HandleDependentColumnList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataExpression), typeof(DataExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XMLSchema), Member = "GenUniqueColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	[CalledBy(Type = typeof(DataRowCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "AddWithColumnEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	internal void AddRow(DataRow row, int proposedID) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	internal DataColumn AddUniqueKey() { }

	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XMLSchema), Member = "GenUniqueColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal DataColumn AddUniqueKey(int position) { }

	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "FindNestedParentRelations", ReturnType = typeof(DataRelation[]))]
	[CallsUnknownMethods(Count = 1)]
	internal void CacheNestedParent() { }

	[CalledBy(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ForeignKeyConstraintEnumerator), Member = "GetForeignKeyConstraint", ReturnType = typeof(ForeignKeyConstraint))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CheckForClosureOnExpressionTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckForClosureOnExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	[CalledBy(Type = typeof(DataTable), Member = "CheckNamespaceValidityForNestedRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InValidNestedRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "CheckNamespaceValidityForNestedParentRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void CheckNotModifying(DataRow row) { }

	[CalledBy(Type = typeof(DataSet), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void Clear() { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayClear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_RBTreeNodeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_rowID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CheckCanClearParentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraintEnumerator), Member = "GetForeignKeyConstraint", ReturnType = typeof(ForeignKeyConstraint))]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTableClearEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "OnClearFunctionCalled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(RecordManager), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 31)]
	internal void Clear(bool clearAll) { }

	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "Clone", ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal DataTable Clone(DataSet cloneDS) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataTable))]
	public override DataTable Clone() { }

	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "IncrementalCloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSetRemotingFormat", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(ForeignKeyConstraint))]
	[Calls(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(UniqueConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(UniqueConstraint))]
	[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(RecordManager), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 41)]
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	[CalledBy(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CascadeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void CommitRow(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DataTable), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlStringStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DataTable), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int Compare(string s1, string s2) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRowBitPattern", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(XmlToDatasetMap), Member = "IsMappedColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoIncrement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	internal DataRow CreateEmptyRow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	protected override DataTable CreateInstance() { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	[CalledBy(Type = typeof(DataTable), Member = "CheckForClosureOnExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	[CalledBy(Type = typeof(DataRow), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyDeleted", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	internal void DeleteRow(DataRow row) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 77)]
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	[CalledBy(Type = typeof(DataTable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode)}, ReturnType = typeof(XmlReadMode))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRowBitPattern", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "SetRowCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ConvertToRowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_rowID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "SetStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataSet), Member = "OnDataRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 41)]
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrementStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrementSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Caption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrementCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_DateTimeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSetDateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_SimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RecordManager), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 23)]
	internal void DoRaiseNamespaceChange() { }

	[CalledBy(Type = typeof(DataTable), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RestoreConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "EnforceConstraint", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	internal void EnableConstraints() { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataExpression), Member = "IsTableAggregate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataExpression), Member = "HasLocalAggregate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 5)]
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void EvaluateDependentExpressions(DataColumn column) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataExpression), Member = "IsTableAggregate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataExpression), Member = "Evaluate", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void EvaluateExpressions(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataExpression), Member = "HasLocalAggregate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal void EvaluateExpressions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Range), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Range), Member = "get_Min", ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsUnknownMethods(Count = 1)]
	internal DataRow FindByIndex(Index ndx, Object[] key) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Range), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Range), Member = "get_Min", ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	[CalledBy(Type = typeof(DataTable), Member = "CacheNestedParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private DataRelation[] FindNestedParentRelations() { }

	[CalledBy(Type = typeof(DataView), Member = "get_Sort", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.get_IsSorted", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal string FormatSortString(IndexField[] indexDesc) { }

	[CalledBy(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FreeRecord(ref int record) { }

	[CalledBy(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "get_DoListChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal bool get_AreIndexEventsSuspended() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CaseSensitive() { }

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public DataRelationCollection get_ChildRelations() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DataColumnCollection get_Columns() { }

	[CalledBy(Type = typeof(DataTable), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private CompareInfo get_CompareInfo() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ConstraintCollection get_Constraints() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DataSet get_DataSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
	internal string get_DisplayExpressionInternal() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_ElementColumnCount() { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(DataTable), typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeIdHashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlNameTable)}, ReturnType = "System.Data.XmlToDatasetMap+TableSchemaInfo")]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataTable)}, ReturnType = "System.Data.XmlToDatasetMap+TableSchemaInfo")]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "GetColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "SaveDiffgramData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string get_EncodedTableName() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	internal bool get_EnforceConstraints() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public PropertyCollection get_ExtendedProperties() { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal IFormatProvider get_FormatProvider() { }

	[CalledBy(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRowArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataTable), Member = "get_NeedColumnChangeEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "OnRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "OnRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IsTypedDataTable() { }

	[CalledBy(Type = typeof(DataTable), Member = "RestoreIndexEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetShadowIndexes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal List<Index> get_LiveIndexes() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public CultureInfo get_Locale() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal decimal get_MaxOccurs() { }

	[CallerCount(Count = 0)]
	internal bool get_MergingData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_MinimumCapacity() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal decimal get_MinOccurs() { }

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_Namespace() { }

	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal bool get_NeedColumnChangeEvents() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DataRelation[] get_NestedParentRelations() { }

	[CalledBy(Type = typeof(DataSet), Member = "TopLevelTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DataTable[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal int get_NestedParentsCount() { }

	[CallerCount(Count = 0)]
	internal int get_ObjectID() { }

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public DataRelationCollection get_ParentRelations() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataColumn[] get_PrimaryKey() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_RecordCapacity() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SerializationFormat get_RemotingFormat() { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Hashtable get_RowDiffId() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public DataRowCollection get_Rows() { }

	[CallerCount(Count = 0)]
	internal bool get_SchemaLoading() { }

	[CalledBy(Type = typeof(DataSet), Member = "TopLevelTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DataTable[]))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	internal bool get_SelfNested() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual ISite get_Site() { }

	[CallerCount(Count = 0)]
	internal bool get_SuspendEnforceConstraints() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public string get_TableName() { }

	[CalledBy(Type = typeof(XmlTreeGen), Member = "FindTargetNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlQualifiedName get_TypeName() { }

	[CallerCount(Count = 0)]
	internal int get_UKColumnPositionForInference() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DataColumn get_XmlText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterUpgradeableReadLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitUpgradeableReadLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(DataView), Member = "GetFindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataView), Member = "UpdateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "ParseSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckNamespaceValidityForNestedRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal List<DataViewListener> GetListeners() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataRowView), Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.ITypedList.GetItemProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationPropertyDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "get_HasErrors", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_RowError", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnsInError", ReturnType = typeof(DataColumn[]))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	protected override Type GetRowType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override XmlSchema GetSchema() { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringComparer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(StringComparer))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetSpecialHashCode(string name) { }

	[CalledBy(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal int IndexOf(string s1, string s2) { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "InsertRecordToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal Int32[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyInTheCollection", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowEmpty", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RaiseRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[Calls(Type = typeof(DataRow), Member = "set_rowID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyInOtherCollection", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 18)]
	internal void InsertRow(DataRow row, long proposedID) { }

	[CalledBy(Type = typeof(DataTable), Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRow), Member = "BeginEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_rowID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "CheckColumnConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "ResetLastChangedColumn", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyInTheCollection", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyInOtherCollection", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsEmptyXml(XmlReader reader) { }

	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsNamespaceInherited() { }

	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsSuffix(string s1, string s2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	public void Merge(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3", "T4"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Merger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "InvalidMissingSchemaAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MissingSchemaAction)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 12)]
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "get_HasErrors", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnsInError", ReturnType = typeof(DataColumn[]))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "get_RowError", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "ClearErrors", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "ImportRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataSet), Member = "OnDataRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetMergeRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(int), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "GetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool MoveToElement(XmlReader reader, int depth) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessDiffs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataSet), Member = "OnDataRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DataRow NewEmptyRow() { }

	[CalledBy(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int NewRecord(int sourceRecord) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int NewRecord() { }

	[CalledBy(Type = typeof(DataTable), Member = "NewUninitializedRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "AddWithColumnEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "OnDataRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal DataRow NewRow(int record) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "OnDataRowCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableNewRowEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public DataRow NewRow() { }

	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(RecordManager), Member = "GrowRecordCapacity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected private DataRow[] NewRowArray(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTableNewRowEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void NewRowCreated(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowBuilder)}, ReturnType = typeof(void))]
	protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int NewUninitializedRecord() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecordManager), Member = "NewRecordBase", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsUnknownMethods(Count = 1)]
	private DataRow NewUninitializedRow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private override void OnColumnChanged(DataColumnChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private override void OnColumnChanging(DataColumnChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemoveColumn(DataColumn column) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnRemoveColumnInternal(DataColumn column) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnRowChanged(DataRowChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnRowChanging(DataRowChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnRowDeleted(DataRowChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnRowDeleting(DataRowChangeEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnTableCleared(DataTableClearEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnTableClearing(DataTableClearEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnTableNewRow(DataTableNewRowEventArgs e) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataView), Member = "set_Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "CheckSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidSortString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	internal IndexField[] ParseSortString(string sortString) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void RaisePropertyChanging(string name) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "CheckColumnConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[Calls(Type = typeof(DataTable), Member = "CascadeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_IsTypedDataTable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRowChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ReadEndElement(XmlReader reader) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadXDRSchema(XmlReader reader) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RestoreConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "IsEmptyXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RowDiffIdUsageSection), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DataTableInferenceNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DataSetUnsupportedSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 79)]
	[CallsUnknownMethods(Count = 47)]
	[ContainsUnimplementedInstructions]
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowInsertMissing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallsUnknownMethods(Count = 17)]
	private void ReadXmlDiffgram(XmlReader reader) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CloneHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(Hashtable)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataRelation))]
	[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableNotFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataSet), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTableCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CreateRelationList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>), typeof(System.Collections.Generic.List`1<System.Data.DataRelation>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 72)]
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	protected override void ReadXmlSerializable(XmlReader reader) { }

	[CalledBy(Type = typeof(XmlDataLoader), Member = "ProcessXsdSchema", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "RowErrorChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "ClearErrors", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "ClearError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal void RecordChanged(int record) { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal void RecordChanged(Int32[] oldIndex, Int32[] newIndex) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	[CalledBy(Type = typeof(DataColumn), Member = "RemoveDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "HandleDependentColumnList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataExpression), typeof(DataExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "DeleteRecordFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal Int32[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	[CalledBy(Type = "Mono.Unity.UnityTls+unitytls_interface_struct+unitytls_x509verify_explicit_ca_t", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ForeignKeyConstraintEnumerator), Member = "GetForeignKeyConstraint", ReturnType = typeof(ForeignKeyConstraint))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CheckCanRemoveParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_rowID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowAlreadyRemoved", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void RemoveRow(DataRow row, bool check) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRelationCollection), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ResetConstraints() { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	internal void ResetIndexes() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ResetIndexes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal void ResetInternalIndexes(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal void RestoreIndexEvents(bool forceReset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreShadowIndexes() { }

	[CalledBy(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "CancelEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void RollbackRow(DataRow row) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(UniqueConstraint), Member = "get_IsPrimaryKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 4)]
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	[CalledBy(Type = typeof(DataTable), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "GetXmlSchemaForRemoting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "GetRemotingDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowState)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataTable), Member = "GetRowAndColumnErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hashtable), typeof(Hashtable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "CopyValuesIntoStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(ArrayList), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "GetEmptyColumnStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRowCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoIncrementCurrent", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "get_Caption", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoIncrementSeed", ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoIncrementStep", ReturnType = typeof(long))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoIncrement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "SerializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataTable), Member = "CheckForClosureOnExpressionTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotRemoteDataTable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public void set_CaseSensitive(bool value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableCannotAddToSimpleContent", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void set_ElementColumnCount(int value) { }

	[CalledBy(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	internal void set_EnforceConstraints(bool value) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "ValidateLocaleConstraint", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void set_Locale(CultureInfo value) { }

	[CallerCount(Count = 0)]
	internal void set_MaxOccurs(decimal value) { }

	[CallerCount(Count = 0)]
	internal void set_MergingData(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecordManager), Member = "set_MinimumCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_MinimumCapacity(int value) { }

	[CallerCount(Count = 0)]
	internal void set_MinOccurs(decimal value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "GetInheritedNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CheckNamespaceValidityForNestedRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void set_Namespace(string value) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_Prefix(string value) { }

	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TableForeignPrimaryKey", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public void set_PrimaryKey(DataColumn[] value) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSetRemotingFormat", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public void set_RemotingFormat(SerializationFormat value) { }

	[CallerCount(Count = 0)]
	internal void set_SuspendEnforceConstraints(bool value) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "RegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "CanRegisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DatasetConflictingName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddDuplicate2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NoTableName", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 35)]
	public void set_TableName(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_TypeName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	internal void set_UKColumnPositionForInference(int value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MultipleTextOnlyColumns", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	internal void set_XmlText(DataColumn value) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = "CheckConstraint", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void SetDataSet(DataSet dataSet) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetKeyValues(DataKey key, Object[] keyValues, int record) { }

	[CalledBy(Type = "Mono.Unity.UnityTls+unitytls_interface_struct+unitytls_x509verify_explicit_ca_t", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Locale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringComparer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(StringComparer))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = "CheckConstraint", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 28)]
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "SetOldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	[CalledBy(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "SetNewRecordWorker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false) { }

	[CalledBy(Type = typeof(DataTable), Member = "SetMergeRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(int), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeleteRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RollbackRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetNewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(DataRowAction), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "ResetLastChangedColumn", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "set_LastChangedColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRowCollection), Member = "ArrayInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataTable), Member = "RaiseRowChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[Calls(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "CheckInTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	[CalledBy(Type = typeof(DataTable), Member = "SetMergeRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int), typeof(int), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CommitRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataRow), Member = "CheckInTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(RecordManager), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataViewRowState))]
	[Calls(Type = typeof(DataTable), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[CallsUnknownMethods(Count = 1)]
	private void SetShadowIndexes() { }

	[CalledBy(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ShadowIndexCopy() { }

	[CallerCount(Count = 0)]
	internal bool ShouldSerializeCaseSensitive() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool ShouldSerializeLocale() { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataStorage), Member = "IsTypeCustomType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RemoveRecordFromIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(DataColumn), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "InsertRecordToIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "ResetLastChangedColumn", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SuspendIndexEvents() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "OnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "OnColumnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "RemoveCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdatePropertyDescriptorCollectionCache() { }

	[CalledBy(Type = typeof(DataColumn), Member = "CheckColumnConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	[CalledBy(Type = typeof(DataTable), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSerializeDataTableWithEmptyName", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 16)]
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	[CalledBy(Type = typeof(DataTable), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSerializeDataTableWithEmptyName", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CanNotSerializeDataTableHierarchy", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable), typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "CheckForClosureOnExpressionTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "CreateTableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

}

