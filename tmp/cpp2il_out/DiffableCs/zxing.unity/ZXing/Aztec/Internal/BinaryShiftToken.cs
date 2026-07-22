namespace ZXing.Aztec.Internal;

public sealed class BinaryShiftToken : Token
{
	private readonly short binaryShiftStart; //Field offset: 0x18
	private readonly short binaryShiftByteCount; //Field offset: 0x1A

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BinaryShiftToken(Token previous, int binaryShiftStart, int binaryShiftByteCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void appendTo(BitArray bitArray, Byte[] text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 22)]
	public virtual string ToString() { }

}

