namespace System.Xml;

internal static class Bits
{
	private static readonly uint MASK_0101010101010101; //Field offset: 0x0
	private static readonly uint MASK_0011001100110011; //Field offset: 0x4
	private static readonly uint MASK_0000111100001111; //Field offset: 0x8
	private static readonly uint MASK_0000000011111111; //Field offset: 0xC
	private static readonly uint MASK_1111111111111111; //Field offset: 0x10

	[CallerCount(Count = 0)]
	private static Bits() { }

	[CallerCount(Count = 0)]
	public static int Count(uint num) { }

	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static int LeastPosition(uint num) { }

}

