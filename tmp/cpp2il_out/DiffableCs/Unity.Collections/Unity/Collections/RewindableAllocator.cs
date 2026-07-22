namespace Unity.Collections;

[BurstCompile]
public struct RewindableAllocator : IAllocator, IDisposable
{
	[GenerateTestsForBurstCompatibility]
	public struct MemoryBlock : IDisposable
	{
		public const int kMaximumAlignment = 16384; //Field offset: 0x0
		public Byte* m_pointer; //Field offset: 0x0
		public long m_bytes; //Field offset: 0x8
		public Union m_union; //Field offset: 0x10

		[CalledBy(Type = typeof(RewindableAllocator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		public MemoryBlock(long bytes) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool Contains(IntPtr ptr) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		public void Rewind() { }

	}

	public static class Try_000009F0$BurstDirectCall
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public static int Invoke(IntPtr state, ref Block block) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Try_000009F0$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Try_000009F0$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(IntPtr state, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(IntPtr state, ref Block block) { }

	}

	public struct Union
	{
		private const int currentBits = 40; //Field offset: 0x0
		private const int currentOffset = 0; //Field offset: 0x0
		private const long currentMask = 1099511627775; //Field offset: 0x0
		private const int allocCountBits = 24; //Field offset: 0x0
		private const int allocCountOffset = 40; //Field offset: 0x0
		private const long allocCountMask = 16777215; //Field offset: 0x0
		internal long m_long; //Field offset: 0x0

		internal long m_allocCount
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 13
			[CallerCount(Count = 0)]
			internal set { } //Length: 21
		}

		internal long m_current
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 17
			[CallerCount(Count = 0)]
			internal set { } //Length: 26
		}

		[CallerCount(Count = 0)]
		internal long get_m_allocCount() { }

		[CallerCount(Count = 0)]
		internal long get_m_current() { }

		[CallerCount(Count = 0)]
		internal void set_m_allocCount(long value) { }

		[CallerCount(Count = 0)]
		internal void set_m_current(long value) { }

	}

	private const int kLog2MaxMemoryBlockSize = 26; //Field offset: 0x0
	private const long kMaxMemoryBlockSize = 67108864; //Field offset: 0x0
	private const long kMinMemoryBlockSize = 131072; //Field offset: 0x0
	private const int kMaxNumBlocks = 64; //Field offset: 0x0
	private const int kBlockBusyRewindMask = -2147483648; //Field offset: 0x0
	private const int kBlockBusyAllocateMask = 2147483647; //Field offset: 0x0
	private Spinner m_spinner; //Field offset: 0x0
	private AllocatorHandle m_handle; //Field offset: 0x4
	private UnmanagedArray<MemoryBlock> m_block; //Field offset: 0x8
	private int m_last; //Field offset: 0x18
	private int m_used; //Field offset: 0x1C
	private byte m_enableBlockFree; //Field offset: 0x20
	private byte m_reachMaxBlockSize; //Field offset: 0x21

	public int BlocksAllocated
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	internal long BytesAllocated
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 113
	}

	public bool EnableBlockFree
	{
		[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "get_EnableBlockFree", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
		[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "set_EnableBlockFree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 set { } //Length: 6
	}

	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	public override TryFunction Function
	{
		[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 90
	}

	public override AllocatorHandle Handle
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int InitialSizeInBytes
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 57
	}

	public override bool IsAutoDispose
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsCustomAllocator
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 11
	}

	internal long MaxMemoryBlockSize
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 6
	}

	public override Allocator ToAllocator
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public NativeArray<T> AllocateNativeArray(int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public NativeList<T> AllocateNativeList(int capacity) { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RewindableAllocator), Member = "Rewind", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.UnmanagedArray`1<Unity.Collections.RewindableAllocator+MemoryBlock>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	public int get_BlocksAllocated() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal long get_BytesAllocated() { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "get_EnableBlockFree", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_EnableBlockFree() { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override TryFunction get_Function() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override AllocatorHandle get_Handle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int get_InitialSizeInBytes() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsAutoDispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsCustomAllocator() { }

	[CallerCount(Count = 0)]
	internal long get_MaxMemoryBlockSize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Allocator get_ToAllocator() { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.UnmanagedArray`1<Unity.Collections.RewindableAllocator+MemoryBlock>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Initialize(int initialSizeInBytes, bool enableBlockFree = false) { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RewindableAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void Rewind() { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "set_EnableBlockFree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public void set_EnableBlockFree(bool value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override void set_Handle(AllocatorHandle value) { }

	[CalledBy(Type = typeof(Try_000009F0$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Block), Member = "get_Alignment", ReturnType = typeof(int))]
	[Calls(Type = typeof(Block), Member = "get_Bytes", ReturnType = typeof(long))]
	[Calls(Type = typeof(RewindableAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int), typeof(int), typeof(long), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override int Try(ref Block block) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try(IntPtr state, ref Block block) { }

	[BurstCompile]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try$BurstManaged(IntPtr state, ref Block block) { }

	[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Block), Member = "get_Bytes", ReturnType = typeof(long))]
	[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	private int TryAllocate(ref Block block, int startIndex, int lastIndex, long alignedSize, long alignmentMask) { }

}

