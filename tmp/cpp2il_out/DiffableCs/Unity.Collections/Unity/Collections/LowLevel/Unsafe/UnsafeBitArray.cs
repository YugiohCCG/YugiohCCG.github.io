namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[GenerateTestsForBurstCompatibility]
public struct UnsafeBitArray : INativeDisposable, IDisposable
{
	internal struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly UInt64* Ptr; //Field offset: 0x0
		public readonly int Length; //Field offset: 0x8

		public bool IsCreated
		{
			[CallerCount(Count = 19)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public bool IsEmpty
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 17
		}

		[CallerCount(Count = 371)]
		[DeduplicatedMethod]
		internal ReadOnly(UInt64* ptr, int length) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		private void CheckArgs(int pos, int numBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 13)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		private void CheckArgsPosCount(int begin, int count, int numBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 8)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		private void CheckArgsUlong(int pos, int numBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int CountBits(int pos, int numBits = 1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int Find(int pos, int numBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int Find(int pos, int count, int numBits) { }

		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ulong GetBits(int pos, int numBits = 1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool IsSet(int pos) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TestAll(int pos, int numBits = 1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TestAny(int pos, int numBits = 1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TestNone(int pos, int numBits = 1) { }

	}

	public const int MaxCapacity = 2147483584; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	public UInt64* Ptr; //Field offset: 0x0
	public int Length; //Field offset: 0x8
	public int Capacity; //Field offset: 0xC
	public AllocatorHandle Allocator; //Field offset: 0x10

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	public UnsafeBitArray(Void* ptr, int sizeInBytes, AllocatorHandle allocator = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public UnsafeBitArray(int numBits, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static UnsafeBitArray* Alloc(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ReadOnly AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckArgs(int pos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckArgsCopy(ref UnsafeBitArray dstBitArray, int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 13)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckArgsPosCount(int begin, int count, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckArgsUlong(int pos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckSizeMultipleOf8(int sizeInBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "AlignUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void Copy(int dstPos, int srcPos, int numBits) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionHelper), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "CopyUlong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Bitwise), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public void Copy(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Bitwise), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	internal void CopyUlong(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int CountBits(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "ShouldDeallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeBitArray*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionHelper), Member = "ShouldDeallocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int Find(int pos, int count, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int Find(int pos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void Free(UnsafeBitArray* data, AllocatorHandle allocator) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	public ulong GetBits(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool IsSet(int pos) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "TrimExcess", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Bitwise), Member = "AlignUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Realloc(int capacityInBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void Resize(int numBits, NativeArrayOptions options = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(int pos, bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Set(UInt64* ptr, int pos, bool value) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetBits(int pos, bool value, int numBits) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "CopyUlong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Bitwise), Member = "ReplaceBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void SetCapacity(int capacityInBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool TestAll(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool TestAny(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool TestNone(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void TrimExcess() { }

}

