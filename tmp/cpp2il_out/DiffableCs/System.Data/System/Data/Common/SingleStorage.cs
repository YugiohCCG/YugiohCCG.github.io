namespace System.Data.Common;

internal sealed class SingleStorage : DataStorage
{
	private Single[] _values; //Field offset: 0x50

	[CalledBy(Type = typeof(DataStorage), Member = "CreateStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(StorageType)}, ReturnType = typeof(DataStorage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(Type), typeof(object), typeof(StorageType)}, ReturnType = typeof(void))]
	public SingleStorage(DataColumn column) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "CompareBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ConvertObjectToXml(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[CallsUnknownMethods(Count = 5)]
	public virtual object ConvertValue(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	public virtual object ConvertXmlToObject(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "CopyBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual object Get(int record) { }

	[CallerCount(Count = 0)]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(DataStorage), Member = "SetNullBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual void Set(int record, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

