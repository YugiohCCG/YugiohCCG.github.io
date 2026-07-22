namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryWriter
{
	internal Stream sout; //Field offset: 0x10
	internal FormatterTypeStyle formatterTypeStyle; //Field offset: 0x18
	internal Hashtable objectMapTable; //Field offset: 0x20
	internal ObjectWriter objectWriter; //Field offset: 0x28
	internal BinaryWriter dataWriter; //Field offset: 0x30
	internal int m_nestedObjectCount; //Field offset: 0x38
	private int nullCount; //Field offset: 0x3C
	internal BinaryMethodCall binaryMethodCall; //Field offset: 0x40
	internal BinaryMethodReturn binaryMethodReturn; //Field offset: 0x48
	internal BinaryObject binaryObject; //Field offset: 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; //Field offset: 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; //Field offset: 0x60
	internal BinaryObjectString binaryObjectString; //Field offset: 0x68
	internal BinaryArray binaryArray; //Field offset: 0x70
	private Byte[] byteBuffer; //Field offset: 0x78
	private int chunkSize; //Field offset: 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0x90
	internal ObjectNull objectNull; //Field offset: 0x98
	internal MemberReference memberReference; //Field offset: 0xA0
	internal BinaryAssembly binaryAssembly; //Field offset: 0xA8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalWriteItemNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void WriteBegin() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteBoolean(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteByte(byte value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void WriteBytes(Byte[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteBytes(Byte[] byteA, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteChar(char value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteChars(Char[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteDateTime(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteDecimal(decimal value) { }

	[CallerCount(Count = 0)]
	internal void WriteDelayedNullItem() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteDouble(double value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteInt16(short value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteInt32(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteInt64(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	internal void WriteItemEnd() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItemObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteMethodCall() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteMethodReturn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(String[]), typeof(Type[]), typeof(Object[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(BinaryObjectWithMapTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, String[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Byte[] byteA) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void WriteObjectString(int objectId, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Int32[] lengthA, Int32[] lowerBoundA) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteSByte(sbyte value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteSerializationHeaderEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteSingle(float value) { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteString(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteTimeSpan(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void WriteUInt16(ushort value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteUInt32(uint value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void WriteUInt64(ulong value) { }

	[CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberPrimitiveUnTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

