namespace Unity.Collections;

internal class ConcurrentMask
{
	internal const int ErrorFailedToFree = -1; //Field offset: 0x0
	internal const int ErrorFailedToAllocate = -2; //Field offset: 0x0
	internal const int ErrorAllocationCrossesWordBoundary = -3; //Field offset: 0x0
	internal const int EmptyBeforeAllocation = 0; //Field offset: 0x0
	internal const int EmptyAfterFree = 0; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConcurrentMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static long AtomicAnd(ref long destination, long source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static long AtomicOr(ref long destination, long source) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool foundAtLeastThisManyConsecutiveOnes(long value, int minimum, out int offset, out int count) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool foundAtLeastThisManyConsecutiveZeroes(long value, int minimum, out int offset, out int count) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static void longestConsecutiveOnes(long value, out int offset, out int count) { }

	[CallerCount(Count = 0)]
	internal static long MakeMask(int offset, int bits) { }

	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	internal static bool Succeeded(int error) { }

	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static int TryAllocate(ref long l, int offset, int bits) { }

	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static int TryAllocate(ref long l, out int offset, int bits) { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "Install", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(IntPtr), typeof(Unity.Burst.FunctionPointer`1<Unity.Collections.AllocatorManager+TryFunction>), typeof(TryFunction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Unity.Burst.FunctionPointer`1<Unity.Collections.AllocatorManager+TryFunction>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(AllocatorHandle))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Long1024), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int64&))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int TryAllocate(ref T t, int offset, int bits) { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Unity.Burst.FunctionPointer`1<Unity.Collections.AllocatorManager+TryFunction>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(AllocatorHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Long1024), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int64&))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ConcurrentMask), Member = "Succeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int TryAllocate(ref T t, out int offset, int begin, int end, int bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentMask), Member = "Succeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static int TryAllocate(ref T t, out int offset, int begin, int bits) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static int TryAllocate(ref T t, out int offset, int bits) { }

	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryFree", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static int TryFree(ref long l, int offset, int bits) { }

	[CalledBy(Type = typeof(AllocatorManager), Member = "UnmanagedUnregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocatorManager), Member = "Unregister", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Long1024), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int64&))]
	[Calls(Type = typeof(ConcurrentMask), Member = "TryFree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int TryFree(ref T t, int offset, int bits) { }

}

