namespace Mono.Security;

internal sealed class BitConverterLE
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] GetBytes(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] GetBytes(long value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetULongBytes(Byte* bytes) { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static int ToInt32(Byte[] value, int startIndex) { }

	[CalledBy(Type = typeof(Type1Message), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Type2Message), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Type3Message), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 2)]
	internal static ushort ToUInt16(Byte[] value, int startIndex) { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static uint ToUInt32(Byte[] value, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

