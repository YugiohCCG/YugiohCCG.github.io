namespace System;

[Extension]
internal static class SpanHelpers
{

	[CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", typeof(bool)}, ReturnType = "System.Net.IPAddress")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	[CalledBy(Type = typeof(Span`1), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static bool EndsWithCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), "T&", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int IndexOf(ref T searchSpace, T value, int length) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int IndexOf(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(int)}, ReturnType = typeof(bool))]
	public static int IndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroup", Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ToggleButtonGroupState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	[CalledBy(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroup", Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ToggleButtonGroupState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 23)]
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T", typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int IndexOfAny(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "IndexOfAny", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	[CallerCount(Count = 0)]
	private static int LocateFirstFoundChar(ulong match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[Calls(Type = typeof(System.Numerics.Vector`1<System.UInt64>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 3)]
	private static int LocateFirstFoundChar(Vector<UInt16> match) { }

	[CallerCount(Count = 0)]
	private static int LocateLastFoundChar(ulong match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[Calls(Type = typeof(System.Numerics.Vector`1<System.UInt64>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 3)]
	private static int LocateLastFoundChar(Vector<UInt16> match) { }

	[CalledBy(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 9)]
	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(Byte&), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool SequenceEqual(ref T first, ref T second, int length) { }

	[CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[CalledBy(Type = typeof(TypeInfo), Member = "get_ImplementedInterfaces", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "EndsWithCultureHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "StartsWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "StartsWithOrdinalUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "EqualsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(IntPtr), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 15)]
	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

}

