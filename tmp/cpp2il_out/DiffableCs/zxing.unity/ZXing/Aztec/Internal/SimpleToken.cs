namespace ZXing.Aztec.Internal;

public sealed class SimpleToken : Token
{
	private readonly short value; //Field offset: 0x18
	private readonly short bitCount; //Field offset: 0x1A

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SimpleToken(Token previous, int value, int bitCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitArray), Member = "appendBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void appendTo(BitArray bitArray, Byte[] text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportClass), Member = "ToBinaryString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

