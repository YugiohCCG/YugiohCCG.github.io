namespace System.Net;

internal class IPAddressParser
{

	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(IPAddressParser), Member = "AppendHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint ExtractIPv4Address(UInt16[] address) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	[CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Char*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	internal static string IPv4AddressToString(uint address) { }

	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Char*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static int IPv4AddressToStringHelper(uint address, Char* addressString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool Ipv4StringToAddress(ReadOnlySpan<Char> ipSpan, out long address) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	internal static string IPv6AddressToString(UInt16[] address, uint scopeId) { }

	[CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "ShouldHaveIpv4Embedded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(IPAddressParser), Member = "AppendHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, uint scopeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool Ipv6StringToAddress(ReadOnlySpan<Char> ipSpan, UInt16* numbers, int numbersLength, out uint scope) { }

	[CalledBy(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryExtensions), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[Calls(Type = "System.SpanHelpers", Member = "ClearWithoutReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	internal static IPAddress Parse(ReadOnlySpan<Char> ipSpan, bool tryParse) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static ushort Reverse(ushort number) { }

}

