namespace System;

[Extension]
public static class Convert
{
	private static readonly SByte[] s_decodingMap; //Field offset: 0x0
	internal static readonly Type[] ConvertTypes; //Field offset: 0x8
	private static readonly Type EnumType; //Field offset: 0x10
	internal static readonly Char[] base64Table; //Field offset: 0x18
	public static readonly object DBNull; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 83)]
	private static Convert() { }

	[CalledBy(Type = typeof(Converter), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonFormatterConverter", Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeCode)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 33)]
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	[CalledBy(Type = "SQLite.TableQuery`1", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions", Member = "GetParameterValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction", "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", "UnityEngine.InputSystem.InputBinding"}, ReturnType = "System.Nullable`1<TValue>")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControl`1", Member = "WriteValueFromObjectIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Void*"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[ContainsInvalidInstructions]
	public static object ChangeType(object value, Type conversionType) { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XmlDataLoader", Member = "LoadTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Data.DataTable", typeof(bool), "System.Xml.XmlAttribute[]", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSimpleType", typeof(string), "System.Data.DataTable", typeof(bool), "System.Xml.XmlAttribute[]", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XMLDiffLoader", Member = "ReadOldRowData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Data.DataTable&", typeof(Int32&), "System.Xml.XmlReader"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.Extensions", Member = "Convert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "U")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonFormatterConverter", Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.NamingStrategy", typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(object), typeof(CultureInfo), "Newtonsoft.Json.Serialization.JsonContract", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.BaseNumberConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriterInterpreter", Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapMember", typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enum), Member = "TryParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(EnumResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.TableMapping", Member = "SetAutoIncPK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "GetFlagsValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.IList`1<T>")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 31)]
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int), typeof(Base64FormattingOptions)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int ConvertToBase64Array(Char* outChars, Byte* inData, int offset, int length, bool insertLineBreaks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<Char> chars, Span<Char> tempBuffer, out int consumed, out int charsWritten) { }

	[CallerCount(Count = 0)]
	private static int Decode(ref char encodedChars, ref sbyte decodingMap) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTime), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DBNull), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(char), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 43)]
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static int FromBase64_ComputeResultLength(Char* inputPtr, int inputLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 23)]
	[ContainsInvalidInstructions]
	public static Byte[] FromBase64CharArray(Char[] inArray, int offset, int length) { }

	[CalledBy(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "TryFromBase64Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Byte>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static Byte[] FromBase64CharPtr(Char* inputPtr, int inputLength) { }

	[CallerCount(Count = 55)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "FromBase64CharPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static Byte[] FromBase64String(string s) { }

	[CalledBy(Type = typeof(Enum), Member = "InternalFormattedHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static TypeCode GetTypeCode(object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static bool IsSpace(char c) { }

	[CalledBy(Type = typeof(char), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowByteOverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowCharOverflowException() { }

	[CalledBy(Type = typeof(char), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(short))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowInt16OverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowInt32OverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowInt64OverflowException() { }

	[CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(char), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowSByteOverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowUInt16OverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowUInt32OverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ThrowUInt64OverflowException() { }

	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int), typeof(Base64FormattingOptions)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.Base64Encoder", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.Base64Encoder", Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Base64Encoder", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Base64Encoder", Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder+<EncodeAsync>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder", Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder", Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int), typeof(Base64FormattingOptions)}, ReturnType = typeof(int))]
	public static int ToBase64CharArray(Byte[] inArray, int offsetIn, int length, Char[] outArray, int offsetOut) { }

	[CalledBy(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ConvertToBase64Array", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Byte*), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 39)]
	[ContainsUnimplementedInstructions]
	public static int ToBase64CharArray(Byte[] inArray, int offsetIn, int length, Char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	[CalledBy(Type = typeof(ClaimsIdentity), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlBytes", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWriter"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	public static string ToBase64String(Byte[] inArray, int offset, int length) { }

	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public static string ToBase64String(Byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ConvertToBase64Array", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Byte*), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static string ToBase64String(ReadOnlySpan<Byte> bytes, Base64FormattingOptions options = 0) { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string ToBase64String(Byte[] inArray) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	public static bool ToBoolean(decimal value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ToBoolean(double value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ToBoolean(float value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "ZXing.OneD.Code39Reader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static bool ToBoolean(object value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonToken", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(CancellationToken), "Newtonsoft.Json.JsonConverter[]"}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.DataTable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.ConstNode", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Data.ValueType", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "CompareWithFamilies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 5)]
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CallerCount(Count = 18)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(sbyte value) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(short value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(ushort value) { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(byte value) { }

	[CallerCount(Count = 6)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(uint value) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(long value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(ulong value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public static bool ToBoolean(string value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool ToBoolean(int value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static byte ToByte(ushort value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static byte ToByte(object value) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static byte ToByte(string value, int fromBase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static byte ToByte(char value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static byte ToByte(sbyte value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static byte ToByte(short value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static byte ToByte(int value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	public static byte ToByte(decimal value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeLongNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static byte ToByte(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static byte ToByte(ulong value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static byte ToByte(float value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static byte ToByte(double value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadArrayElementIntoByteArrayReportDone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Byte>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(byte))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Byte>")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.BinaryConverter", Member = "ReadByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	public static byte ToByte(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	public static byte ToByte(string value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	public static byte ToByte(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static byte ToByte(uint value) { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static byte ToByte(bool value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static char ToChar(string value, IFormatProvider provider) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static char ToChar(string value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static char ToChar(object value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Char>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(char))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static char ToChar(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static char ToChar(sbyte value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static char ToChar(byte value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToChar(short value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static char ToChar(ushort value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ConvertUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(char))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseUnicode", ReturnType = typeof(char))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToChar(int value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static char ToChar(uint value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToChar(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static char ToChar(ulong value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(FormatterConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonToken", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTime>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTimeOffset>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(CancellationToken), "Newtonsoft.Json.JsonConverter[]"}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "CompareWithFamilies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
	[CLSCompliant(False)]
	public static decimal ToDecimal(ulong value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(long value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Decimal))]
	[CLSCompliant(False)]
	public static decimal ToDecimal(uint value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(int value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public static decimal ToDecimal(ushort value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(byte value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Decimal))]
	[CLSCompliant(False)]
	public static decimal ToDecimal(sbyte value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.TypedObject", Member = "SetDecimal", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDecimal", ReturnType = "System.Nullable`1<Decimal>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Decimal>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static decimal ToDecimal(object value, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(bool value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(float value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(double value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(string value, IFormatProvider provider) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static double ToDouble(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "CompareWithFamilies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.ConstNode", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Data.ValueType", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(CancellationToken), "Newtonsoft.Json.JsonConverter[]"}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonToken", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDouble", ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(double))]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 5)]
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(sbyte value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(byte value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(ushort value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(int value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(uint value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(short value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(ulong value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(float value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	public static double ToDouble(decimal value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.ComponentModel.DoubleConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	public static double ToDouble(string value, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(bool value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(long value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static short ToInt16(sbyte value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static short ToInt16(long value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static short ToInt16(uint value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static short ToInt16(int value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static short ToInt16(ushort value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static short ToInt16(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static short ToInt16(char value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ResponseDescription", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(short))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int16>")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static short ToInt16(object value, IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static short ToInt16(object value) { }

	[CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static short ToInt16(string value, int fromBase) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	public static short ToInt16(decimal value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static short ToInt16(ulong value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static short ToInt16(double value) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static short ToInt16(bool value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static short ToInt16(float value) { }

	[CalledBy(Type = "System.ComponentModel.Int32Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.OneD.ITFWriter", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Boolean[]")]
	[CalledBy(Type = "SharpJson.Lexer", Member = "ParseString", ReturnType = typeof(string))]
	[CalledBy(Type = "Spine.SkeletonJson", Member = "ToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int ToInt32(string value, int fromBase) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static int ToInt32(float value) { }

	[CalledBy(Type = "Mono.Nat.Upnp.GetGenericPortMappingEntryResponseMessage", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.GetSpecificPortMappingEntryResponseMessage", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.OneD.UPCEANExtension2Support", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Int32[]"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "ZXing.OneD.UPCEANExtension2Support", Member = "parseExtensionString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Collections.Generic.IDictionary`2<ResultMetadataType, Object>")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	public static int ToInt32(string value) { }

	[CalledBy(Type = "SQLite.EnumCacheInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.FusionSummon", Member = "SetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.FusionSummon", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.SpineSummon", Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.SpineSummon", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionAsset", Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadFileJson&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerBitField", Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerBitField", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Aztec.AztecWriter", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "ZXing.BarcodeFormat", typeof(int), typeof(int), "System.Collections.Generic.IDictionary`2<EncodeHintType, Object>"}, ReturnType = "ZXing.Common.BitMatrix")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ConvertHelper", Member = "ToInt32NoNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 5)]
	public static int ToInt32(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MS.Internal.Xml.XPath.XPathScanner", Member = "NextLex", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsInt32", ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	public static int ToInt32(object value, IFormatProvider provider) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int ToInt32(bool value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParseArrayIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = "Newtonsoft.Json.Linq.JsonPath.PathFilter")]
	[CalledBy(Type = "System.Data.SimpleType", Member = "LoadTypeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSimpleType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XDRSchema", Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlElement"}, ReturnType = "System.Data.DataTable")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static int ToInt32(byte value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	public static int ToInt32(short value) { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public static int ToInt32(char value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static int ToInt32(uint value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static int ToInt32(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static int ToInt32(ulong value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int ToInt32(double value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	public static int ToInt32(decimal value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static int ToInt32(ushort value) { }

	[CallerCount(Count = 19)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static long ToInt64(uint value) { }

	[CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static long ToInt64(string value, int fromBase) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetContentLengthFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "ToInteger", ReturnType = typeof(long))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	public static long ToInt64(string value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	public static long ToInt64(decimal value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static long ToInt64(float value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowInt64OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static long ToInt64(ulong value) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public static long ToInt64(int value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static long ToInt64(double value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	public static long ToInt64(short value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static long ToInt64(byte value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static long ToInt64(sbyte value) { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public static long ToInt64(char value) { }

	[CallerCount(Count = 0)]
	public static long ToInt64(bool value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementInt64", Member = "SetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(CancellationToken), "Newtonsoft.Json.JsonConverter[]"}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int64>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonToken", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 5)]
	public static long ToInt64(object value, IFormatProvider provider) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "UnityEngine.EnumDataUtility+<>c", Member = "<GetCachedEnumData>b__2_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static long ToInt64(object value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static long ToInt64(ushort value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(ulong value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static sbyte ToSByte(float value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(double value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(uint value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(int value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(ushort value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CLSCompliant(False)]
	public static sbyte ToSByte(decimal value) { }

	[CalledBy(Type = "System.ComponentModel.SByteConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static sbyte ToSByte(string value, int fromBase) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CLSCompliant(False)]
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(char value) { }

	[CallerCount(Count = 18)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static sbyte ToSByte(bool value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<SByte>")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(object value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(short value) { }

	[CallerCount(Count = 0)]
	public static float ToSingle(bool value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	public static float ToSingle(string value, IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "ToDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	public static float ToSingle(string value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	public static float ToSingle(decimal value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(double value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(ulong value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	public static float ToSingle(int value) { }

	[CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static float ToSingle(ushort value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	public static float ToSingle(short value) { }

	[CallerCount(Count = 0)]
	public static float ToSingle(byte value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static float ToSingle(sbyte value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Single>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(uint value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static float ToSingle(object value) { }

	[CalledBy(Type = typeof(FormatterConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "AddExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.PropertyCollection", "System.Xml.XmlElement", typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.ExceptionBuilder", Member = "RelationOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Data.ExceptionBuilder", Member = "UniqueConstraintViolationText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataColumn[]", "System.Object[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.ExceptionBuilder", Member = "KeysToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Object[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Uri")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<TimeSpan>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonContract", typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidatePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Guid>")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static string ToString(object value, IFormatProvider provider) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexNode", Member = "ReduceConcatenation", ReturnType = "System.Text.RegularExpressions.RegexNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateFromChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	public static string ToString(char value, IFormatProvider provider) { }

	[CalledBy(Type = "ZXing.QrCode.Internal.Version", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroupState", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray32", Member = "get_humanizedVersion", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray32", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray64", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray128", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray256", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Drawing.Color", Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ParseNumbers), Member = "LongToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static string ToString(long value, int toBase) { }

	[CalledBy(Type = "ArabicFixerTool", Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray16", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParseNumbers), Member = "IntToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static string ToString(int value, int toBase) { }

	[CalledBy(Type = "UnityEngine.Rendering.BitArray8", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParseNumbers), Member = "IntToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static string ToString(byte value, int toBase) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "AssignNameSlots", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "GetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Xml.XmlElement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(int value, IFormatProvider provider) { }

	[CalledBy(Type = "Card.CardArchetype", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<String, UInt16>", "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.TextDataManager", Member = "ParseConfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static ushort ToUInt16(string value, int fromBase) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(object value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt16>")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(sbyte value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ushort ToUInt16(char value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ushort ToUInt16(byte value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(short value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(int value) { }

	[CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(uint value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(ulong value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static ushort ToUInt16(float value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(double value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CLSCompliant(False)]
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	[CallerCount(Count = 19)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static ushort ToUInt16(bool value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CLSCompliant(False)]
	public static ushort ToUInt16(decimal value) { }

	[CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static uint ToUInt32(string value, int fromBase) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "UnityEngine.TouchScreenKeyboard", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.TouchScreenKeyboardType", typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TouchScreenKeyboard", Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.TouchScreenKeyboardType", typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = "UnityEngine.TouchScreenKeyboard")]
	[CalledBy(Type = "UnityEngine.TouchScreenKeyboard", Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.TouchScreenKeyboardType", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.TouchScreenKeyboard")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static uint ToUInt32(object value) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[CLSCompliant(False)]
	public static uint ToUInt32(decimal value) { }

	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt32>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(uint))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CallerCount(Count = 19)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint ToUInt32(bool value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static uint ToUInt32(char value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static uint ToUInt32(sbyte value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static uint ToUInt32(byte value) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static uint ToUInt32(short value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static uint ToUInt32(ushort value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static uint ToUInt32(int value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static uint ToUInt32(long value) { }

	[CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static uint ToUInt32(ulong value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static uint ToUInt32(float value) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static uint ToUInt32(double value) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CLSCompliant(False)]
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CLSCompliant(False)]
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Decimal), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CLSCompliant(False)]
	public static ulong ToUInt64(decimal value) { }

	[CalledBy(Type = "System.ComponentModel.UInt64Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static ulong ToUInt64(string value, int fromBase) { }

	[CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static ulong ToUInt64(double value) { }

	[CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	public static ulong ToUInt64(float value) { }

	[CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(long value) { }

	[CallerCount(Count = 19)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ulong ToUInt64(uint value) { }

	[CalledBy(Type = "Scenes.General.MultiPick+<Create>d__29`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<Create>d__31`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick", Member = "GetCurrentValue", ReturnType = typeof(Enum))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "UnityEngine.EnumDataUtility+<>c", Member = "<GetCachedEnumData>b__2_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(object value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ulong ToUInt64(ushort value) { }

	[CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(int value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ulong ToUInt64(byte value) { }

	[CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(sbyte value) { }

	[CallerCount(Count = 41)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ulong ToUInt64(char value) { }

	[CallerCount(Count = 19)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static ulong ToUInt64(bool value) { }

	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Enum), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(FormatterConverter), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt64>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(short value) { }

	[CalledBy(Type = typeof(Convert), Member = "TryFromBase64Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Byte>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TryDecodeFromUtf16(ReadOnlySpan<Char> utf16, Span<Byte> bytes, out int consumed, out int written) { }

	[CalledBy(Type = typeof(Convert), Member = "FromBase64CharPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "TryDecodeFromUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static bool TryFromBase64Chars(ReadOnlySpan<Char> chars, Span<Byte> bytes, out int bytesWritten) { }

	[CallerCount(Count = 0)]
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

}

