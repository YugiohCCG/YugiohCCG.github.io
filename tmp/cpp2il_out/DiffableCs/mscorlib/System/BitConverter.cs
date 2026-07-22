namespace System;

public static class BitConverter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"value", "startIndex", "length"})]
		public static SpanAction<Char, ValueTuple`3<Byte[], Int32, Int32>> <>9__38_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal void <ToString>b__38_0(Span<Char> dst, ValueTuple<Byte[], Int32, Int32> state) { }

	}

	[Intrinsic]
	public static readonly bool IsLittleEndian; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static BitConverter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static long DoubleToInt64Bits(double value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(double value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.ResultPoint", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(float value) { }

	[CalledBy(Type = "Card.CardArchetype", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "Card.CardArchetype")]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Hash.xxHash.XXH64", Member = "DigestBytes", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	public static Byte[] GetBytes(ulong value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Hash.xxHash.XXH32", Member = "DigestBytes", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	public static Byte[] GetBytes(uint value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(bool value) { }

	[CalledBy(Type = "Card.CardArchetype", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Int64>"}, ReturnType = "Card.CardArchetype")]
	[CalledBy(Type = "Card.CardArchetype", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Int64>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(long value) { }

	[CalledBy(Type = "Manager.Network+<Send>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<SendDirectPacket>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "GetLongPlayerPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Data.BinaryClient+<Send>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck+<GetHash>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck", Member = "GetHashSync", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Deck", Member = "WriteInt32ToList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+RemoveDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputDevice"}, ReturnType = "UnityEngine.InputSystem.InputRemoting+Message")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting", Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputDevice", "UnityEngine.InputSystem.InputDeviceChange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(int value) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.ManualTestExecutor", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(short value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] GetBytes(char value) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	public static Byte[] GetBytes(ushort value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float Int32BitsToSingle(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static double Int64BitsToDouble(long value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int SingleToInt32Bits(float value) { }

	[CalledBy(Type = "NGettext.Loaders.BigEndianBinaryReader", Member = "ReadDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static double ToDouble(Byte[] value, int startIndex) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static short ToInt16(Byte[] value, int startIndex) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int ToInt32(Byte[] value, int startIndex) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static long ToInt64(Byte[] value, int startIndex) { }

	[CalledBy(Type = "Card.CardArchetype", Member = "get_MainArchetypes", ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static long ToInt64(ReadOnlySpan<Byte> value) { }

	[CalledBy(Type = "Spine.SkeletonBinary+SkeletonInput", Member = "ReadFloat", ReturnType = typeof(float))]
	[CalledBy(Type = "NGettext.Loaders.BigEndianBinaryReader", Member = "ReadSingle", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static float ToSingle(Byte[] value, int startIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpanAction`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TState", "System.Buffers.SpanAction`2<Char, TState>"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static string ToString(Byte[] value, int startIndex, int length) { }

	[CalledBy(Type = typeof(SerializationHeaderRecord), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static string ToString(Byte[] value) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ushort ToUInt16(Byte[] value, int startIndex) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static uint ToUInt32(Byte[] value, int startIndex) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument), typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static ulong ToUInt64(Byte[] value, int startIndex) { }

	[CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public static bool TryWriteBytes(Span<Byte> destination, uint value) { }

}

