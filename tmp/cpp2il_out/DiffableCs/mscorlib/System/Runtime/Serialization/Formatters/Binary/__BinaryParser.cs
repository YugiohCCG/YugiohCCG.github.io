namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryParser
{
	private static Encoding encoding; //Field offset: 0x0
	internal static MessageEnd messageEnd; //Field offset: 0x8
	internal ObjectReader objectReader; //Field offset: 0x10
	internal Stream input; //Field offset: 0x18
	internal long topId; //Field offset: 0x20
	internal long headerId; //Field offset: 0x28
	internal SizedArray objectMapIdTable; //Field offset: 0x30
	internal SizedArray assemIdToAssemblyTable; //Field offset: 0x38
	internal SerStack stack; //Field offset: 0x40
	internal BinaryTypeEnum expectedType; //Field offset: 0x48
	internal object expectedTypeInformation; //Field offset: 0x50
	internal ParseRecord PRS; //Field offset: 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; //Field offset: 0x60
	private BinaryReader dataReader; //Field offset: 0x68
	private SerStack opPool; //Field offset: 0x70
	private BinaryObject binaryObject; //Field offset: 0x78
	private BinaryObjectWithMap bowm; //Field offset: 0x80
	private BinaryObjectWithMapTyped bowmt; //Field offset: 0x88
	internal BinaryObjectString objectString; //Field offset: 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; //Field offset: 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0xA0
	private Byte[] byteBuffer; //Field offset: 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0xB0
	internal MemberReference memberReference; //Field offset: 0xB8
	internal ObjectNull objectNull; //Field offset: 0xC0

	internal SizedArray AssemIdToAssemblyTable
	{
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 203
	}

	internal SizedArray ObjectMapIdTable
	{
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 203
	}

	internal ParseRecord prs
	{
		[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(RuntimeMarshal), Member = "FreeAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName&), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 382
	}

	internal BinaryAssemblyInfo SystemAssemblyInfo
	{
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 193
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static __BinaryParser() { }

	[CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal __BinaryParser(Stream stream, ObjectReader objectReader) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SizedArray get_AssemIdToAssemblyTable() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SizedArray get_ObjectMapIdTable() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(RuntimeMarshal), Member = "FreeAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal ParseRecord get_prs() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SerStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ObjectProgress), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectProgress), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private ObjectProgress GetOp() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PutOp(ObjectProgress op) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectProgress)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Converter), Member = "IsWriteAsByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
	[Calls(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 41)]
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Converter), Member = "TypeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Converter), Member = "CreatePrimitiveArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void ReadArrayAsBytes(ParseRecord pr) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectReader), Member = "CrossAppDomainArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void ReadBegin() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool ReadBoolean() { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal byte ReadByte() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadBytes(Byte[] byteA, int offset, int size) { }

	[CalledBy(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Byte[] ReadBytes(int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal char ReadChar() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Char[] ReadChars(int length) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectReader), Member = "CrossAppDomainArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal void ReadCrossAppDomainMap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "FromBinaryRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal DateTime ReadDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal decimal ReadDecimal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal double ReadDouble() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void ReadEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal short ReadInt16() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(__BinaryParser), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryAssembly), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryCrossAppDomainAssembly), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObject), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectString), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryCrossAppDomainString), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryCrossAppDomainMap), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberReference), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectNull), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser), typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int ReadInt32() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal long ReadInt64() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberPrimitiveTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(Converter), Member = "ToComType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Converter), Member = "ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	private void ReadMemberPrimitiveTyped() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberPrimitiveUnTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(Converter), Member = "ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	private void ReadMemberPrimitiveUnTyped() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void ReadMemberReference() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void ReadMessageEnd() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo&), typeof(Object[]&)}, ReturnType = typeof(ReadObjectInfo))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 33)]
	private void ReadObject() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectNull), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser), typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectProgress), Member = "ArrayCountIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectReader), Member = "CrossAppDomainArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 47)]
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo&), typeof(Object[]&)}, ReturnType = typeof(ReadObjectInfo))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(String[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo)}, ReturnType = typeof(ObjectMap))]
	[Calls(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryAssemblyInfo), typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 43)]
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo&), typeof(Object[]&)}, ReturnType = typeof(ReadObjectInfo))]
	[Calls(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(BinaryTypeEnum[]), typeof(Object[]), typeof(Int32[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo), typeof(SizedArray)}, ReturnType = typeof(ObjectMap))]
	[Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_SystemAssemblyInfo", ReturnType = typeof(BinaryAssemblyInfo))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 43)]
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal sbyte ReadSByte() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void ReadSerializationHeaderRecord() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal float ReadSingle() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(__BinaryParser), typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryAssembly), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectString), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectWithMap), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryObjectWithMapTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryArray), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ReadString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal TimeSpan ReadTimeSpan() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ushort ReadUInt16() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal uint ReadUInt32() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ulong ReadUInt64() { }

	[CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberPrimitiveUnTyped), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(DateTime), Member = "FromBinaryRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 25)]
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HeaderHandler), typeof(__BinaryParser), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectProgress)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "get_prs", ReturnType = typeof(ParseRecord))]
	[Calls(Type = typeof(ObjectProgress), Member = "GetNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum&), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerStack), Member = "Peek", ReturnType = typeof(object))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 36)]
	internal void Run() { }

}

