namespace K4os.Hash.xxHash;

public class XXH32 : XXH
{
	private struct XXH32_state
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <mem32>e__FixedBuffer
		{
			public uint FixedElementField; //Field offset: 0x0

		}

		public uint total_len_32; //Field offset: 0x0
		public bool large_len; //Field offset: 0x4
		public uint v1; //Field offset: 0x8
		public uint v2; //Field offset: 0xC
		public uint v3; //Field offset: 0x10
		public uint v4; //Field offset: 0x14
		[FixedBuffer(typeof(uint), 4)]
		public <mem32>e__FixedBuffer mem32; //Field offset: 0x18
		public uint memsize; //Field offset: 0x28

	}

	private const uint PRIME32_1 = 2654435761; //Field offset: 0x0
	private const uint PRIME32_2 = 2246822519; //Field offset: 0x0
	private const uint PRIME32_3 = 3266489917; //Field offset: 0x0
	private const uint PRIME32_4 = 668265263; //Field offset: 0x0
	private const uint PRIME32_5 = 374761393; //Field offset: 0x0
	public const uint EmptyHash = 46947589; //Field offset: 0x0
	private XXH32_state _state; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XXH32() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public HashAlgorithm AsHashAlgorithm() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public uint Digest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public Byte[] DigestBytes() { }

	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL+cParams_t", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K4os.Compression.LZ4.Engine.LL+lz4hc_strat_e", typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.Internal.LZ4StreamBase", Member = "DigestOfStash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.DateTimeResult", Member = "SetDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Vector3Int", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.bool4x3", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.bool4", "Unity.Mathematics.bool4", "Unity.Mathematics.bool4"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.int3", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.uint3", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.OutputBuffer+BufferState", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static uint DigestOf(ReadOnlySpan<Byte> bytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	public static uint DigestOf(Void* bytes, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static uint DigestOf(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH32_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	public void Update(Byte* bytes, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH32_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update(ReadOnlySpan<Byte> bytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH32), Member = "XXH32_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH32_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Update(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static uint XXH32_digest(XXH32_state* state) { }

	[CalledBy(Type = typeof(XXH32), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(XXH32), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(XXH32), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	private static uint XXH32_hash(Void* input, int len, uint seed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void XXH32_reset(XXH32_state* state, uint seed) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint XXH32_rotl(uint x, int r) { }

	[CallerCount(Count = 0)]
	private static uint XXH32_round(uint seed, uint input) { }

	[CalledBy(Type = typeof(XXH32), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XXH32), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XXH32), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void XXH32_update(XXH32_state* state, Void* input, int len) { }

}

