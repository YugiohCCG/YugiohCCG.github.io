namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase
{
	private readonly DataTable _table; //Field offset: 0x10
	private readonly ArrayList _list; //Field offset: 0x18
	private int _defaultNameIndex; //Field offset: 0x20
	private DataColumn[] _delayedAddRangeColumns; //Field offset: 0x28
	private readonly Dictionary<String, DataColumn> _columnFromName; //Field offset: 0x30
	private bool _fInClear; //Field offset: 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; //Field offset: 0x40
	private int _nColumnsImplementingIChangeTracking; //Field offset: 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; //Field offset: 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; //Field offset: 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; //Field offset: 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; //Field offset: 0x60

	public event CollectionChangeEventHandler CollectionChanged
	{
		[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	internal event CollectionChangeEventHandler ColumnPropertyChanged
	{
		[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	internal DataColumn[] ColumnsImplementingIChangeTracking
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int ColumnsImplementingIChangeTrackingCount
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int ColumnsImplementingIRevertibleChangeTrackingCount
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public DataColumn Item
	{
		[CallerCount(Count = 87)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 202
	}

	public DataColumn Item
	{
		[CallerCount(Count = 35)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 360
	}

	internal DataColumn Item
	{
		[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 173
	}

	protected virtual ArrayList List
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal DataColumnCollection(DataTable table) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.DataTableConverter", Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DataTable), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "IncrementalCloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataTable), Member = "AddForeignKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	public void Add(DataColumn column) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "RegisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataColumnCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddColumnsImplementingIChangeTrackingList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn3", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void AddAt(int index, DataColumn column) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "ArrayAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CheckIChangeTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddColumnsImplementingIChangeTrackingList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ArrayAdd(int index, DataColumn column) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddColumnsImplementingIChangeTrackingList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ArrayAdd(DataColumn column) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void ArrayRemove(DataColumn column) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string AssignName() { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AddAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(int), typeof(DataColumn[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddColumn2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionCircular", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "InitializeRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_RecordCapacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "SetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataExpression), Member = "DependsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	private void BaseAdd(DataColumn column) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(int), typeof(DataColumn[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Data.RBTree`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "SetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void BaseRemove(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool CanRegisterName(string name) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotRemoveColumn", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotRemoveExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotRemoveConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotRemoveChildKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotRemovePrimaryKey", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(DataTable), Member = "get_LiveIndexes", ReturnType = typeof(System.Collections.Generic.List`1<System.Data.Index>))]
	[Calls(Type = typeof(DataExpression), Member = "DependsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintEnumerator), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataTable), Member = "OnRemoveColumnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 50)]
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "AddColumnsImplementingIChangeTrackingList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void CheckIChangeTracking(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "SetOrdinalInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseGroupSwitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(int), typeof(DataColumn[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	public void Clear() { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool Contains(string name) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal bool Contains(string name, bool caseSensitive) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseInsensitiveNameConflict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DataColumn get_Item(string name) { }

	[CallerCount(Count = 87)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DataColumn get_Item(int index) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ProcessErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLDiffLoader), Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(DataTable&), typeof(Int32&), typeof(XmlReader)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumn), Member = "get_Namespace", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DataColumn get_Item(string name, string ns) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected virtual ArrayList get_List() { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(ForeignKeyConstraint))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(UniqueConstraint))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XMLSchema), Member = "GenUniqueColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataTable)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int IndexOf(string columnName) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataTable), Member = "GetSpecialHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InternalDataCollectionBase), Member = "NamesEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal int IndexOfCaseInsensitive(string name) { }

	[CalledBy(Type = typeof(DataColumnCollection), Member = "AssignName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "RegisterColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "UnregisterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string MakeName(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "GetSpecialHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddDuplicate2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddDuplicate3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotAddDuplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 10)]
	internal void RegisterColumnName(string name, DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionChangeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionChangeAction), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "ArrayRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "UpdatePropertyDescriptorCollectionCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_ElementColumnCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(DataColumn column) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CalledBy(Type = typeof(DataViewListener), Member = "UnregisterMetaDataEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "set_Nested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "MakeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOfCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal void UnregisterName(string name) { }

}

