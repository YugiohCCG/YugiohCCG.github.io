namespace System.Data.Common;

internal sealed class SqlBooleanStorage : DataStorage
{
	private SqlBoolean[] _values; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(StorageType)}, ReturnType = typeof(void))]
	public SqlBooleanStorage(DataColumn column) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(SqlBoolean), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean), typeof(SqlBoolean)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(SqlBoolean), Member = "And", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean), typeof(SqlBoolean)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExprException), Member = "Overflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AggregateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AggregateType), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public virtual string ConvertObjectToXml(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlConvert), Member = "ConvertToSqlBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlBoolean))]
	public virtual object ConvertValue(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual object ConvertXmlToObject(string s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Get(int record) { }

	[CallerCount(Count = 0)]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool IsNull(int record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlConvert), Member = "ConvertToSqlBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlBoolean))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Set(int record, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

