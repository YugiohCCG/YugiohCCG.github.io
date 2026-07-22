namespace ZXing.Aztec.Internal;

public sealed class HighLevelEncoder
{
	internal static String[] MODE_NAMES; //Field offset: 0x0
	internal const int MODE_UPPER = 0; //Field offset: 0x0
	internal const int MODE_LOWER = 1; //Field offset: 0x0
	internal const int MODE_DIGIT = 2; //Field offset: 0x0
	internal const int MODE_MIXED = 3; //Field offset: 0x0
	internal const int MODE_PUNCT = 4; //Field offset: 0x0
	internal static readonly Int32[][] LATCH_TABLE; //Field offset: 0x8
	internal static readonly Int32[][] CHAR_MAP; //Field offset: 0x10
	internal static readonly Int32[][] SHIFT_TABLE; //Field offset: 0x18
	private readonly Byte[] text; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 27)]
	private static HighLevelEncoder() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public HighLevelEncoder(Byte[] text) { }

	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(AztecCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "updateStateListForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[Calls(Type = typeof(State), Member = "toBitArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(BitArray))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public BitArray encode() { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(State), Member = "isBetterThanOrEqualTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private static ICollection<State> simplifyStates(IEnumerable<State> states) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "updateStateListForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(State), Member = "endBinaryShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "latchAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "shiftAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "addBinaryShiftChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[CallsUnknownMethods(Count = 5)]
	private void updateStateForChar(State state, int index, ICollection<State> result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State), Member = "endBinaryShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "latchAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "shiftAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "addBinaryShiftChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[CallsUnknownMethods(Count = 5)]
	private static void updateStateForPair(State state, int index, int pairCode, ICollection<State> result) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encode", ReturnType = typeof(BitArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HighLevelEncoder), Member = "updateStateForChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State), typeof(int), typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "simplifyStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private ICollection<State> updateStateListForChar(IEnumerable<State> states, int index) { }

	[CalledBy(Type = typeof(HighLevelEncoder), Member = "encode", ReturnType = typeof(BitArray))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(State), Member = "endBinaryShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "latchAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "shiftAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(State), Member = "addBinaryShiftChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(State))]
	[Calls(Type = typeof(HighLevelEncoder), Member = "simplifyStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Aztec.Internal.State>)}, ReturnType = typeof(System.Collections.Generic.ICollection`1<ZXing.Aztec.Internal.State>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	private static ICollection<State> updateStateListForPair(IEnumerable<State> states, int index, int pairCode) { }

}

