namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public struct StreamCompressionModel
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <bucketOffsets>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <bucketSizes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <decodeTable>e__FixedBuffer
	{
		public ushort FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <encodeTable>e__FixedBuffer
	{
		public ushort FixedElementField; //Field offset: 0x0

	}

	private static class SharedStaticCompressionModel
	{
		internal static readonly SharedStatic<StreamCompressionModel> Default; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.StreamCompressionModel>), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.StreamCompressionModel>))]
		private static SharedStaticCompressionModel() { }

	}

	internal static readonly Byte[] k_BucketSizes; //Field offset: 0x0
	internal const int k_AlphabetSize = 16; //Field offset: 0x0
	internal const int k_MaxHuffmanSymbolLength = 6; //Field offset: 0x0
	internal const int k_MaxContexts = 1; //Field offset: 0x0
	internal static readonly UInt32[] k_BucketOffsets; //Field offset: 0x8
	internal static readonly Int32[] k_FirstBucketCandidate; //Field offset: 0x10
	internal static readonly Byte[] k_DefaultModelData; //Field offset: 0x18
	private byte m_Initialized; //Field offset: 0x0
	[FixedBuffer(typeof(ushort), 16)]
	internal <encodeTable>e__FixedBuffer encodeTable; //Field offset: 0x2
	[FixedBuffer(typeof(ushort), 64)]
	internal <decodeTable>e__FixedBuffer decodeTable; //Field offset: 0x22
	[FixedBuffer(typeof(byte), 16)]
	internal <bucketSizes>e__FixedBuffer bucketSizes; //Field offset: 0xA2
	[FixedBuffer(typeof(uint), 16)]
	internal <bucketOffsets>e__FixedBuffer bucketOffsets; //Field offset: 0xB4

	public static StreamCompressionModel Default
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamCompressionModel), Member = "Initialize", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		 get { } //Length: 421
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static StreamCompressionModel() { }

	[CalledBy(Type = typeof(DataStreamWriter), Member = "WritePackedUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StreamCompressionModel&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StreamCompressionModel), Member = "GetCompressedSizeInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public int CalculateBucket(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckAlphabetAndMaxCodeLength(int alphabetSize, int maxCodeLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckAlphabetSize(int alphabetSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckExceedMaxCodeLength(int length, int maxCodeLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckSymbolLength(NativeArray<Byte> symbolLengths, int symbolLengthsOffset, int symbol, int length) { }

	[CalledBy(Type = typeof(StreamCompressionModel), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private static void GenerateHuffmanCodes(NativeArray<Byte> symbolCodes, int symbolCodesOffset, NativeArray<Byte> symbolLengths, int symbolLengthsOffset, int alphabetSize, int maxCodeLength) { }

	[CallerCount(Count = 0)]
	private static void GenerateHuffmanDecodeTable(NativeArray<UInt16> decodeTable, int decodeTableOffset, NativeArray<Byte> symbolLengths, NativeArray<Byte> symbolCodes, int alphabetSize, int maxCodeLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamCompressionModel), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public static StreamCompressionModel get_Default() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamCompressionModel), Member = "CalculateBucket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[IsReadOnly]
	public int GetCompressedSizeInBits(uint value) { }

	[CalledBy(Type = typeof(StreamCompressionModel), Member = "get_Default", ReturnType = typeof(StreamCompressionModel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamCompressionModel), Member = "GenerateHuffmanCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static void Initialize() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static uint ReverseBits(uint value, int num_bits) { }

}

