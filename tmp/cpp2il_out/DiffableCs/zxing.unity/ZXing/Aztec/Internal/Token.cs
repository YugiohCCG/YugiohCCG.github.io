namespace ZXing.Aztec.Internal;

public abstract class Token
{
	public static Token EMPTY; //Field offset: 0x0
	private readonly Token previous; //Field offset: 0x10

	public Token Previous
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Token() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Token(Token previous) { }

	[CalledBy(Type = typeof(State), Member = "latchAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(State), Member = "shiftAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(State), Member = "addBinaryShiftChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Token add(int value, int bitCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Token addBinaryShift(int start, int byteCount) { }

	public abstract void appendTo(BitArray bitArray, Byte[] text) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Token get_Previous() { }

}

