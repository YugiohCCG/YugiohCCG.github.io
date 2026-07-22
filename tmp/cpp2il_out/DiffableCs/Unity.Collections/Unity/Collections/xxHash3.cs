namespace Unity.Collections;

[BurstCompile]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
public static class xxHash3
{
	public static class Hash128Long_00000A82$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(xxHash3), Member = "Hash128Long", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public static void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Hash128Long_00000A82$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public Hash128Long_00000A82$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	public static class Hash64Long_00000A7B$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[CalledBy(Type = typeof(xxHash3), Member = "Hash64Long", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public static ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Hash64Long_00000A7B$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Hash64Long_00000A7B$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(Byte* input, Byte* dest, long length, Byte* secret, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override ulong EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}

	[GenerateTestsForBurstCompatibility]
	internal struct StreamingState
	{
		private struct StreamingStateData
		{
			public ulong Acc; //Field offset: 0x0
			public byte Buffer; //Field offset: 0x40
			public int IsHash64; //Field offset: 0x140
			public int BufferedSize; //Field offset: 0x144
			public int NbStripesSoFar; //Field offset: 0x148
			public long TotalLength; //Field offset: 0x150
			public ulong Seed; //Field offset: 0x158
			public byte SecretKey; //Field offset: 0x160
			public byte _PadEnd; //Field offset: 0x21C

		}

		private static readonly int SECRET_LIMIT; //Field offset: 0x0
		private static readonly int NB_STRIPES_PER_BLOCK; //Field offset: 0x4
		private static readonly int INTERNAL_BUFFER_SIZE; //Field offset: 0x8
		private static readonly int INTERNAL_BUFFER_STRIPES; //Field offset: 0xC
		private StreamingStateData State; //Field offset: 0x0

		private UInt64* Acc
		{
			[CallerCount(Count = 2063)]
			[DebuggerStepThrough]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private Byte* Buffer
		{
			[CallerCount(Count = 35)]
			[DebuggerStepThrough]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private Byte* SecretKey
		{
			[CallerCount(Count = 0)]
			[DebuggerStepThrough]
			private get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		private static StreamingState() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamingState), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ulong)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public StreamingState(bool isHash64, ulong seed = 0) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckKeySize(int isHash64) { }

		[CalledBy(Type = typeof(StreamingState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamingState), Member = "DigestLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(xxHash3), Member = "DefaultAccumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "DefaultScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		private void ConsumeStripes(UInt64* acc, ref int nbStripesSoFar, Byte* input, long totalStripes, Byte* secret, int isHash64) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StreamingState), Member = "DigestLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[Calls(Type = typeof(StreamingState), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ulong)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public uint4 DigestHash128() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[Calls(Type = typeof(StreamingState), Member = "DigestLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
		[Calls(Type = typeof(StreamingState), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ulong)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public uint2 DigestHash64() { }

		[CalledBy(Type = typeof(StreamingState), Member = "DigestHash128", ReturnType = typeof(uint4))]
		[CalledBy(Type = typeof(StreamingState), Member = "DigestHash64", ReturnType = typeof(uint2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "DefaultAccumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(xxHash3), Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		private void DigestLong(UInt64* acc, Byte* secret, int isHash64) { }

		[CallerCount(Count = 2063)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		private UInt64* get_Acc() { }

		[CallerCount(Count = 35)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		private Byte* get_Buffer() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		private Byte* get_SecretKey() { }

		[CalledBy(Type = typeof(StreamingState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ulong)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamingState), Member = "DigestHash128", ReturnType = typeof(uint4))]
		[CalledBy(Type = typeof(StreamingState), Member = "DigestHash64", ReturnType = typeof(uint2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Reset(bool isHash64, ulong seed = 0) { }

		[CalledBy(Type = typeof(StreamingState), Member = "Update", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		public void Update(Void* input, int length) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StreamingState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		public void Update(in T input) { }

	}

	private struct ulong2
	{
		public ulong x; //Field offset: 0x0
		public ulong y; //Field offset: 0x8

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public ulong2(ulong x, ulong y) { }

	}

	private const int STRIPE_LEN = 64; //Field offset: 0x0
	private const int MIDSIZE_STARTOFFSET = 3; //Field offset: 0x0
	private const int MIDSIZE_MAX = 240; //Field offset: 0x0
	private const ulong PRIME64_5 = 2870177450012600261; //Field offset: 0x0
	private const ulong PRIME64_4 = 9650029242287828579; //Field offset: 0x0
	private const ulong PRIME64_3 = 1609587929392839161; //Field offset: 0x0
	private const ulong PRIME64_2 = 14029467366897019727; //Field offset: 0x0
	private const ulong PRIME64_1 = 11400714785074694791; //Field offset: 0x0
	private const uint PRIME32_5 = 374761393; //Field offset: 0x0
	private const int MIDSIZE_LASTOFFSET = 17; //Field offset: 0x0
	private const uint PRIME32_3 = 3266489917; //Field offset: 0x0
	private const uint PRIME32_1 = 2654435761; //Field offset: 0x0
	private const int BLOCK_LEN = 1024; //Field offset: 0x0
	private const int NB_ROUNDS = 16; //Field offset: 0x0
	private const int SECRET_LASTACC_START = 7; //Field offset: 0x0
	private const int SECRET_KEY_MIN_SIZE = 136; //Field offset: 0x0
	private const int SECRET_KEY_SIZE = 192; //Field offset: 0x0
	private const int SECRET_CONSUME_RATE = 8; //Field offset: 0x0
	private const int ACC_NB = 8; //Field offset: 0x0
	private const uint PRIME32_2 = 2246822519; //Field offset: 0x0
	private const int SECRET_MERGEACCS_START = 11; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static ulong Avalanche(ulong h64) { }

	[CallerCount(Count = 0)]
	private static ulong AvalancheH64(ulong h64) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static void Avx2Accumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	[CalledBy(Type = typeof(StreamingState), Member = "DigestLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Avx2Accumulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Sse), Member = "SHUFFLE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Avx2), Member = "mm256_mul_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
	[Calls(Type = typeof(Avx2), Member = "mm256_add_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
	[CallsDeduplicatedMethods(Count = 13)]
	internal static void Avx2Accumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret) { }

	[CalledBy(Type = typeof(Hash64Long_00000A7B$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Hash128Long_00000A82$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash64Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(xxHash3), Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	internal static void Avx2HashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	[CalledBy(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Avx), Member = "mm256_set1_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(v256))]
	[Calls(Type = typeof(Avx2), Member = "mm256_srli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
	[Calls(Type = typeof(Sse), Member = "SHUFFLE", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Avx2), Member = "mm256_mul_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
	[Calls(Type = typeof(Avx2), Member = "mm256_slli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
	[Calls(Type = typeof(Avx2), Member = "mm256_add_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
	[CallsDeduplicatedMethods(Count = 9)]
	internal static void Avx2ScrambleAcc(UInt64* acc, Byte* secret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "DefaultAccumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	internal static void DefaultAccumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	[CalledBy(Type = typeof(StreamingState), Member = "DigestLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "DefaultAccumulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	internal static void DefaultAccumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret, int isHash64) { }

	[CalledBy(Type = typeof(Hash64Long_00000A7B$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Hash128Long_00000A82$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash64Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(xxHash3), Member = "DefaultAccumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "DefaultScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	private static void DefaultHashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	[CalledBy(Type = typeof(StreamingState), Member = "ConsumeStripes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Int32&), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static void DefaultScrambleAcc(UInt64* acc, Byte* secret) { }

	[CallerCount(Count = 0)]
	internal static void EncodeSecretKey(Byte* dst, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(uint4))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static uint4 Hash128(in T input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static uint4 Hash128(Void* input, long length, ulong seed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static uint4 Hash128(Void* input, Void* destination, long length) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash128", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(uint4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static uint4 Hash128(Void* input, long length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static uint4 Hash128(Void* input, Void* destination, long length, ulong seed) { }

	[CalledBy(Type = typeof(StreamingState), Member = "DigestHash128", ReturnType = typeof(uint4))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(uint4))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(uint4))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(ulong)}, ReturnType = typeof(uint4))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(ulong)}, ReturnType = typeof(uint4))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128Long_00000A82$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Len129To240", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Len17To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Hash128Len0To16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void Hash128Internal(Byte* input, Byte* dest, long length, Byte* secret, ulong seed, out uint4 result) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void Hash128Len0To16(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private static void Hash128Len129To240(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private static void Hash128Len17To128(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static void Hash128Len1To3(Byte* input, long length, Byte* secret, ulong seed, out uint4 result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void Hash128Len4To8(Byte* input, long len, Byte* secret, ulong seed, out uint4 result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void Hash128Len9To16(Byte* input, long len, Byte* secret, ulong seed, out uint4 result) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128Long_00000A82$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(Hash128Long_00000A82$PostfixBurstDelegate))]
	private static void Hash128Long(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static void Hash128Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash64", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(uint2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 1)]
	public static uint2 Hash64(Void* input, long length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(uint2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static uint2 Hash64(in T input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsUnknownMethods(Count = 1)]
	public static uint2 Hash64(Void* input, long length, ulong seed) { }

	[CalledBy(Type = typeof(StreamingState), Member = "DigestHash64", ReturnType = typeof(uint2))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(uint2))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(ulong)}, ReturnType = typeof(uint2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash64Long_00000A7B$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(xxHash3), Member = "Hash64Len17To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(xxHash3), Member = "Hash64Len0To16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static ulong Hash64Internal(Byte* input, Byte* dest, long length, Byte* secret, ulong seed) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static ulong Hash64Len0To16(Byte* input, long length, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static ulong Hash64Len129To240(Byte* input, long length, Byte* secret, ulong seed) { }

	[CalledBy(Type = typeof(xxHash3), Member = "Hash64Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private static ulong Hash64Len17To128(Byte* input, long length, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	private static ulong Hash64Len1To3(Byte* input, long len, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static ulong Hash64Len4To8(Byte* input, long length, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static ulong Hash64Len9To16(Byte* input, long length, Byte* secret, ulong seed) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash64Long_00000A7B$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[MonoPInvokeCallback(typeof(Hash64Long_00000A7B$PostfixBurstDelegate))]
	private static ulong Hash64Long(Byte* input, Byte* dest, long length, Byte* secret) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(xxHash3), Member = "DefaultHashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "Avx2HashLongInternalLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(xxHash3), Member = "MergeAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(Byte*), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static ulong Hash64Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret) { }

	[CalledBy(Type = typeof(StreamingState), Member = "DigestHash128", ReturnType = typeof(uint4))]
	[CalledBy(Type = typeof(StreamingState), Member = "DigestHash64", ReturnType = typeof(uint2))]
	[CalledBy(Type = typeof(Hash64Long_00000A7B$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Hash128Long_00000A82$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash64Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(xxHash3), Member = "Hash128Long$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(long), typeof(Byte*), typeof(uint4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 4)]
	internal static ulong MergeAcc(UInt64* acc, Byte* secret, ulong start) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ulong Mix16(Byte* input, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ulong Mix2Acc(ulong acc0, ulong acc1, Byte* secret) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static ulong2 Mix32(ulong2 acc, Byte* input_1, Byte* input_2, Byte* secret, ulong seed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ulong Mul128Fold64(ulong lhs, ulong rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong Mul32To64(uint x, uint y) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	private static uint Read32LE(Void* addr) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	private static ulong Read64LE(Void* addr) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint RotL32(uint x, int r) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong RotL64(ulong x, int r) { }

	[CallerCount(Count = 0)]
	private static ulong rrmxmx(ulong h64, ulong length) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static uint Swap32(uint x) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static ulong Swap64(ulong x) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static uint2 ToUint2(ulong u) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static uint4 ToUint4(ulong ul0, ulong ul1) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private static void Write64LE(Void* addr, ulong value) { }

	[CallerCount(Count = 0)]
	private static ulong XorShift64(ulong v64, int shift) { }

}

