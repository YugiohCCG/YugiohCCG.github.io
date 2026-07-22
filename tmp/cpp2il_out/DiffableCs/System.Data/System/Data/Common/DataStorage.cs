namespace System.Data.Common;

internal abstract class DataStorage
{
	private static readonly Type[] s_storageClassType; //Field offset: 0x0
	private static readonly Func<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_inspectTypeForInterfaces; //Field offset: 0x8
	private static readonly ConcurrentDictionary<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_typeImplementsInterface; //Field offset: 0x10
	internal readonly DataColumn _column; //Field offset: 0x10
	internal readonly DataTable _table; //Field offset: 0x18
	internal readonly Type _dataType; //Field offset: 0x20
	internal readonly StorageType _storageTypeCode; //Field offset: 0x28
	private BitArray _dbNullBits; //Field offset: 0x30
	private readonly object _defaultValue; //Field offset: 0x38
	internal readonly object _nullValue; //Field offset: 0x40
	internal readonly bool _isCloneable; //Field offset: 0x48
	internal readonly bool _isCustomDefinedType; //Field offset: 0x49
	internal readonly bool _isStringType; //Field offset: 0x4A
	internal readonly bool _isValueType; //Field offset: 0x4B

	internal DataSetDateTime DateTimeMode
	{
		[CalledBy(Type = typeof(DateTimeStorage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 26
	}

	internal IFormatProvider FormatProvider
	{
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 29
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 165)]
	private static DataStorage() { }

	[CalledBy(Type = typeof(ObjectStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(StorageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(StorageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlBinaryStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlBytesStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlCharsStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDateTimeStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimalStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlUdtStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlUdtStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	[CalledBy(Type = typeof(BigIntegerStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt64Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt32Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt16Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SingleStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SByteStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int64Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int32Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DoubleStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecimalStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffsetStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataStorage), Member = "CreateStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(StorageType)}, ReturnType = typeof(DataStorage))]
	[CalledBy(Type = typeof(CharStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ByteStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BooleanStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int16Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(bool), typeof(StorageType)}, ReturnType = typeof(void))]
	protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	[CalledBy(Type = typeof(SqlDoubleStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlGuidStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlInt16Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlInt32Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlSingleStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlStringStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlBooleanStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(bool), typeof(StorageType)}, ReturnType = typeof(void))]
	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	[CalledBy(Type = typeof(BooleanStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CharStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DoubleStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Int64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override object Aggregate(Int32[] recordNos, AggregateType kind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public object AggregateCount(Int32[] recordNos) { }

	public abstract int Compare(int recordNo1, int recordNo2) { }

	[CalledBy(Type = typeof(BigIntegerStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SingleStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SByteStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Int64Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Int32Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DoubleStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DecimalStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffsetStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CharStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByteStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BooleanStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Int16Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected int CompareBits(int recordNo1, int recordNo2) { }

	public abstract int CompareValueTo(int recordNo1, object value) { }

	public abstract string ConvertObjectToXml(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override object ConvertValue(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	public abstract object ConvertXmlToObject(string s) { }

	public abstract void Copy(int recordNo1, int recordNo2) { }

	[CalledBy(Type = typeof(SingleStorage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlUdtStorage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[CalledBy(Type = typeof(DataColumn), Member = "CopyValueIntoStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	[CalledBy(Type = typeof(DataColumn), Member = "InsureStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SqlUdtStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(StorageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UInt16Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UInt32Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UInt64Storage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SingleStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsInvalidInstructions]
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	public abstract object Get(int recordNo) { }

	[CalledBy(Type = typeof(DateTimeStorage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DataSetDateTime get_DateTimeMode() { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[CallsUnknownMethods(Count = 1)]
	internal IFormatProvider get_FormatProvider() { }

	[CalledBy(Type = typeof(SingleStorage), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected object GetBits(int recordNo) { }

	protected abstract object GetEmptyStorage(int recordCount) { }

	[CalledBy(Type = typeof(DataColumn), Member = "GetEmptyColumnStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal object GetEmptyStorageInternal(int recordCount) { }

	[CalledBy(Type = typeof(XmlTreeGen), Member = "SetMSDataAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectStorage), Member = "VerifyIDynamicMetaObjectProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetQualifiedName(Type type) { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static StorageType GetStorageType(Type dataType) { }

	[CallerCount(Count = 0)]
	public override int GetStringLength(int record) { }

	[CalledBy(Type = typeof(XMLSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttribute[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectStorage), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectStorage), Member = "VerifyIDynamicMetaObjectProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static Type GetType(string value) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static Type GetTypeStorage(StorageType storageType) { }

	[CalledBy(Type = typeof(UInt16Storage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool HasValue(int recordNo) { }

	[CalledBy(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Tuple`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static Tuple<Boolean, Boolean, Boolean, Boolean> InspectTypeForInterfaces(Type dataType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsNull(int recordNo) { }

	[CalledBy(Type = typeof(DataColumn), Member = "GetColumnValueAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataExpression), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataExpression), Member = "IsUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumnPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumn), Member = "CheckNotAllowNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsObjectNull(object value) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsObjectSqlNull(object value) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "BinaryCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(StorageType), typeof(int), typeof(CompareInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSqlType(StorageType storageType) { }

	[CalledBy(Type = typeof(NewDiffgramGen), Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataTreeWriter), Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsSqlType(Type dataType) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	[CalledBy(Type = typeof(DataColumn), Member = "get_IsCustomType", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsValueCustomTypeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataTable), Member = "SilentlySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataColumn), typeof(DataRowVersion), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "ValidateColumnMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectStorage), Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[ContainsUnimplementedInstructions]
	internal static bool IsTypeCustomType(Type type) { }

	public abstract void Set(int recordNo, object value) { }

	[CalledBy(Type = typeof(BigIntegerStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlUdtStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SingleStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SByteStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int32Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int64Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DoubleStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecimalStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffsetStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CharStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ByteStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BooleanStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Int16Storage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(BitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitArray), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetCapacity(int capacity) { }

	[CalledBy(Type = typeof(SingleStorage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlUdtStorage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanStorage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt16Storage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt32Storage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UInt64Storage), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void SetNullBit(int recordNo, bool flag) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void SetNullStorage(BitArray nullbits) { }

	protected abstract void SetStorage(object store, BitArray nullbits) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void SetStorageInternal(object store, BitArray nullbits) { }

}

