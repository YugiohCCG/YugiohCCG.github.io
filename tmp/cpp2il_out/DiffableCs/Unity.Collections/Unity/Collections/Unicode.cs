namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public struct Unicode
{
	[GenerateTestsForBurstCompatibility]
	internal struct Rune
	{
		public int value; //Field offset: 0x0

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public Rune(int codepoint) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool IsAscii() { }

		[CalledBy(Type = typeof(FixedStringMethods), Member = "ParseLongInternal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(Int64&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "Parse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(Single&), typeof(char)}, ReturnType = typeof(ParseError))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		public static bool IsDigit(Rune r) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool IsDigit() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool IsLatin1() { }

		[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStartIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal bool IsWhiteSpace() { }

		[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(FormatError))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune), typeof(int)}, ReturnType = typeof(FormatError))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "EndsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		public int LengthInUtf8Bytes() { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool op_Equality(Rune lhs, Rune rhs) { }

		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		public static Rune op_Implicit(char codepoint) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool op_Inequality(Rune lhs, Rune rhs) { }

		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToLowerAscii", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToLowerAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToLowerAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
		[CallerCount(Count = 3)]
		internal Rune ToLowerAscii() { }

		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToUpperAscii", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToUpperAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(AllocatorHandle)}, ReturnType = typeof(UnsafeText))]
		[CalledBy(Type = typeof(FixedStringMethods), Member = "ToUpperAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
		[CallerCount(Count = 3)]
		internal Rune ToUpperAscii() { }

	}

	public const int kMaximumValidCodePoint = 1114111; //Field offset: 0x0

	public static Rune BadRune
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public static Rune ReplacementCharacter
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	private static int CountRunes(Byte* utf8Buffer, int utf8Length, int maxRunes = 2147483647) { }

	[CallerCount(Count = 0)]
	private static int FindUtf8CharStartInReverse(Byte* ptr, ref int index) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public static Rune get_BadRune() { }

	[CallerCount(Count = 0)]
	public static Rune get_ReplacementCharacter() { }

	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsLeadingSurrogate(char c) { }

	[CallerCount(Count = 21)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsTrailingSurrogate(char c) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsValidCodePoint(int codepoint) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool NotTrailer(byte b) { }

	[CallerCount(Count = 0)]
	internal static ConversionError UcsToUcs(out Rune rune, Rune* buffer, ref int index, int capacity) { }

	[CallerCount(Count = 0)]
	public static ConversionError UcsToUtf16(Char* buffer, ref int index, int capacity, Rune rune) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune), typeof(int)}, ReturnType = typeof(FormatError))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(Rune)}, ReturnType = typeof(FormatError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(UInt16&), typeof(ushort), typeof(Byte*), typeof(ushort)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(UInt16&), typeof(ushort), typeof(Byte*), typeof(ushort)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(Unicode), Member = "Utf16ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CalledBy(Type = typeof(Unicode), Member = "Utf8ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[CallerCount(Count = 7)]
	public static ConversionError UcsToUtf8(Byte* buffer, ref int index, int capacity, Rune rune) { }

	[CallerCount(Count = 0)]
	public static ConversionError Utf16ToUcs(out Rune rune, Char* buffer, ref int index, int capacity) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(UInt16&), typeof(ushort), typeof(Char*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(UInt16&), typeof(ushort), typeof(Char*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	public static ConversionError Utf16ToUtf8(Char* utf16Buffer, int utf16Length, Byte* utf8Buffer, out int utf8Length, int utf8Capacity) { }

	[CallerCount(Count = 29)]
	public static ConversionError Utf8ToUcs(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEndIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	internal static ConversionError Utf8ToUcsReverse(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(Byte*), typeof(ushort)}, ReturnType = typeof(CopyError))]
	[CalledBy(Type = typeof(UTF8ArrayUnsafeUtility), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(Byte*), typeof(ushort)}, ReturnType = typeof(CopyError))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	public static ConversionError Utf8ToUtf16(Byte* utf8Buffer, int utf8Length, Char* utf16Buffer, out int utf16Length, int utf16Capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static ConversionError Utf8ToUtf8(Byte* srcBuffer, int srcLength, Byte* destBuffer, out int destLength, int destCapacity) { }

}

