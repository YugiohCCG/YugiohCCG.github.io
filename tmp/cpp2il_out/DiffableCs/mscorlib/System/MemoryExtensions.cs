namespace System;

[Extension]
public static class MemoryExtensions
{

	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4EncoderStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static Memory<T> AsMemory(T[] array, int start, int length) { }

	[CalledBy(Type = "System.IO.File+<InternalReadAllBytesUnknownLengthAsync>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static Memory<T> AsMemory(T[] array, int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Span<T> AsSpan(T[] array, int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text, int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Span<T> AsSpan(T[] array, int start, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Span<T> AsSpan(T[] array) { }

	[CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(bool)}, ReturnType = "System.Net.IPAddress")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static bool Contains(ReadOnlySpan<Char> source, char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void CopyTo(T[] source, Span<T> destination) { }

	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SpanHelpers), Member = "EndsWithCultureHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "EndsWithCultureIgnoreCaseHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "EndsWithOrdinalIgnoreCaseHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CheckStringComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringComparison)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool EndsWith(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static bool EndsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static bool EqualsOrdinal(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Extension]
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(Span<T> span, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(Span<T> span, ReadOnlySpan<T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(ReadOnlySpan<T> span, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfAny(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "EndsWithCultureHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeInfo), Member = "get_ImplementedInterfaces", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool IsTypeComparableAsBytes(out ulong size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static bool SequenceEqual(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static bool StartsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TextInfo), Member = "ChangeCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInfo), Member = "ToUpperAsciiInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static int ToUpperInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Guid+GuidStyles", typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static ReadOnlySpan<Char> Trim(ReadOnlySpan<Char> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static ReadOnlySpan<Char> TrimEnd(ReadOnlySpan<Char> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static ReadOnlySpan<Char> TrimStart(ReadOnlySpan<Char> span) { }

}

