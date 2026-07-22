namespace System.Data;

[DefaultProperty("DataSetName")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlRoot("DataSet")]
[XmlSchemaProvider("GetDataSetSchema")]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private static XmlSchemaComplexType s_schemaTypeForWSDL; //Field offset: 0x8
	private DataViewManager _defaultViewManager; //Field offset: 0x20
	private readonly DataTableCollection _tableCollection; //Field offset: 0x28
	private readonly DataRelationCollection _relationCollection; //Field offset: 0x30
	internal PropertyCollection _extendedProperties; //Field offset: 0x38
	private string _dataSetName; //Field offset: 0x40
	private string _datasetPrefix; //Field offset: 0x48
	internal string _namespaceURI; //Field offset: 0x50
	private bool _enforceConstraints; //Field offset: 0x58
	private bool _caseSensitive; //Field offset: 0x59
	private CultureInfo _culture; //Field offset: 0x60
	private bool _cultureUserSet; //Field offset: 0x68
	internal bool _fInReadXml; //Field offset: 0x69
	internal bool _fInLoadDiffgram; //Field offset: 0x6A
	internal bool _fTopLevelTable; //Field offset: 0x6B
	internal bool _fInitInProgress; //Field offset: 0x6C
	internal bool _fEnableCascading; //Field offset: 0x6D
	internal bool _fIsSchemaLoading; //Field offset: 0x6E
	internal string _mainTableName; //Field offset: 0x70
	private SerializationFormat _remotingFormat; //Field offset: 0x78
	private object _defaultViewManagerLock; //Field offset: 0x80
	private readonly int _objectID; //Field offset: 0x88
	internal bool _useDataSetSchemaOnly; //Field offset: 0x8C
	internal bool _udtIsWrapped; //Field offset: 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; //Field offset: 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; //Field offset: 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; //Field offset: 0xA8

	[DefaultValue(False)]
	public bool CaseSensitive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		 set { } //Length: 600
	}

	[DefaultValue(null)]
	public string DataSetName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
		[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "SetDataSetNameConflicting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "SetDataSetNameToEmpty", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 357
	}

	[DefaultValue(True)]
	public bool EnforceConstraints
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataSet), Member = "FailedEnableConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "RestoreConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 316
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 106
	}

	public CultureInfo Locale
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
		[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 354
	}

	internal string MainTableName
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[DefaultValue(null)]
	public string Namespace
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
		[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		 set { } //Length: 938
	}

	internal int ObjectID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[DefaultValue(null)]
	public string Prefix
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 276
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataRelationCollection Relations
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	public SerializationFormat RemotingFormat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
		[Calls(Type = typeof(DataTable), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 198
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public virtual ISite Site
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataTableCollection Tables
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataSetConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSetRelationCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public DataSet() { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DataSet(string dataSetName) { }

	[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(DataSet), Member = "DeserializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	protected DataSet(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataSet), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataRelation))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTable), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataTable))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 77)]
	public override DataSet Clone() { }

	[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "DeserializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "DeserializeRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "DeserializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataSet), Member = "DeserializeDataSetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRelation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 47)]
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "IsNotAllowDBNullViolated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "FailedEnableConstraints", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	internal void EnableConstraints() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal int EstimatedXmlStringSize() { }

	[CalledBy(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "EnforceConstraint", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void FailedEnableConstraints() { }

	[CalledBy(Type = typeof(DataSet), Member = "FindTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(PropertyDescriptor[]), typeof(int)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.ITypedList.GetListName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.ITypedList.GetItemProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataSet), Member = "FindTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(PropertyDescriptor[]), typeof(int)}, ReturnType = typeof(DataTable))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CaseSensitive() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_DataSetName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_EnforceConstraints() { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public PropertyCollection get_ExtendedProperties() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public CultureInfo get_Locale() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal string get_MainTableName() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_ObjectID() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public DataRelationCollection get_Relations() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SerializationFormat get_RemotingFormat() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override SchemaSerializationMode get_SchemaSerializationMode() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual ISite get_Site() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public DataTableCollection get_Tables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetRemotingDiffGram(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlIgnoreNamespaceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlSchemaSet))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal void InferSchema(XmlDocument xdoc, String[] excludedNamespaces, XmlReadMode mode) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void InitializeDerivedDataSet() { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private bool IsEmpty() { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void Merge(DataSet dataSet) { }

	[CalledBy(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3", "T4"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Merger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "InvalidMissingSchemaAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MissingSchemaAction)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 12)]
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void MoveToElement(XmlReader reader) { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool MoveToElement(XmlReader reader, int depth) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnClearFunctionCalled(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewEmptyRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "NewRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnDataRowCreated(DataRow row) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[CalledBy(Type = typeof(DataTableCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataViewSettingCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void OnRemovedTable(DataTable table) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemoveRelation(DataRelation relation) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void OnRemoveRelationHack(DataRelation relation) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnRemoveTable(DataTable table) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(MergeFailedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected private void RaisePropertyChanging(string name) { }

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ReadEndElement(XmlReader reader) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XDRSchema), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReadXDRSchema(XmlReader reader) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataSet), Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(String[]), typeof(XmlReadMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[Calls(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DataSetUnsupportedSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 65)]
	[CallsUnknownMethods(Count = 40)]
	[ContainsUnimplementedInstructions]
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(String[]), typeof(XmlReadMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(IDisposable))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DataSetUnsupportedSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 86)]
	[CallsUnknownMethods(Count = 51)]
	[ContainsUnimplementedInstructions]
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	public XmlReadMode ReadXml(XmlReader reader) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowInsertMissing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "CheckForLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLDiffLoader), Member = "LoadDiffGram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 59)]
	[CallsUnknownMethods(Count = 64)]
	private void ReadXmlDiffgram(XmlReader reader) { }

	[CalledBy(Type = typeof(DataSet), Member = "DeserializeDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat), typeof(SchemaSerializationMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(String[]), typeof(XmlReadMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DataSetUnsupportedSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 24)]
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public void ReadXmlSchema(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	protected override void ReadXmlSerializable(XmlReader reader) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "ProcessXsdSchema", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(DataSet), Member = "MoveToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public override void Reset() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal void RestoreEnforceConstraints(bool value) { }

	[CalledBy(Type = typeof(DataSet), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "SerializeExpressionColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SerializeRelations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SerializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "SerializeDataSetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 29)]
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataSet), Member = "ValidateCaseConstraint", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "SetCaseSensitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotChangeCaseLocale", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void set_CaseSensitive(bool value) { }

	[CalledBy(Type = typeof(DataSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetDataSetNameConflicting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetDataSetNameToEmpty", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	public void set_DataSetName(string value) { }

	[CalledBy(Type = typeof(DataSet), Member = "FailedEnableConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "RestoreConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataSet), Member = "EnableConstraints", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_EnforceConstraints(bool value) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_Locale(CultureInfo value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_MainTableName(string value) { }

	[CalledBy(Type = typeof(DataSet), Member = "Clone", ReturnType = typeof(DataSet))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateTableName2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTable), Member = "DoRaiseNamespaceChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "CheckCascadingNamespaceConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public void set_Namespace(string value) { }

	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "RaisePropertyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_Prefix(string value) { }

	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "set_RemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidRemotingFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationFormat)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_RemotingFormat(SerializationFormat value) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_Locale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "SerializeDataTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DataTable), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "ValidateLocaleConstraint", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 28)]
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool ShouldSerializeLocale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReader), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataSet), Member = "WriteXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(SchemaFormat), typeof(System.Converter`2<System.Type, System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriteMode)}, ReturnType = typeof(void))]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataSet), Member = "TopLevelTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DataTable[]))]
	internal DataTable[] TopLevelTables() { }

	[CalledBy(Type = typeof(DataSet), Member = "TopLevelTables", ReturnType = typeof(DataTable[]))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlWriter), typeof(DataSet), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_NestedParentsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_SelfNested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal DataTable[] TopLevelTables(bool forSchema) { }

	[CalledBy(Type = typeof(DataSet), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_CaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	internal bool ValidateCaseConstraint() { }

	[CalledBy(Type = typeof(DataSet), Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_Locale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 23)]
	internal bool ValidateLocaleConstraint() { }

	[CalledBy(Type = typeof(DataSet), Member = "SerializeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(SerializationFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSet), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDataTreeWriter), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDiffgramGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	[CalledBy(Type = typeof(DataSet), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "EnterScope", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlTreeGen), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTreeGen), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable), typeof(XmlWriter), typeof(bool), typeof(System.Converter`2<System.Type, System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataCommonEventSource), Member = "ExitScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, String> multipleTargetConverter) { }

}

