namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[MovedFrom(True, "Unity.Networking.Transport", null, null)]
public struct DataStreamReader
{
	private struct Context
	{
		public int m_ReadByteIndex; //Field offset: 0x0
		public int m_BitIndex; //Field offset: 0x4
		public ulong m_BitBuffer; //Field offset: 0x8
		public int m_FailedReads; //Field offset: 0x10

	}

	[NativeDisableUnsafePtrRestriction]
	internal Byte* m_BufferPtr; //Field offset: 0x0
	private Context m_Context; //Field offset: 0x8
	private int m_Length; //Field offset: 0x20

	public bool HasFailedReads
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public static bool IsLittleEndian
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int Length
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataStreamReader(NativeArray<Byte> array) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int ByteSwap(int val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static short ByteSwap(short val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckBits(int numBits) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal void CheckRead() { }

	[CallerCount(Count = 0)]
	private void FillBitBuffer() { }

	[CallerCount(Count = 0)]
	public void Flush() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool get_HasFailedReads() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public static bool get_IsLittleEndian() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	public int GetBitsRead() { }

	[CallerCount(Count = 0)]
	public int GetBytesRead() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Initialize(out DataStreamReader self, NativeArray<Byte> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public byte ReadByte() { }

	[CalledBy(Type = typeof(DataStreamExtensions), Member = "ReadBytesUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataStreamReader&), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ReadBytes(NativeArray<Byte> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ReadBytes(Span<Byte> span) { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString32", ReturnType = typeof(FixedString32Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString64", ReturnType = typeof(FixedString64Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString128", ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString512", ReturnType = typeof(FixedString512Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString4096", ReturnType = typeof(FixedString4096Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadFixedStringInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	private void ReadBytesInternal(Byte* data, int length) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public double ReadDouble() { }

	[CalledBy(Type = typeof(DataStreamExtensions), Member = "ReadFixedStringUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataStreamReader&), typeof(Byte*), typeof(int)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public ushort ReadFixedString(NativeArray<Byte> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public FixedString128Bytes ReadFixedString128() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public FixedString32Bytes ReadFixedString32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public FixedString4096Bytes ReadFixedString4096() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes ReadFixedString512() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public FixedString64Bytes ReadFixedString64() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private ushort ReadFixedStringInternal(Byte* data, int maxLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float ReadFloat() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public int ReadInt() { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadUIntNetworkByteOrder", ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public int ReadIntNetworkByteOrder() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public long ReadLong() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedDoubleDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(StreamCompressionModel&)}, ReturnType = typeof(double))]
	public double ReadPackedDouble(in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	public double ReadPackedDoubleDelta(double baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	public FixedString128Bytes ReadPackedFixedString128Delta(FixedString128Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	public FixedString32Bytes ReadPackedFixedString32Delta(FixedString32Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	[CallsUnknownMethods(Count = 4)]
	public FixedString4096Bytes ReadPackedFixedString4096Delta(FixedString4096Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes ReadPackedFixedString512Delta(FixedString512Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	public FixedString64Bytes ReadPackedFixedString64Delta(FixedString64Bytes baseline, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamExtensions), Member = "ReadPackedFixedStringDeltaUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataStreamReader&), typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	[CallsDeduplicatedMethods(Count = 2)]
	public ushort ReadPackedFixedStringDelta(NativeArray<Byte> data, NativeArray<Byte> baseData, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedString32Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(FixedString32Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedString64Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(FixedString64Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedString128Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(FixedString128Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedString512Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(FixedString512Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedString4096Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(FixedString4096Bytes))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	private ushort ReadPackedFixedStringDeltaInternal(Byte* data, int maxLength, Byte* baseData, ushort baseLength, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedFloatDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(StreamCompressionModel&)}, ReturnType = typeof(float))]
	public float ReadPackedFloat(in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float ReadPackedFloatDelta(float baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	public int ReadPackedInt(in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[DeduplicatedMethod]
	public int ReadPackedIntDelta(int baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	public long ReadPackedLong(in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[DeduplicatedMethod]
	public long ReadPackedLongDelta(long baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	public uint ReadPackedUInt(in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[DeduplicatedMethod]
	public uint ReadPackedUIntDelta(uint baseline, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamCompressionModel&)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedIntDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedUIntDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedLongDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(StreamCompressionModel&)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedULongDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(StreamCompressionModel&)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadPackedFixedStringDeltaInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(ushort), typeof(StreamCompressionModel&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 16)]
	private uint ReadPackedUIntInternal(int maxSymbolLength, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	public ulong ReadPackedULong(in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadPackedUIntInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(uint))]
	[DeduplicatedMethod]
	public ulong ReadPackedULongDelta(ulong baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	public uint ReadRawBits(int numbits) { }

	[CallerCount(Count = 0)]
	private uint ReadRawBitsInternal(int numbits) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public short ReadShort() { }

	[CalledBy(Type = typeof(DataStreamReader), Member = "ReadUShortNetworkByteOrder", ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public short ReadShortNetworkByteOrder() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public uint ReadUInt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadIntNetworkByteOrder", ReturnType = typeof(int))]
	public uint ReadUIntNetworkByteOrder() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ulong ReadULong() { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ushort ReadUShort() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamReader), Member = "ReadShortNetworkByteOrder", ReturnType = typeof(short))]
	public ushort ReadUShortNetworkByteOrder() { }

	[CallerCount(Count = 0)]
	public void SeekSet(int pos) { }

}

