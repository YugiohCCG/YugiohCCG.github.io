namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[GenerateTestsForBurstCompatibility]
[NativeContainer]
public struct NativeBitArray : INativeDisposable, IDisposable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		internal ReadOnly m_BitArray; //Field offset: 0x0

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

		public int Length
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		internal ReadOnly(ref NativeBitArray data) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void CheckRead() { }

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

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Length() { }

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
	internal UnsafeBitArray* m_BitArray; //Field offset: 0x0
	internal AllocatorHandle m_Allocator; //Field offset: 0x8

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[IsReadOnly]
		 get { } //Length: 25
	}

	public bool IsCreated
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		 get { } //Length: 20
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[IsReadOnly]
		 get { } //Length: 26
	}

	public int Length
	{
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public NativeBitArray(int numBits, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public NativeArray<T> AsNativeArray() { }

	[CallerCount(Count = 0)]
	public ReadOnly AsReadOnly() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckRead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void CheckReadBounds() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "AlignUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void Copy(int dstPos, int srcPos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void Copy(int dstPos, ref NativeBitArray srcBitArray, int srcPos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int CountBits(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBitArrayDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBitArrayDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int Find(int pos, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int Find(int pos, int count, int numBits) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	public ulong GetBits(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int)}, ReturnType = typeof(bool))]
	public bool IsSet(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void Resize(int numBits, NativeArrayOptions options = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(int pos, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void SetBits(int pos, bool value, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void SetCapacity(int capacityInBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	public bool TestAll(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	public bool TestAny(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	public bool TestNone(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void TrimExcess() { }

}

