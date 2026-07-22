namespace ZXing.Aztec.Internal;

internal sealed class State
{
	public static readonly State INITIAL_STATE; //Field offset: 0x0
	private readonly int mode; //Field offset: 0x10
	private readonly Token token; //Field offset: 0x18
	private readonly int binaryShiftByteCount; //Field offset: 0x20
	private readonly int bitCount; //Field offset: 0x24

	public int BinaryShiftByteCount
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int BitCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Mode
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Token Token
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static State() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public State(Token token, int mode, int binaryBytes, int bitCount) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Token), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(State), Member = "endBinaryShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public State addBinaryShiftChar(int index) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(State), Member = "addBinaryShiftChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[CalledBy(Type = typeof(State), Member = "toBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(BitArray))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public State endBinaryShift(int index) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_BinaryShiftByteCount() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_BitCount() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Mode() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Token get_Token() { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "simplifyStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool isBetterThanOrEqualTo(State other) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Token), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public State latchAndAppend(int mode, int value) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Token), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Token))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public State shiftAndAppend(int mode, int value) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encode", ReturnType = typeof(BitArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(State), Member = "endBinaryShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(BitArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public BitArray toBitArray(Byte[] text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

