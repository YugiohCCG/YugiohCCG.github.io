namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
public static class FixedStringMethods
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rune), Member = "LengthInUtf8Bytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedString32Bytes), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, Rune rune) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static FormatError Append(ref T fs, char a, char b) { }

	[CallerCount(Count = 313)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	public static FormatError Append(ref T fs, string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString128Bytes), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, Byte* utf8Bytes, int utf8BytesLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static FormatError Append(ref T fs, char a, char b, char c) { }

	[CallerCount(Count = 313)]
	[Calls(Type = typeof(FixedStringUtils), Member = "Base2ToBase10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&), typeof(Int32&), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendScientific", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Char*), typeof(int), typeof(int), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, float input, char decimalSeparator = .) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, uint input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString128Bytes), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, in T2 input) { }

	[CallerCount(Count = 142)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, int input) { }

	[CallerCount(Count = 172)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, long input) { }

	[CalledBy(Type = typeof(FixedString128Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rune), Member = "LengthInUtf8Bytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedString128Bytes), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, Rune rune, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static FormatError Append(ref T fs, char a, char b, char c, char d, char e, char f, char g, char h) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, char ch) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Append(ref T fs, ulong input) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8, in T9 arg9) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3, in T4 arg4, in T5 arg5, in T6 arg6, in T7 arg7, in T8 arg8) { }

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2) { }

	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(int), typeof(int)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(float), typeof(int)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(string), typeof(int)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(int), typeof(float)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(float), typeof(float)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(string), typeof(float)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(int), typeof(string)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(float), typeof(string)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(string), typeof(string)}, ReturnType = typeof(FixedString128Bytes))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1) { }

	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(int)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(float)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(FixedString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(string)}, ReturnType = typeof(FixedString128Bytes))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0) { }

	[CallerCount(Count = 81)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static FormatError AppendFormat(ref T dest, in U format, in T0 arg0, in T1 arg1, in T2 arg2, in T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString128Bytes), Member = "TryResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError AppendRawByte(ref T fs, byte a) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static FormatError AppendScientific(ref T fs, Char* source, int sourceLength, int decimalExponent, char decimalSeparator = .) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckSubstringInRange(int strLength, int startIndex, int length) { }

	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static int CompareTo(ref T fs, in T2 other) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int CompareTo(ref T fs, Byte* bytes, int bytesLen) { }

	[CalledBy(Type = typeof(FixedString32Bytes), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedString64Bytes), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedString4096Bytes), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeText), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CollectionHelper), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int ComputeHashCode(ref T fs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static bool Contains(ref T fs, in T2 other) { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Extension]
	public static string ConvertToString(ref T fs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	public static CopyError CopyFrom(ref T fs, string s) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static CopyError CopyFrom(ref T fs, in T2 input) { }

	[CalledBy(Type = typeof(FixedString128Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FixedString128Bytes))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	[Extension]
	public static CopyError CopyFromTruncated(ref T fs, string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CallsUnknownMethods(Count = 29)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static CopyError CopyFromTruncated(ref T fs, in T2 input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int EffectiveSizeOf(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rune), Member = "LengthInUtf8Bytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "StrCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Rune*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static bool EndsWith(ref T fs, Rune rune) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "StrCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static bool EndsWith(ref T fs, in U other) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static bool Equals(ref T fs, in T2 other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static bool Equals(ref T fs, Byte* bytes, int bytesLen) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static bool Found(ref T fs, ref int offset, char a, char b, char c, char d, char e, char f, char g, char h) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static bool Found(ref T fs, ref int offset, char a, char b, char c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int IndexOf(ref T fs, Rune rune) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int IndexOf(ref T fs, Byte* bytes, int bytesLen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int IndexOf(ref T fs, Byte* bytes, int bytesLen, int startIndex, int distance = 2147483647) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static int IndexOf(ref T fs, in T2 other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static int IndexOf(ref T fs, in T2 other, int startIndex, int distance = 2147483647) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static int LastIndexOf(ref T fs, in T2 other, int startIndex, int distance = 2147483647) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int LastIndexOf(ref T fs, Byte* bytes, int bytesLen, int startIndex, int distance = 2147483647) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int LastIndexOf(ref T fs, Byte* bytes, int bytesLen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "IsValidCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static int LastIndexOf(ref T fs, Rune rune) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static int LastIndexOf(ref T fs, in T2 other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static ParseError Parse(ref T fs, ref int offset, ref uint output) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static ParseError Parse(ref T fs, ref int offset, ref int output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rune), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FixedStringUtils), Member = "Base10ToBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(ulong), typeof(int)}, ReturnType = typeof(ParseError))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static ParseError Parse(ref T fs, ref int offset, ref float output, char decimalSeparator = .) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rune), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static bool ParseLongInternal(ref T fs, ref int offset, out long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static Rune Peek(ref T fs, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static Rune Read(ref T fs, ref int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rune), Member = "LengthInUtf8Bytes", ReturnType = typeof(int))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "StrCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Rune*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static bool StartsWith(ref T fs, Rune rune) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "StrCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes)})]
	public static bool StartsWith(ref T fs, in U other) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static NativeText Substring(ref NativeText str, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int), typeof(int)}, ReturnType = typeof(NativeText))]
	[DeduplicatedMethod]
	[Extension]
	public static NativeText Substring(ref NativeText str, int startIndex, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText Substring(ref NativeText str, int startIndex, int length, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T Substring(ref T str, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T Substring(ref T str, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int), typeof(int)}, ReturnType = typeof(NativeText))]
	[DeduplicatedMethod]
	[Extension]
	public static NativeText Substring(ref NativeText str, int startIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToLowerAscii", ReturnType = typeof(Rune))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText ToLowerAscii(ref NativeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToLowerAscii", ReturnType = typeof(Rune))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText ToLowerAscii(ref UnsafeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToLowerAscii", ReturnType = typeof(Rune))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T ToLowerAscii(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToUpperAscii", ReturnType = typeof(Rune))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T ToUpperAscii(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToUpperAscii", ReturnType = typeof(Rune))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText ToUpperAscii(ref NativeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "ToUpperAscii", ReturnType = typeof(Rune))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText ToUpperAscii(ref UnsafeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText Trim(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText Trim(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T Trim(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText Trim(ref NativeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText Trim(ref UnsafeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T Trim(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText TrimEnd(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T TrimEnd(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText TrimEnd(ref NativeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T TrimEnd(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText TrimEnd(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText TrimEnd(ref UnsafeText fs, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcsReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "IsWhiteSpace", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static int TrimEndIndex(ref T fs) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcsReverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static int TrimEndIndex(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText TrimStart(ref UnsafeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T TrimStart(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText TrimStart(ref NativeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static UnsafeText TrimStart(ref UnsafeText fs, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static T TrimStart(ref T fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static NativeText TrimStart(ref NativeText fs, AllocatorHandle allocator, ReadOnlySpan<Rune> trimRunes) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static int TrimStartIndex(ref T fs, ReadOnlySpan<Rune> trimRunes) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Rune), Member = "IsWhiteSpace", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	internal static int TrimStartIndex(ref T fs) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString128Bytes)})]
	public static FormatError Write(ref T fs, ref int index, Rune rune) { }

}

