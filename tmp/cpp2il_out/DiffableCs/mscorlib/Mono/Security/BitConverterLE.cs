namespace Mono.Security;

internal sealed class BitConverterLE
{

	[CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] GetBytes(float value) { }

	[CalledBy(Type = typeof(BinaryWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Byte[] GetBytes(double value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetULongBytes(Byte* bytes) { }

	[CalledBy(Type = typeof(BinaryReader), Member = "ReadDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static double ToDouble(Byte[] value, int startIndex) { }

	[CalledBy(Type = typeof(BinaryReader), Member = "ReadSingle", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static float ToSingle(Byte[] value, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ULongFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

