namespace K4os.Compression.LZ4.Engine;

internal class LL
{
	internal struct cParams_t
	{
		public lz4hc_strat_e strat; //Field offset: 0x0
		public uint nbSearches; //Field offset: 0x4
		public uint targetLength; //Field offset: 0x8

		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Stash), Member = "AsSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Span`1<System.Byte>))]
		[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = typeof(XXH32), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(uint))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public cParams_t(lz4hc_strat_e strat, uint nbSearches, uint targetLength) { }

	}

	internal enum dict_directive
	{
		noDict = 0,
		withPrefix64k = 1,
		usingExtDict = 2,
		usingDictCtx = 3,
	}

	internal enum dictCtx_directive
	{
		noDictCtx = 0,
		usingDictCtxHc = 1,
	}

	internal enum dictIssue_directive
	{
		noDictIssue = 0,
		dictSmall = 1,
	}

	internal enum earlyEnd_directive
	{
		full = 0,
		partial = 1,
	}

	internal enum endCondition_directive
	{
		endOnOutputSize = 0,
		endOnInputSize = 1,
	}

	internal enum HCfavor_e
	{
		favorCompressionRatio = 0,
		favorDecompressionSpeed = 1,
	}

	internal enum limitedOutput_directive
	{
		notLimited = 0,
		limitedOutput = 1,
		fillOutput = 2,
	}

	internal struct LZ4_stream_t
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <hashTable>e__FixedBuffer
		{
			public uint FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(uint), 4096)]
		public <hashTable>e__FixedBuffer hashTable; //Field offset: 0x0
		public uint currentOffset; //Field offset: 0x4000
		public bool dirty; //Field offset: 0x4004
		public tableType_t tableType; //Field offset: 0x4008
		public Byte* dictionary; //Field offset: 0x4010
		public LZ4_stream_t* dictCtx; //Field offset: 0x4018
		public uint dictSize; //Field offset: 0x4020

	}

	internal struct LZ4_streamDecode_t
	{
		public Byte* externalDict; //Field offset: 0x0
		public uint extDictSize; //Field offset: 0x8
		public Byte* prefixEnd; //Field offset: 0x10
		public uint prefixSize; //Field offset: 0x18

	}

	internal struct LZ4_streamHC_t
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <chainTable>e__FixedBuffer
		{
			public ushort FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <hashTable>e__FixedBuffer
		{
			public uint FixedElementField; //Field offset: 0x0

		}

		[FixedBuffer(typeof(uint), 32768)]
		public <hashTable>e__FixedBuffer hashTable; //Field offset: 0x0
		[FixedBuffer(typeof(ushort), 65536)]
		public <chainTable>e__FixedBuffer chainTable; //Field offset: 0x20000
		public Byte* end; //Field offset: 0x40000
		public Byte* base; //Field offset: 0x40008
		public Byte* dictBase; //Field offset: 0x40010
		public uint dictLimit; //Field offset: 0x40018
		public uint lowLimit; //Field offset: 0x4001C
		public uint nextToUpdate; //Field offset: 0x40020
		public short compressionLevel; //Field offset: 0x40024
		public bool favorDecSpeed; //Field offset: 0x40026
		public bool dirty; //Field offset: 0x40027
		public LZ4_streamHC_t* dictCtx; //Field offset: 0x40028

	}

	internal struct LZ4HC_match_t
	{
		public int off; //Field offset: 0x0
		public int len; //Field offset: 0x4

	}

	internal struct LZ4HC_optimal_t
	{
		public int price; //Field offset: 0x0
		public int off; //Field offset: 0x4
		public int mlen; //Field offset: 0x8
		public int litlen; //Field offset: 0xC

	}

	internal enum lz4hc_strat_e
	{
		lz4hc = 0,
		lz4opt = 1,
	}

	internal enum repeat_state_e
	{
		rep_untested = 0,
		rep_not = 1,
		rep_confirmed = 2,
	}

	internal enum tableType_t
	{
		clearedTable = 0,
		byPtr = 1,
		byU32 = 2,
		byU16 = 3,
	}

	internal enum variable_length_error
	{
		loop_error = -2,
		initial_error = -1,
		ok = 0,
	}

	[CompilerGenerated]
	private static bool <Enforce32>k__BackingField; //Field offset: 0x0
	protected const uint GB = 1073741824; //Field offset: 0x0
	protected const int ML_BITS = 4; //Field offset: 0x0
	protected const uint ML_MASK = 15; //Field offset: 0x0
	protected const int RUN_BITS = 4; //Field offset: 0x0
	protected const uint RUN_MASK = 15; //Field offset: 0x0
	protected const int OPTIMAL_ML = 18; //Field offset: 0x0
	protected const int LZ4_OPT_NUM = 4096; //Field offset: 0x0
	protected const int LZ4_64Klimit = 65547; //Field offset: 0x0
	protected const int LZ4_skipTrigger = 6; //Field offset: 0x0
	protected const int LZ4HC_DICTIONARY_LOGSIZE = 16; //Field offset: 0x0
	protected const int LZ4HC_MAXD = 65536; //Field offset: 0x0
	protected const int LZ4HC_MAXD_MASK = 65535; //Field offset: 0x0
	protected const int LZ4HC_HASH_LOG = 15; //Field offset: 0x0
	protected const int LZ4HC_HASHTABLESIZE = 32768; //Field offset: 0x0
	protected const int LZ4HC_HASH_MASK = 32767; //Field offset: 0x0
	protected const int LZ4HC_CLEVEL_MIN = 3; //Field offset: 0x0
	protected const int LZ4HC_CLEVEL_DEFAULT = 9; //Field offset: 0x0
	protected const int MB = 1048576; //Field offset: 0x0
	protected const int LZ4HC_CLEVEL_OPT_MIN = 10; //Field offset: 0x0
	protected const int KB = 1024; //Field offset: 0x0
	protected const int FASTLOOP_SAFE_DISTANCE = 64; //Field offset: 0x0
	protected const int LZ4_MEMORY_USAGE = 14; //Field offset: 0x0
	protected const int LZ4_MAX_INPUT_SIZE = 2113929216; //Field offset: 0x0
	protected const int LZ4_DISTANCE_MAX = 65535; //Field offset: 0x0
	protected const int LZ4_DISTANCE_ABSOLUTE_MAX = 65535; //Field offset: 0x0
	protected const int LZ4_minLength = 13; //Field offset: 0x0
	protected const int LZ4_HASHTABLESIZE = 16384; //Field offset: 0x0
	protected const int LZ4_HASHLOG = 12; //Field offset: 0x0
	protected const int ACCELERATION_DEFAULT = 1; //Field offset: 0x0
	protected const int MINMATCH = 4; //Field offset: 0x0
	protected const int WILDCOPYLENGTH = 8; //Field offset: 0x0
	protected const int LASTLITERALS = 5; //Field offset: 0x0
	protected const int MFLIMIT = 12; //Field offset: 0x0
	protected const int MATCH_SAFEGUARD_DISTANCE = 12; //Field offset: 0x0
	protected const int LZ4_HASH_SIZE_U32 = 4096; //Field offset: 0x0
	protected const int LZ4HC_CLEVEL_MAX = 12; //Field offset: 0x0
	private static readonly UInt32[] _inc32table; //Field offset: 0x8
	private static readonly Int32[] _dec64table; //Field offset: 0x10
	protected static readonly UInt32* inc32table; //Field offset: 0x18
	protected static readonly Int32* dec64table; //Field offset: 0x20

	public static Algorithm Algorithm
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 171
	}

	public static bool Enforce32
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mem), Member = "CloneAnyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(Mem), Member = "CloneAnyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 2)]
	private static LL() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LL() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("DEBUG")]
	public static void Assert(bool condition, string message = null) { }

	[CallerCount(Count = 0)]
	protected static ushort DELTANEXTU16(UInt16* table, uint pos) { }

	[CallerCount(Count = 0)]
	public static Algorithm get_Algorithm() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_Enforce32() { }

	[CallerCount(Count = 0)]
	private static uint HASH_FUNCTION(uint value) { }

	[CallerCount(Count = 0)]
	protected static void LZ4_clearHash(uint h, Void* tableBase, tableType_t tableType) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static int LZ4_compressBound(int isize) { }

	[CalledBy(Type = typeof(LZ4Encoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateFastEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4Stream+<>c__DisplayClass1_0", Member = "<Encode>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Descriptor)}, ReturnType = typeof(ILZ4Encoder))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static LZ4_stream_t* LZ4_createStream() { }

	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4Decoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Decoder))]
	[CalledBy(Type = typeof(LZ4Decoder), Member = "CreateChainDecoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Decoder))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static LZ4_streamDecode_t* LZ4_createStreamDecode() { }

	[CalledBy(Type = typeof(LZ4Encoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateHighEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4Stream+<>c__DisplayClass1_0", Member = "<Encode>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Descriptor)}, ReturnType = typeof(ILZ4Encoder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	public static LZ4_streamHC_t* LZ4_createStreamHC() { }

	[CallerCount(Count = 0)]
	internal static int LZ4_decoderRingBufferSize(int isize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void LZ4_favorDecompressionSpeed(LZ4_streamHC_t* LZ4_streamHCPtr, int favor) { }

	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public static void LZ4_freeStream(LZ4_stream_t* LZ4_stream) { }

	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public static void LZ4_freeStreamDecode(LZ4_streamDecode_t* LZ4_stream) { }

	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = "ReleaseUnmanaged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public static int LZ4_freeStreamHC(LZ4_streamHC_t* LZ4_streamHCPtr) { }

	[CallerCount(Count = 0)]
	protected static uint LZ4_getIndexOnHash(uint h, Void* tableBase, tableType_t tableType) { }

	[CallerCount(Count = 0)]
	protected static Byte* LZ4_getPositionOnHash(uint h, Void* tableBase, tableType_t tableType, Byte* srcBase) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected static uint LZ4_hash4(uint sequence, tableType_t tableType) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	protected static uint LZ4_hash5(ulong sequence, tableType_t tableType) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_fast_extState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_loadDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_fast_extState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_loadDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static LZ4_stream_t* LZ4_initStream(LZ4_stream_t* buffer) { }

	[CalledBy(Type = typeof(LL), Member = "LZ4_createStreamHC", ReturnType = typeof(LZ4_streamHC_t*))]
	[CalledBy(Type = typeof(LL), Member = "LZ4_resetStreamHC_fast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LL), Member = "LZ4_loadDictHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC_extStateHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	public static LZ4_streamHC_t* LZ4_initStreamHC(LZ4_streamHC_t* stream) { }

	[CallerCount(Count = 0)]
	public static LZ4_streamHC_t* LZ4_initStreamHC(Void* buffer, int size) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	[Calls(Type = typeof(LL), Member = "LZ4HC_init_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static int LZ4_loadDictHC(LZ4_streamHC_t* LZ4_streamHCPtr, Byte* dictionary, int dictSize) { }

	[CallerCount(Count = 0)]
	protected static void LZ4_putIndexOnHash(uint idx, uint h, Void* tableBase, tableType_t tableType) { }

	[CallerCount(Count = 0)]
	protected static void LZ4_putPositionOnHash(Byte* p, uint h, Void* tableBase, tableType_t tableType, Byte* srcBase) { }

	[CallerCount(Count = 0)]
	protected static uint LZ4_readVLE(Byte** ip, Byte* lencheck, bool loop_check, bool initial_check, variable_length_error* error) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4Encoder), Member = "CreateHighEncoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(ILZ4Encoder))]
	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4Level), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4Stream+<>c__DisplayClass1_0", Member = "<Encode>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILZ4Descriptor)}, ReturnType = typeof(ILZ4Encoder))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LL), Member = "LZ4_initStreamHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*)}, ReturnType = typeof(LZ4_streamHC_t*))]
	[CallsUnknownMethods(Count = 1)]
	public static void LZ4_resetStreamHC_fast(LZ4_streamHC_t* LZ4_streamHCPtr, int compressionLevel) { }

	[CalledBy(Type = typeof(LZ4FastChainEncoder), Member = "CopyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_saveDict(LZ4_stream_t* LZ4_dict, Byte* safeBuffer, int dictSize) { }

	[CalledBy(Type = typeof(LZ4HighChainEncoder), Member = "CopyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static int LZ4_saveDictHC(LZ4_streamHC_t* LZ4_streamHCPtr, Byte* safeBuffer, int dictSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void LZ4_setCompressionLevel(LZ4_streamHC_t* LZ4_streamHCPtr, int compressionLevel) { }

	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "CopyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LZ4ChainDecoder), Member = "ApplyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void LZ4_setStreamDecode(LZ4_streamDecode_t* LZ4_streamDecode, Byte* dictionary, int dictSize) { }

	[CallerCount(Count = 0)]
	public static int LZ4_sizeofStateHC() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void LZ4HC_clearTables(LZ4_streamHC_t* hc4) { }

	[CallerCount(Count = 0)]
	public static int LZ4HC_countBack(Byte* ip, Byte* match, Byte* iMin, Byte* mMin) { }

	[CallerCount(Count = 0)]
	public static uint LZ4HC_hashPtr(Void* ptr) { }

	[CalledBy(Type = typeof(LL), Member = "LZ4_loadDictHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC_destSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compress_HC_extStateHC_fastReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	public static void LZ4HC_init_internal(LZ4_streamHC_t* hc4, Byte* start) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void LZ4HC_Insert(LZ4_streamHC_t* hc4, Byte* ip) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_literalsPrice(int litlen) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool LZ4HC_protectDictEnd(uint dictLimit, uint matchIndex) { }

	[CallerCount(Count = 0)]
	public static uint LZ4HC_reverseCountPattern(Byte* ip, Byte* iLow, uint pattern) { }

	[CallerCount(Count = 0)]
	public static uint LZ4HC_rotatePattern(uint rotate, uint pattern) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint LZ4HC_rotl32(uint x, int r) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int LZ4HC_sequencePrice(int litlen, int mlen) { }

	[CalledBy(Type = typeof(LL32), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL32), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4HC_compress_generic_dictCtx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LL64), Member = "LZ4_compressHC_continue_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_streamHC_t*), typeof(Byte*), typeof(Byte*), typeof(Int32*), typeof(int), typeof(limitedOutput_directive)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void LZ4HC_setExternalDict(LZ4_streamHC_t* ctxPtr, Byte* newBlock) { }

	[CallerCount(Count = 0)]
	public static long MAX(long a, long b) { }

	[CallerCount(Count = 0)]
	public static uint MAX(uint a, uint b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static long MIN(long a, long b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint MIN(uint a, uint b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int MIN(int a, int b) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_Enforce32(bool value) { }

}

