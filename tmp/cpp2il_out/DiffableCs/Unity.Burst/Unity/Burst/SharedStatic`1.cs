namespace Unity.Burst;

[IsReadOnly]
public struct SharedStatic
{
	private const uint DefaultAlignment = 16; //Field offset: 0x0
	private readonly Void* _buffer; //Field offset: 0x0

	public T Data
	{
		[CallerCount(Count = 65)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 36
	}

	public Void* UnsafeDataPointer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private SharedStatic`1(Void* buffer) { }

	[CallerCount(Count = 6)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private static void CheckIf_T_IsUnmanagedOrThrow() { }

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_Data() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Void* get_UnsafeDataPointer() { }

	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Burst.SharedStatic`1<System.IntPtr>), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = typeof(Unity.Burst.SharedStatic`1<System.IntPtr>))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstRuntime), Member = "GetHashCode64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreate(Type contextType, uint alignment = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstRuntime), Member = "GetHashCode64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreate(Type contextType, Type subContextType, uint alignment = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode(uint alignment, long hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode(uint alignment, long subHashCode) { }

	[CalledBy(Type = "Unity.Collections.AllocatorManager+SharedStatics+TableEntry", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }

}

