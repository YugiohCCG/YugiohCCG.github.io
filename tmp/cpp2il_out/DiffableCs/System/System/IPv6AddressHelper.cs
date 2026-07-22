namespace System;

internal static class IPv6AddressHelper
{

	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static ValueTuple<Int32, Int32> FindCompressionRange(ReadOnlySpan<UInt16> numbers) { }

	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool InternalIsValid(Char* name, int start, ref int end, bool validateStrictAddress) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsLoopback(ReadOnlySpan<UInt16> numbers) { }

	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	internal static bool IsValid(Char* name, int start, ref int end) { }

	[CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	internal static bool IsValidStrict(Char* name, int start, ref int end) { }

	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseHostNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal static void Parse(ReadOnlySpan<Char> address, UInt16* numbers, int start, ref string scopeId) { }

	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ushort), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<UInt16> numbers) { }

}

