namespace K4os.Hash.xxHash;

public class XXH64 : XXH
{
	private struct XXH64_state
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <mem64>e__FixedBuffer
		{
			public ulong FixedElementField; //Field offset: 0x0

		}

		public ulong total_len; //Field offset: 0x0
		public ulong v1; //Field offset: 0x8
		public ulong v2; //Field offset: 0x10
		public ulong v3; //Field offset: 0x18
		public ulong v4; //Field offset: 0x20
		[FixedBuffer(typeof(ulong), 4)]
		public <mem64>e__FixedBuffer mem64; //Field offset: 0x28
		public uint memsize; //Field offset: 0x48

	}

	private const ulong PRIME64_1 = 11400714785074694791; //Field offset: 0x0
	private const ulong PRIME64_2 = 14029467366897019727; //Field offset: 0x0
	private const ulong PRIME64_3 = 1609587929392839161; //Field offset: 0x0
	private const ulong PRIME64_4 = 9650029242287828579; //Field offset: 0x0
	private const ulong PRIME64_5 = 2870177450012600261; //Field offset: 0x0
	public const ulong EmptyHash = 17241709254077376921; //Field offset: 0x0
	private XXH64_state _state; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XXH64() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public HashAlgorithm AsHashAlgorithm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_digest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH64_state*)}, ReturnType = typeof(ulong))]
	public ulong Digest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_digest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH64_state*)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Byte[]))]
	public Byte[] DigestBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(ulong)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static ulong DigestOf(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(ulong)}, ReturnType = typeof(ulong))]
	public static ulong DigestOf(Void* bytes, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ulong DigestOf(ReadOnlySpan<Byte> bytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH64_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	public void Update(Byte* bytes, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH64_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update(ReadOnlySpan<Byte> bytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XXH64), Member = "XXH64_update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XXH64_state*), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Update(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static ulong XXH_rotl64(ulong x, int r) { }

	[CalledBy(Type = typeof(XXH64), Member = "Digest", ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(XXH64), Member = "DigestBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static ulong XXH64_digest(XXH64_state* state) { }

	[CalledBy(Type = typeof(XXH64), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(XXH64), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(XXH64), Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 3)]
	private static ulong XXH64_hash(Void* input, int len, ulong seed) { }

	[CallerCount(Count = 0)]
	private static ulong XXH64_mergeRound(ulong acc, ulong val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void XXH64_reset(XXH64_state* state, ulong seed) { }

	[CallerCount(Count = 0)]
	private static ulong XXH64_round(ulong acc, ulong input) { }

	[CalledBy(Type = typeof(XXH64), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XXH64), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XXH64), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void XXH64_update(XXH64_state* state, Void* input, int len) { }

}

