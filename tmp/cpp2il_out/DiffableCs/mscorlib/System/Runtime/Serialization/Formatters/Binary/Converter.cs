namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class Converter
{
	private static int primitiveTypeEnumLength; //Field offset: 0x0
	private static Type[] typeA; //Field offset: 0x8
	private static Type[] arrayTypeA; //Field offset: 0x10
	private static String[] valueA; //Field offset: 0x18
	private static TypeCode[] typeCodeA; //Field offset: 0x20
	private static InternalPrimitiveTypeE[] codeA; //Field offset: 0x28
	internal static Type typeofISerializable; //Field offset: 0x30
	internal static Type typeofString; //Field offset: 0x38
	internal static Type typeofConverter; //Field offset: 0x40
	internal static Type typeofBoolean; //Field offset: 0x48
	internal static Type typeofByte; //Field offset: 0x50
	internal static Type typeofChar; //Field offset: 0x58
	internal static Type typeofDecimal; //Field offset: 0x60
	internal static Type typeofDouble; //Field offset: 0x68
	internal static Type typeofInt16; //Field offset: 0x70
	internal static Type typeofInt32; //Field offset: 0x78
	internal static Type typeofInt64; //Field offset: 0x80
	internal static Type typeofSByte; //Field offset: 0x88
	internal static Type typeofSingle; //Field offset: 0x90
	internal static Type typeofTimeSpan; //Field offset: 0x98
	internal static Type typeofDateTime; //Field offset: 0xA0
	internal static Type typeofUInt16; //Field offset: 0xA8
	internal static Type typeofUInt32; //Field offset: 0xB0
	internal static Type typeofUInt64; //Field offset: 0xB8
	internal static Type typeofObject; //Field offset: 0xC0
	internal static Type typeofSystemVoid; //Field offset: 0xC8
	internal static Assembly urtAssembly; //Field offset: 0xD0
	internal static string urtAssemblyString; //Field offset: 0xD8
	internal static Type typeofTypeArray; //Field offset: 0xE0
	internal static Type typeofObjectArray; //Field offset: 0xE8
	internal static Type typeofStringArray; //Field offset: 0xF0
	internal static Type typeofBooleanArray; //Field offset: 0xF8
	internal static Type typeofByteArray; //Field offset: 0x100
	internal static Type typeofCharArray; //Field offset: 0x108
	internal static Type typeofDecimalArray; //Field offset: 0x110
	internal static Type typeofDoubleArray; //Field offset: 0x118
	internal static Type typeofInt16Array; //Field offset: 0x120
	internal static Type typeofInt32Array; //Field offset: 0x128
	internal static Type typeofInt64Array; //Field offset: 0x130
	internal static Type typeofSByteArray; //Field offset: 0x138
	internal static Type typeofSingleArray; //Field offset: 0x140
	internal static Type typeofTimeSpanArray; //Field offset: 0x148
	internal static Type typeofDateTimeArray; //Field offset: 0x150
	internal static Type typeofUInt16Array; //Field offset: 0x158
	internal static Type typeofUInt32Array; //Field offset: 0x160
	internal static Type typeofUInt64Array; //Field offset: 0x168
	internal static Type typeofMarshalByRefObject; //Field offset: 0x170

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Assembly))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	private static Converter() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Converter), Member = "ToTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeCode), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Converter), Member = "ToArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 65)]
	private static void InitArrayTypeA() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitCodeA() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Converter), Member = "ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 65)]
	private static void InitTypeA() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static void InitTypeCodeA() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Converter), Member = "ToComType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private static void InitValueA() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Converter), Member = "InitArrayTypeA", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Converter), Member = "ToPrimitiveTypeEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Converter), Member = "InitValueA", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Converter), Member = "InitTypeA", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(Converter), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

}

