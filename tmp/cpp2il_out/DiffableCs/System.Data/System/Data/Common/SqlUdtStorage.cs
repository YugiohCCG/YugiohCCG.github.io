namespace System.Data.Common;

internal sealed class SqlUdtStorage : DataStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Type type; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "INullableUDTwithoutStaticNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		internal object <GetStaticNullForUdtType>b__0(Type t) { }

	}

	private static readonly ConcurrentDictionary<Type, Object> s_typeToNull; //Field offset: 0x0
	private Object[] _values; //Field offset: 0x50
	private readonly bool _implementsIXmlSerializable; //Field offset: 0x58
	private readonly bool _implementsIComparable; //Field offset: 0x59

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SqlUdtStorage() { }

	[CalledBy(Type = typeof(DataStorage), Member = "CreateStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(StorageType)}, ReturnType = typeof(DataStorage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(bool), typeof(StorageType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public SqlUdtStorage(DataColumn column, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(object), typeof(bool), typeof(StorageType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private SqlUdtStorage(DataColumn column, Type type, object nullValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AggregateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AggregateType), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "IComparableNotImplemented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public virtual int CompareValueTo(int recordNo1, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectStorage), Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(XmlSerializer))]
	[Calls(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public virtual string ConvertObjectToXml(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectStorage), Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute)}, ReturnType = typeof(XmlSerializer))]
	[Calls(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectStorage), Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(XmlSerializer))]
	[Calls(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public virtual object ConvertXmlToObject(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectStorage), Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute)}, ReturnType = typeof(XmlSerializer))]
	[Calls(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XSDSchema), Member = "XsdtoClr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "CopyBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual object Get(int recordNo) { }

	[CallerCount(Count = 0)]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[CalledBy(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDataLoader), Member = "LoadColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static object GetStaticNullForUdtType(Type type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool IsNull(int record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "SetNullBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "StorageSetFailed", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public virtual void Set(int recordNo, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

