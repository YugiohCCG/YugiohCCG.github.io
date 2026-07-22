namespace System.Buffers.Text;

internal static class FormattingHelpers
{

	[CalledBy(Type = typeof(Number), Member = "NegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryNegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "UInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryUInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static int CountDigits(ulong value) { }

	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "NegativeInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryNegativeInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "UInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryUInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static int CountDigits(uint value) { }

	[CallerCount(Count = 0)]
	public static int CountHexDigits(ulong value) { }

}

