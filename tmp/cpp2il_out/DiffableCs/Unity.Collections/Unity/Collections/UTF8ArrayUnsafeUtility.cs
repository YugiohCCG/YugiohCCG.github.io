namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class UTF8ArrayUnsafeUtility
{
	public struct Comparison
	{
		public bool terminates; //Field offset: 0x0
		public int result; //Field offset: 0x4

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public Comparison(Rune runeA, ConversionError errorA, Rune runeB, ConversionError errorB) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static CopyError Append(Byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, Byte* src, ushort srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf16ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Append(Byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Append(Char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, Byte* src, ushort srcLength) { }

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static FormatError AppendUTF8Bytes(Byte* dest, ref int destLength, int destCapacity, Byte* src, int srcLength) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(CopyError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf16ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Copy(Byte* dest, out int destLength, int destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf16ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Copy(Byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(CopyError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static CopyError Copy(Byte* dest, out int destLength, int destUTF8MaxLengthInBytes, Byte* src, int srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Unicode), Member = "UcsToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Rune)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public static CopyError Copy(Byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, Byte* src, ushort srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Copy(Char* dest, out int destLength, int destUCS2MaxLengthInChars, Byte* src, int srcLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static CopyError Copy(Char* dest, out ushort destLength, ushort destUCS2MaxLengthInChars, Byte* src, ushort srcLength) { }

	[CallerCount(Count = 45)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static bool EqualsUTF8Bytes(Byte* aBytes, int aLength, Byte* bBytes, int bLength) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "EndsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static int StrCmp(Byte* utf8BufferA, int utf8LengthInBytesA, Byte* utf8BufferB, int utf8LengthInBytesB) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "EndsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Rune)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	internal static int StrCmp(Byte* utf8BufferA, int utf8LengthInBytesA, Rune* runeBufferB, int lengthInRunesB) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int StrCmp(Char* utf16BufferA, int utf16LengthInCharsA, Char* utf16BufferB, int utf16LengthInCharsB) { }

	[CalledBy(Type = typeof(FixedString32Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString64Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString128Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString4096Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static int StrCmp(Byte* utf8Buffer, int utf8LengthInBytes, Char* utf16Buffer, int utf16LengthInChars) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[ContainsUnimplementedInstructions]
	public static int StrCmp(Char* utf16Buffer, int utf16LengthInChars, Byte* utf8Buffer, int utf8LengthInBytes) { }

}

