namespace System.Data;

[DefaultMember("Item")]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
[ToolboxItem(False)]
public class DataColumn : MarshalByValueComponent
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private bool _allowNull; //Field offset: 0x20
	private string _caption; //Field offset: 0x28
	private string _columnName; //Field offset: 0x30
	private Type _dataType; //Field offset: 0x38
	private StorageType _storageType; //Field offset: 0x40
	internal object _defaultValue; //Field offset: 0x48
	private DataSetDateTime _dateTimeMode; //Field offset: 0x50
	private DataExpression _expression; //Field offset: 0x58
	private int _maxLength; //Field offset: 0x60
	private int _ordinal; //Field offset: 0x64
	private bool _readOnly; //Field offset: 0x68
	internal Index _sortIndex; //Field offset: 0x70
	internal DataTable _table; //Field offset: 0x78
	private bool _unique; //Field offset: 0x80
	internal MappingType _columnMapping; //Field offset: 0x84
	internal int _hashCode; //Field offset: 0x88
	internal int _errors; //Field offset: 0x8C
	private bool _isSqlType; //Field offset: 0x90
	private bool _implementsINullable; //Field offset: 0x91
	private bool _implementsIChangeTracking; //Field offset: 0x92
	private bool _implementsIRevertibleChangeTracking; //Field offset: 0x93
	private bool _implementsIXMLSerializable; //Field offset: 0x94
	private bool _defaultValueIsNull; //Field offset: 0x95
	internal List<DataColumn> _dependentColumns; //Field offset: 0x98
	internal PropertyCollection _extendedProperties; //Field offset: 0xA0
	private DataStorage _storage; //Field offset: 0xA8
	private AutoIncrementValue _autoInc; //Field offset: 0xB0
	internal string _columnUri; //Field offset: 0xB8
	private string _columnPrefix; //Field offset: 0xC0
	internal string _encodedColumnName; //Field offset: 0xC8
	internal SimpleType _simpleType; //Field offset: 0xD0
	private readonly int _objectID; //Field offset: 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0xE8

	[DefaultValue(True)]
	public bool AllowDBNull
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataTable), Member = "get_EnforceConstraints", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 341
	}

	internal AutoIncrementValue AutoInc
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(AutoIncrementBigInteger), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 247
	}

	[DefaultValue(False)]
	[RefreshProperties(RefreshProperties::All (1))]
	public bool AutoIncrement
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		 get { } //Length: 25
		[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "IsAutoIncrementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementCannotSetIfHasData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementAndDefaultValue", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementAndExpression", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		 set { } //Length: 474
	}

	internal object AutoIncrementCurrent
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 73
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 410
	}

	[DefaultValue(0)]
	public long AutoIncrementSeed
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 37
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 244
	}

	[DefaultValue(1)]
	public long AutoIncrementStep
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 40
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 251
	}

	public string Caption
	{
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 17
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 192
	}

	[DefaultValue(MappingType::Element (1))]
	public override MappingType ColumnMapping
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn3", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetSimpleContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 717
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string ColumnName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumnCollection), Member = "OnColumnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNameRequired", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 19)]
		 set { } //Length: 1019
	}

	internal bool Computed
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	internal DataExpression DataExpression
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[DefaultValue(typeof(string))]
	[RefreshProperties(RefreshProperties::All (1))]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DataColumn), Member = "IsAutoIncrementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CantChangeDataType", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ExprException), Member = "UnsupportedDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetSimpleContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnTypeNotSupported", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NullDataType", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnsTypeMismatch", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(SqlConvert), Member = "ConvertToSqlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlString))]
		[Calls(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(DataRelation), Member = "get_ParentKey", ReturnType = typeof(DataKey))]
		[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataKey), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
		[Calls(Type = typeof(DataStorage), Member = "ImplementsINullableValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
		[Calls(Type = typeof(SimpleType), Member = "CreateSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(SimpleType))]
		[CallsDeduplicatedMethods(Count = 30)]
		[CallsUnknownMethods(Count = 35)]
		 set { } //Length: 2819
	}

	[DefaultValue(DataSetDateTime::UnspecifiedLocal (3))]
	[RefreshProperties(RefreshProperties::All (1))]
	public DataSetDateTime DateTimeMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CantChangeDateTimeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSetDateTime), typeof(DataSetDateTime)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetDateTimeModeForNonDateTimeColumns", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidDateTimeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSetDateTime)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 366
	}

	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "InitializeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
		[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 324
		[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueColumnDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueAndAutoIncrement", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 745
	}

	internal bool DefaultValueIsNull
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	internal string EncodedColumnName
	{
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 127
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	public string Expression
	{
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CheckForClosureOnExpressionTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(DataTable), Member = "SerializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
		 get { } //Length: 73
		[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionCircular", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndUnique", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndReadOnly", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Constraint)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataColumn), Member = "InitializeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(DataTable), Member = "get_RecordCapacity", ReturnType = typeof(int))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "HandleDependentColumnList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataExpression), typeof(DataExpression)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataExpression), Member = "DependsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "set_ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
		[Calls(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 39)]
		 set { } //Length: 1592
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 115
	}

	internal IFormatProvider FormatProvider
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		internal get { } //Length: 93
	}

	internal bool HasData
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 12
	}

	internal bool ImplementsIChangeTracking
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool ImplementsINullable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool ImplementsIRevertibleChangeTracking
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool ImplementsIXMLSerializable
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	internal bool IsCustomType
	{
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DataStorage), Member = "IsTypeCustomType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		internal get { } //Length: 104
	}

	internal bool IsSqlType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool IsValueType
	{
		[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 30
	}

	internal object Item
	{
		[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(DataRowView), Member = "GetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(NameNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 42
		[CalledBy(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
		[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[Calls(Type = typeof(DataRow), Member = "set_LastChangedColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "SetFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataColumn), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		internal set { } //Length: 399
	}

	internal CultureInfo Locale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		internal get { } //Length: 94
	}

	[DefaultValue(-1)]
	public int MaxLength
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetMaxLength2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetMaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(int)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "HasToBeStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(SimpleType), Member = "ConvertToAnnonymousSimpleType", ReturnType = typeof(void))]
		[Calls(Type = typeof(SimpleType), Member = "IsPlainString", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SimpleType), Member = "CreateLimitedStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SimpleType))]
		[Calls(Type = typeof(DataColumn), Member = "CheckMaxLength", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_EnforceConstraints", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 17)]
		 set { } //Length: 978
	}

	public string Namespace
	{
		[CalledBy(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataColumn), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlToDatasetMap), Member = "HandleSpecialColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
		 get { } //Length: 63
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
		[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 374
	}

	internal int ObjectID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public int Ordinal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	public string Prefix
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 358
	}

	[DefaultValue(False)]
	public bool ReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnlyAndExpression", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 218
	}

	internal SimpleType SimpleType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 88
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Index SortIndex
	{
		[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "CheckUnique", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
		[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private get { } //Length: 224
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public DataTable Table
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public bool Unique
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(ConstraintCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
		[Calls(Type = typeof(Index), Member = "CheckUnique", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "UniqueAndExpression", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NonUniqueValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 22)]
		 set { } //Length: 1044
	}

	internal string XmlDataType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	public DataColumn() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	public DataColumn(string columnName, Type dataType) { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataTable), Member = "AddForeignKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnTypeNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "ImplementsINullableValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object), typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleType), Member = "CreateSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(SimpleType))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public DataColumn(string columnName, Type dataType, string expr, MappingType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "AddDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	[CalledBy(Type = typeof(DataTable), Member = "InsertRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(long), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RaiseRowChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowChangeEventArgs), typeof(DataRow), typeof(DataRowAction), typeof(bool)}, ReturnType = typeof(DataRowChangeEventArgs))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "UpdatingCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "LongerThanMaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetCurrentRecordNo", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	internal bool CheckMaxLength() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "LongerThanMaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void CheckMaxLength(DataRow dr) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "IsKeyInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	protected private void CheckNotAllowNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetDefaultRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void CheckNullable(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "CheckUnique", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NonUniqueValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void CheckUnique() { }

	[CalledBy(Type = typeof(DataTable), Member = "IncrementalCloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AutoIncrementBigInteger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	internal DataColumn Clone() { }

	[CalledBy(Type = typeof(DataKey), Member = "RecordsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "CompareRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int Compare(int record1, int record2) { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "CompareRecordToKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int CompareValueTo(int record1, object value) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ConvertObjectToXml(object value) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object ConvertValue(object value) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "SetRowValueFromXmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object ConvertXmlToObject(string s) { }

	[CalledBy(Type = typeof(DataTable), Member = "NewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	[CalledBy(Type = typeof(DataRow), Member = "CopyValuesIntoStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(ArrayList), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataStorage), Member = "CopyValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	[CalledBy(Type = typeof(RecordManager), Member = "FreeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void FreeRecord(int record) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_AllowDBNull() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrementStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AutoIncrementBigInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal AutoIncrementValue get_AutoInc() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTopMostTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	public bool get_AutoIncrement() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal object get_AutoIncrementCurrent() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public long get_AutoIncrementSeed() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public long get_AutoIncrementStep() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public string get_Caption() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override MappingType get_ColumnMapping() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_ColumnName() { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_Computed() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal DataExpression get_DataExpression() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public Type get_DataType() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public DataSetDateTime get_DateTimeMode() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "InitializeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public object get_DefaultValue() { }

	[CallerCount(Count = 0)]
	internal bool get_DefaultValueIsNull() { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string get_EncodedColumnName() { }

	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "CheckForClosureOnExpressionTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataTable>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "AddColumnProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
	public string get_Expression() { }

	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public PropertyCollection get_ExtendedProperties() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	internal IFormatProvider get_FormatProvider() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_ImplementsIChangeTracking() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_ImplementsINullable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	[CallerCount(Count = 0)]
	internal bool get_ImplementsIXMLSerializable() { }

	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataStorage), Member = "IsTypeCustomType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	internal bool get_IsCustomType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsSqlType() { }

	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsValueType() { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataRowView), Member = "GetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NameNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object get_Item(int record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	internal CultureInfo get_Locale() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_MaxLength() { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "AddColumnSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(DataColumn), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlToDatasetMap), Member = "HandleSpecialColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlNameTable), typeof(XmlNodeIdHashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateTableErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 46)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Ordinal() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ReadOnly() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal SimpleType get_SimpleType() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Unique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckUnique", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "AddRef", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Index get_SortIndex() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public DataTable get_Table() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Unique() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_XmlDataType() { }

	[CalledBy(Type = typeof(AggregateNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(AggregateNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal object GetAggregateValue(Int32[] records, AggregateType kind) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallsUnknownMethods(Count = 1)]
	private DataRow GetDataRow(int index) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "GetEmptyStorageInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal object GetEmptyColumnStore(int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetStringLength(int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RemoveDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "AddDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

	[CalledBy(Type = typeof(DataTable), Member = "NewRecord", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "CreateEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataColumn), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void Init(int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void InitializeRecord(int record) { }

	[CalledBy(Type = typeof(DataColumn), Member = "GetColumnValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataColumn), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataColumn), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlWriter), typeof(XmlRootAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "GetEmptyColumnStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataStorage), Member = "CreateStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(StorageType)}, ReturnType = typeof(DataStorage))]
	[CallsUnknownMethods(Count = 1)]
	private void InsureStorage() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void InternalUnique(bool value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 9)]
	internal static bool IsAutoIncrementType(Type dataType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataKey), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRelation), Member = "get_ParentKey", ReturnType = typeof(DataKey))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsInRelation() { }

	[CalledBy(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlString), Member = "get_Value", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MaxLengthViolationText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal bool IsMaxLengthViolated() { }

	[CalledBy(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "FindRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "SetColumnError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsNotAllowDBNullViolated() { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "IsTypeCustomType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsValueCustomTypeInstance(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void OnSetDataSet() { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected private void RaisePropertyChanging(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "RemoveDependentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "get_EnforceConstraints", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_AllowDBNull(bool value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "IsAutoIncrementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementCannotSetIfHasData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementAndDefaultValue", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementAndExpression", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void set_AutoIncrement(bool value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_AutoIncrementCurrent(object value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_AutoIncrementSeed(long value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_AutoIncrementStep(long value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Caption(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn3", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetSimpleContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public override void set_ColumnMapping(MappingType value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNameRequired", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "OnColumnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public void set_ColumnName(string value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(DataKey), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(SqlConvert), Member = "ConvertToSqlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlString))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataStorage), Member = "ImplementsINullableValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(SimpleType), Member = "CreateSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(SimpleType))]
	[Calls(Type = typeof(DataRelation), Member = "get_ParentKey", ReturnType = typeof(DataKey))]
	[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnsTypeMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullDataType", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnTypeNotSupported", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetSimpleContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "UnsupportedDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CantChangeDataType", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[Calls(Type = typeof(DataColumn), Member = "set_AutoIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "IsAutoIncrementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 35)]
	public void set_DataType(Type value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CantChangeDateTimeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSetDateTime), typeof(DataSetDateTime)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetDateTimeModeForNonDateTimeColumns", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidDateTimeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSetDateTime)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void set_DateTimeMode(DataSetDateTime value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumn), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueAndAutoIncrement", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DefaultValueColumnDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void set_DefaultValue(object value) { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataColumn), Member = "set_ReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataExpression), Member = "DependsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "HandleDependentColumnList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataExpression), typeof(DataExpression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "ResetInternalIndexes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndReadOnly", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "get_RecordCapacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "InitializeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Constraint)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionAndUnique", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionCircular", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 39)]
	public void set_Expression(string value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "set_ItemArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "CopyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "set_LastChangedColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataColumn), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal void set_Item(int record, object value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_EnforceConstraints", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "CheckMaxLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleType), Member = "IsPlainString", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "ConvertToAnnonymousSimpleType", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "HasToBeStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetMaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotSetMaxLength2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SimpleType), Member = "CreateLimitedStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SimpleType))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public void set_MaxLength(int value) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumn), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_Namespace(string value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_Prefix(string value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0", "T1"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ReadOnlyAndExpression", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	public void set_ReadOnly(bool value) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal void set_SimpleType(SimpleType value) { }

	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ConstraintCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_SortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "CheckUnique", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UniqueAndExpression", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NonUniqueValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	public void set_Unique(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_XmlDataType(string value) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "GrowRecordCapacity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RecordManager), Member = "set_RecordCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleType), Member = "CreateLimitedStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SimpleType))]
	[Calls(Type = typeof(SimpleType), Member = "CanHaveMaxLength", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "IsPlainString", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "ConvertToAnnonymousSimpleType", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SetMaxLengthSimpleType() { }

	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "ArrayRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(int), typeof(DataColumn[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(UniqueConstraint))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniqueConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetOrdinalInternal(int ordinal) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "SetStorageInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetStorage(object store, BitArray nullbits) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataExpression), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(UniqueConstraint))]
	[Calls(Type = typeof(ConstraintCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal void SetTable(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RecordManager), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "set_LastChangedColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataColumn), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void SetValue(int record, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeLimiter), Member = "EnsureTypeIsAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeLimiter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "ImplementsInterfaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type), typeof(Boolean&), typeof(Boolean&), typeof(Boolean&), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlUdtStorage), Member = "GetStaticNullForUdtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateColumnType(Type type, StorageType typeCode) { }

}

