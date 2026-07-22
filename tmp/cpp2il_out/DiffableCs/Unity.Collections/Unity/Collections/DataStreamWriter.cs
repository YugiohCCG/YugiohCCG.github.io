namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[MovedFrom(True, "Unity.Networking.Transport", "Unity.Networking.Transport", null)]
public struct DataStreamWriter
{
	private struct StreamData
	{
		public Byte* buffer; //Field offset: 0x0
		public int length; //Field offset: 0x8
		public int capacity; //Field offset: 0xC
		public ulong bitBuffer; //Field offset: 0x10
		public int bitIndex; //Field offset: 0x18
		public int failedWrites; //Field offset: 0x1C

	}

	[NativeDisableUnsafePtrRestriction]
	private StreamData m_Data; //Field offset: 0x0
	public IntPtr m_SendHandleData; //Field offset: 0x20

	public int Capacity
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public bool HasFailedWrites
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
		[CallerCount(Count = 0)]
		 get { } //Length: 77
	}

	public int LengthInBits
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 74
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataStreamWriter(int length, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(DataStreamExtensions), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(DataStreamWriter))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataStreamWriter(NativeArray<Byte> data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DataStreamWriter(Byte* data, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public NativeArray<Byte> AsNativeArray() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static short ByteSwap(short val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int ByteSwap(int val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckAllocator(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckBits(uint value, int numBits) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckRead() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckWrite() { }

	[CallerCount(Count = 0)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	public void Flush() { }

	[CallerCount(Count = 0)]
	private void FlushBits() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool get_HasFailedWrites() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public static bool get_IsLittleEndian() { }

	[CallerCount(Count = 0)]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	public int get_LengthInBits() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Initialize(out DataStreamWriter self, NativeArray<Byte> data) { }

	[CallerCount(Count = 0)]
	private void SyncBitData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public bool WriteByte(byte value) { }

	[CalledBy(Type = typeof(DataStreamExtensions), Member = "WriteBytesUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataStreamWriter&), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WriteBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool WriteBytes(NativeArray<Byte> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WriteBytesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool WriteBytes(Span<Byte> value) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	private bool WriteBytesInternal(Byte* data, int bytes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool WriteDouble(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteFixedString128(FixedString128Bytes str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteFixedString32(FixedString32Bytes str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteFixedString4096(FixedString4096Bytes str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteFixedString512(FixedString512Bytes str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteFixedString64(FixedString64Bytes str) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool WriteFloat(float value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteInt(int value) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WriteUIntNetworkByteOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool WriteIntNetworkByteOrder(int value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteLong(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedDoubleDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	public bool WritePackedDouble(double value, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WritePackedDoubleDelta(double value, double baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedFixedString128Delta(FixedString128Bytes str, FixedString128Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedFixedString32Delta(FixedString32Bytes str, FixedString32Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedFixedString4096Delta(FixedString4096Bytes str, FixedString4096Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedFixedString512Delta(FixedString512Bytes str, FixedString512Bytes baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedFixedString64Delta(FixedString64Bytes str, FixedString64Bytes baseline, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedString32Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedString64Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes), typeof(FixedString64Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedString128Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes), typeof(FixedString128Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedString512Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes), typeof(FixedString512Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedString4096Delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes), typeof(FixedString4096Bytes), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool WritePackedFixedStringDelta(Byte* data, uint length, Byte* baseData, uint baseLength, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedFloatDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	public bool WritePackedFloat(float value, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool WritePackedFloatDelta(float value, float baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	public bool WritePackedInt(int value, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedIntDelta(int value, int baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	public bool WritePackedLong(long value, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedLongDelta(long value, long baseline, in StreamCompressionModel model) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedUIntDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedIntDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedLongDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedULongDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedFixedStringDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(Byte*), typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(StreamCompressionModel), Member = "CalculateBucket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	public bool WritePackedUInt(uint value, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedUIntDelta(uint value, uint baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	public bool WritePackedULong(ulong value, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool WritePackedULongDelta(ulong value, ulong baseline, in StreamCompressionModel model) { }

	[CallerCount(Count = 0)]
	public bool WriteRawBits(uint value, int numbits) { }

	[CallerCount(Count = 0)]
	private void WriteRawBitsInternal(uint value, int numbits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteShort(short value) { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WriteUShortNetworkByteOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool WriteShortNetworkByteOrder(short value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteUInt(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WriteIntNetworkByteOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool WriteUIntNetworkByteOrder(uint value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteULong(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public bool WriteUShort(ushort value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStreamWriter), Member = "WriteShortNetworkByteOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(bool))]
	public bool WriteUShortNetworkByteOrder(ushort value) { }

}

