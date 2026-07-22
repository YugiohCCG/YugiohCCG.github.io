namespace Unity.Collections;

[Extension]
public static class AllocatorManager
{
	private static class AllocatorCache
	{
		public static FunctionPointer<TryFunction> TryFunction; //Field offset: 0x0
		public static TryFunction CachedFunction; //Field offset: 0x0

	}

	internal struct AllocatorHandle : IAllocator, IDisposable, IEquatable<AllocatorHandle>, IComparable<AllocatorHandle>
	{
		public ushort Index; //Field offset: 0x0
		public ushort Version; //Field offset: 0x2

		public override TryFunction Function
		{
			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public override AllocatorHandle Handle
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override bool IsAutoDispose
		{
			[CalledBy(Type = typeof(NativeArrayExtensions), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 174
		}

		public override bool IsCustomAllocator
		{
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		internal bool IsInstalled
		{
			[CalledBy(Type = typeof(AllocatorManager), Member = "UnmanagedUnregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 174
		}

		internal TableEntry TableEntry
		{
			[CalledBy(Type = typeof(AllocatorHandle), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableEntry)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "forward_mono_allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal get { } //Length: 131
		}

		public override Allocator ToAllocator
		{
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			 get { } //Length: 13
		}

		public int Value
		{
			[CallerCount(Count = 10)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Block AllocateBlock(int items) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private static void CheckAllocatedSuccessfully(int error) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public override int CompareTo(AllocatorHandle other) { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool Equals(Allocator other) { }

		[CallerCount(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Equals(AllocatorHandle other) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public override TryFunction get_Function() { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public override AllocatorHandle get_Handle() { }

		[CalledBy(Type = typeof(NativeArrayExtensions), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override bool get_IsAutoDispose() { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool get_IsCustomAllocator() { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "UnmanagedUnregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool get_IsInstalled() { }

		[CalledBy(Type = typeof(AllocatorHandle), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableEntry)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "forward_mono_allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal TableEntry get_TableEntry() { }

		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		public override Allocator get_ToAllocator() { }

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		public int get_Value() { }

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void IncrementVersion() { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "UnmanagedUnregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
		internal void Install(TableEntry tableEntry) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool op_Equality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public static bool op_GreaterThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public static bool op_GreaterThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 192)]
		public static AllocatorHandle op_Implicit(Allocator a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool op_Inequality(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public static bool op_LessThan(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public static bool op_LessThanOrEqual(AllocatorHandle lhs, AllocatorHandle rhs) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void Rewind() { }

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public override void set_Handle(AllocatorHandle value) { }

		[CalledBy(Type = typeof(AllocatorHandle), Member = "TryAllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		public override int Try(ref Block block) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AllocatorHandle), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public int TryAllocateBlock(out Block block, int items) { }

	}

	public struct Array16
	{
		internal T f0; //Field offset: 0x0
		internal T f1; //Field offset: 0x0
		internal T f2; //Field offset: 0x0
		internal T f3; //Field offset: 0x0
		internal T f4; //Field offset: 0x0
		internal T f5; //Field offset: 0x0
		internal T f6; //Field offset: 0x0
		internal T f7; //Field offset: 0x0
		internal T f8; //Field offset: 0x0
		internal T f9; //Field offset: 0x0
		internal T f10; //Field offset: 0x0
		internal T f11; //Field offset: 0x0
		internal T f12; //Field offset: 0x0
		internal T f13; //Field offset: 0x0
		internal T f14; //Field offset: 0x0
		internal T f15; //Field offset: 0x0

	}

	public struct Array256
	{
		internal Array16<T> f0; //Field offset: 0x0
		internal Array16<T> f1; //Field offset: 0x0
		internal Array16<T> f2; //Field offset: 0x0
		internal Array16<T> f3; //Field offset: 0x0
		internal Array16<T> f4; //Field offset: 0x0
		internal Array16<T> f5; //Field offset: 0x0
		internal Array16<T> f6; //Field offset: 0x0
		internal Array16<T> f7; //Field offset: 0x0
		internal Array16<T> f8; //Field offset: 0x0
		internal Array16<T> f9; //Field offset: 0x0
		internal Array16<T> f10; //Field offset: 0x0
		internal Array16<T> f11; //Field offset: 0x0
		internal Array16<T> f12; //Field offset: 0x0
		internal Array16<T> f13; //Field offset: 0x0
		internal Array16<T> f14; //Field offset: 0x0
		internal Array16<T> f15; //Field offset: 0x0

	}

	public struct Array32768 : IIndexable<T>
	{
		internal Array4096<T> f0; //Field offset: 0x0
		internal Array4096<T> f1; //Field offset: 0x0
		internal Array4096<T> f2; //Field offset: 0x0
		internal Array4096<T> f3; //Field offset: 0x0
		internal Array4096<T> f4; //Field offset: 0x0
		internal Array4096<T> f5; //Field offset: 0x0
		internal Array4096<T> f6; //Field offset: 0x0
		internal Array4096<T> f7; //Field offset: 0x0

		public override int Length
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public override T ElementAt(int index) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override int get_Length() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void set_Length(int value) { }

	}

	public struct Array4096
	{
		internal Array256<T> f0; //Field offset: 0x0
		internal Array256<T> f1; //Field offset: 0x0
		internal Array256<T> f2; //Field offset: 0x0
		internal Array256<T> f3; //Field offset: 0x0
		internal Array256<T> f4; //Field offset: 0x0
		internal Array256<T> f5; //Field offset: 0x0
		internal Array256<T> f6; //Field offset: 0x0
		internal Array256<T> f7; //Field offset: 0x0
		internal Array256<T> f8; //Field offset: 0x0
		internal Array256<T> f9; //Field offset: 0x0
		internal Array256<T> f10; //Field offset: 0x0
		internal Array256<T> f11; //Field offset: 0x0
		internal Array256<T> f12; //Field offset: 0x0
		internal Array256<T> f13; //Field offset: 0x0
		internal Array256<T> f14; //Field offset: 0x0
		internal Array256<T> f15; //Field offset: 0x0

	}

	internal struct Block : IDisposable
	{
		public Range Range; //Field offset: 0x0
		public int BytesPerItem; //Field offset: 0x10
		public int AllocatedItems; //Field offset: 0x14
		public byte Log2Alignment; //Field offset: 0x18
		public byte Padding0; //Field offset: 0x19
		public ushort Padding1; //Field offset: 0x1A
		public uint Padding2; //Field offset: 0x1C

		public int Alignment
		{
			[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			 get { } //Length: 12
			[CalledBy(Type = typeof(AllocatorHandle), Member = "TryAllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
			[CalledBy(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Array), Member = "CustomResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
			[CalledBy(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
			[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(NativeReferenceDispose), Member = "Dispose", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(MemoryBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*), typeof(int)}, ReturnType = typeof(UnsafeStreamBlock*))]
			[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[ContainsUnimplementedInstructions]
			 set { } //Length: 98
		}

		public long AllocatedBytes
		{
			[CalledBy(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			 get { } //Length: 13
		}

		public long Bytes
		{
			[CalledBy(Type = typeof(RewindableAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int), typeof(int), typeof(long), typeof(long)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallerCount(Count = 2)]
			 get { } //Length: 13
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public void Allocate() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckFailedToAllocate(int error) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void CheckFailedToFree(int error) { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public void Free() { }

		[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		public int get_Alignment() { }

		[CalledBy(Type = typeof(UnsafeStream), Member = "AllocateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStream&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeStream), Member = "AllocateForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		public long get_AllocatedBytes() { }

		[CalledBy(Type = typeof(RewindableAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int), typeof(int), typeof(long), typeof(long)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RewindableAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		public long get_Bytes() { }

		[CalledBy(Type = typeof(AllocatorHandle), Member = "TryAllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "AllocateBlock", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Block))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Array), Member = "CustomResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NativeReferenceDispose), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MemoryBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*), typeof(int)}, ReturnType = typeof(UnsafeStreamBlock*))]
		[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		public void set_Alignment(int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public int TryAllocate() { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		public int TryFree() { }

	}

	internal struct BlockHandle
	{
		public ushort Value; //Field offset: 0x0

	}

	internal interface IAllocator : IDisposable
	{

		public TryFunction Function
		{
			 get { } //Length: 0
		}

		public AllocatorHandle Handle
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public bool IsAutoDispose
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public bool IsCustomAllocator
		{
			 get { } //Length: 0
		}

		public Allocator ToAllocator
		{
			 get { } //Length: 0
		}

		public TryFunction get_Function() { }

		public AllocatorHandle get_Handle() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public bool get_IsAutoDispose() { }

		public bool get_IsCustomAllocator() { }

		public Allocator get_ToAllocator() { }

		public void set_Handle(AllocatorHandle value) { }

		public int Try(ref Block block) { }

	}

	public static class Managed
	{
		internal static TryFunction[] TryFunctionDelegates; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static Managed() { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		public static void RegisterDelegate(int index, TryFunction function) { }

		[CalledBy(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ExcludeFromBurstCompatTesting("Uses managed delegate")]
		public static void UnregisterDelegate(int index) { }

	}

	internal struct Range : IDisposable
	{
		public IntPtr Pointer; //Field offset: 0x0
		public int Items; //Field offset: 0x8
		public AllocatorHandle Allocator; //Field offset: 0xC

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		public override void Dispose() { }

	}

	public sealed class SharedStatics
	{
		public sealed class IsAutoDispose
		{
			internal static readonly SharedStatic<Long1024> Ref; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.Long1024>), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.Long1024>))]
			private static IsAutoDispose() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public IsAutoDispose() { }

		}

		public sealed class IsInstalled
		{
			internal static readonly SharedStatic<Long1024> Ref; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.Long1024>), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = typeof(Unity.Burst.SharedStatic`1<Unity.Collections.Long1024>))]
			private static IsInstalled() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public IsInstalled() { }

		}

		public sealed class TableEntry
		{
			internal static readonly SharedStatic<Array32768`1<TableEntry>> Ref; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SharedStatic`1), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
			private static TableEntry() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public TableEntry() { }

		}


		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SharedStatics() { }

	}

	[BurstCompile]
	public struct SlabAllocator : IAllocator, IDisposable
	{
		public static class Try_000000B9$BurstDirectCall
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
			[Calls(Type = typeof(SlabAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class Try_000000B9$PostfixBurstDelegate : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public Try_000000B9$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal AllocatorHandle m_handle; //Field offset: 0x0
		internal Block Storage; //Field offset: 0x8
		internal int Log2SlabSizeInBytes; //Field offset: 0x28
		internal FixedList4096Bytes<Int32> Occupied; //Field offset: 0x30
		internal long budgetInBytes; //Field offset: 0x1030
		internal long allocatedBytes; //Field offset: 0x1038

		public long AllocatedBytes
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 8
		}

		public long BudgetInBytes
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 8
		}

		public override TryFunction Function
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 213
		}

		public override AllocatorHandle Handle
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override bool IsCustomAllocator
		{
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		internal int Slabs
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 19
		}

		internal int SlabSizeInBytes
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 11
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal set { } //Length: 104
		}

		public override Allocator ToAllocator
		{
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			 get { } //Length: 13
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		public long get_AllocatedBytes() { }

		[CallerCount(Count = 0)]
		public long get_BudgetInBytes() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public override TryFunction get_Function() { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public override AllocatorHandle get_Handle() { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool get_IsCustomAllocator() { }

		[CallerCount(Count = 0)]
		internal int get_Slabs() { }

		[CallerCount(Count = 0)]
		internal int get_SlabSizeInBytes() { }

		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		public override Allocator get_ToAllocator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void Initialize(Block storage, int slabSizeInBytes, long budget) { }

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public override void set_Handle(AllocatorHandle value) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal void set_SlabSizeInBytes(int value) { }

		[CalledBy(Type = typeof(Try_000000B9$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SlabAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SlabAllocator), Member = "Try$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		public override int Try(ref Block block) { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(SlabAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SlabAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[MonoPInvokeCallback(typeof(TryFunction))]
		internal static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	[BurstCompile]
	public struct StackAllocator : IAllocator, IDisposable
	{
		public static class Try_000000AB$BurstDirectCall
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
			[Calls(Type = typeof(StackAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			public static int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class Try_000000AB$PostfixBurstDelegate : MulticastDelegate
		{

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public Try_000000AB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override int EndInvoke(IAsyncResult unnamed_param_0) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override int Invoke(IntPtr allocatorState, ref Block block) { }

		}

		internal AllocatorHandle m_handle; //Field offset: 0x0
		internal Block m_storage; //Field offset: 0x8
		internal long m_top; //Field offset: 0x28

		public override TryFunction Function
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 213
		}

		public override AllocatorHandle Handle
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override bool IsCustomAllocator
		{
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public override Allocator ToAllocator
		{
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			 get { } //Length: 13
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public override TryFunction get_Function() { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public override AllocatorHandle get_Handle() { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool get_IsCustomAllocator() { }

		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		public override Allocator get_ToAllocator() { }

		[CallerCount(Count = 0)]
		public void Initialize(Block storage) { }

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public override void set_Handle(AllocatorHandle value) { }

		[CalledBy(Type = typeof(Try_000000AB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StackAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StackAllocator), Member = "Try$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Block&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		public override int Try(ref Block block) { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(StackAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try(IntPtr allocatorState, ref Block block) { }

		[BurstCompile]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StackAllocator), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[MonoPInvokeCallback(typeof(TryFunction))]
		internal static int Try$BurstManaged(IntPtr allocatorState, ref Block block) { }

	}

	public struct TableEntry
	{
		internal IntPtr function; //Field offset: 0x0
		internal IntPtr state; //Field offset: 0x8

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class TryFunction : MulticastDelegate
	{

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public TryFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(IntPtr allocatorState, ref Block block, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(ref Block block, IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(IntPtr allocatorState, ref Block block) { }

	}

	public static readonly AllocatorHandle Invalid; //Field offset: 0x0
	public const int kErrorNone = 0; //Field offset: 0x0
	public const int kErrorBufferOverflow = -1; //Field offset: 0x0
	public const ushort FirstUserIndex = 64; //Field offset: 0x0
	public const ushort MaxNumCustomAllocators = 32768; //Field offset: 0x0
	public static readonly AllocatorHandle None; //Field offset: 0x4
	public static readonly AllocatorHandle Temp; //Field offset: 0x8
	public static readonly AllocatorHandle TempJob; //Field offset: 0xC
	public static readonly AllocatorHandle Persistent; //Field offset: 0x10
	public static readonly AllocatorHandle AudioKernel; //Field offset: 0x14
	internal static readonly ushort NumGlobalScratchAllocators; //Field offset: 0x18
	internal static readonly ushort MaxNumGlobalAllocators; //Field offset: 0x1A
	internal static readonly uint GlobalAllocatorBaseIndex; //Field offset: 0x1C
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	private static AllocatorManager() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* Allocate(ref T t, int sizeOf, int alignOf, int items = 1) { }

	[CalledBy(Type = typeof(NativeList`1), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "U&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeList`1), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "U&", typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>*")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	internal static U* Allocate(ref T t, U u, int items) { }

	[CalledBy(Type = typeof(UnsafeList`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>*")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static T* Allocate(AllocatorHandle handle, int items = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorManager), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Void*))]
	public static Void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(FunctionPointer`1), Member = "get_Invoke", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int allocate_block(ref Block block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	internal static Block AllocateBlock(ref T t, int sizeOf, int alignOf, int items) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	internal static Block AllocateBlock(ref T t, U u, int items) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	internal static Void* AllocateStruct(ref T t, U u, int items) { }

	[BurstDiscard]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	private static void CheckDelegate(ref bool useDelegate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckFailedToAllocate(int error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckFailedToFree(int error) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	internal static void CheckValid(AllocatorHandle handle) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static AllocatorHandle ConvertToAllocatorHandle(Allocator a) { }

	[CalledBy(Type = typeof(AllocatorHelper`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(AllocatorManager), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Register uses managed delegate")]
	internal static T CreateAllocator(AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0) { }

	[CalledBy(Type = typeof(AllocatorHelper`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_IsInstalled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryFree", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Managed), Member = "UnregisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Registration uses managed delegates")]
	[Extension]
	internal static void DestroyAllocator(ref T t, AllocatorHandle backingAllocator) { }

	[BurstDiscard]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void forward_mono_allocate_block(ref Block block, ref int error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	internal static void Free(ref T t, Void* pointer, int sizeOf, int alignOf, int items) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	internal static void Free(ref T t, U* pointer, int items) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(Void*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public static void Free(AllocatorHandle handle, Void* pointer, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	[CalledBy(Type = typeof(UnsafeList`1), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void Free(AllocatorHandle handle, T* pointer, int items = 1) { }

	[CalledBy(Type = typeof(NativeArrayExtensions), Member = "DisposeCheckAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	public static void Free(AllocatorHandle handle, Void* pointer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	internal static void FreeBlock(ref T t, ref Block block) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void Initialize() { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(IntPtr), typeof(TryFunction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer, TryFunction function, bool IsAutoDispose = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(AllocatorManager), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(IntPtr), typeof(Unity.Burst.FunctionPointer`1<Unity.Collections.AllocatorManager+TryFunction>), typeof(TryFunction), typeof(bool)}, ReturnType = typeof(void))]
	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, TryFunction function) { }

	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool IsCustomAllocator(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	internal static Allocator LegacyOf(AllocatorHandle handle) { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.AllocatorManager+Array32768`1<Unity.Collections.AllocatorManager+TableEntry>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal static AllocatorHandle Register(IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "CreateAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(bool), typeof(int)}, ReturnType = "T&")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewindableAllocator), Member = "get_Function", ReturnType = typeof(TryFunction))]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[Calls(Type = typeof(AllocatorManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Unity.Burst.FunctionPointer`1<Unity.Collections.AllocatorManager+TryFunction>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Managed), Member = "RegisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TryFunction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	public static void Register(ref T t, bool IsAutoDispose = false, bool isGlobal = false, int globalIndex = 0) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void Shutdown() { }

	[CalledBy(Type = typeof(NativeReferenceDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeStreamBlockData), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeStreamBlock*), typeof(int)}, ReturnType = typeof(UnsafeStreamBlock*))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(Array), Member = "CustomResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Block), Member = "Allocate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Block), Member = "TryFree", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Block), Member = "TryAllocate", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Block), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Range), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocatorHandle), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Block), Member = "Free", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_TableEntry", ReturnType = typeof(TableEntry&))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static int Try(ref Block block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int TryLegacy(ref Block block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_IsInstalled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AllocatorHandle), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryFree", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[Extension]
	public static void UnmanagedUnregister(ref T t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "get_IsInstalled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AllocatorHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryFree", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Managed), Member = "UnregisterDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Uses managed delegate")]
	[Extension]
	public static void Unregister(ref T t) { }

	[CallerCount(Count = 0)]
	private static bool UseDelegate() { }

}

