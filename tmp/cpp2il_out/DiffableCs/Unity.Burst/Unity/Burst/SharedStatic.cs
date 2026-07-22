namespace Unity.Burst;

internal static class SharedStatic
{
	public class PreserveAttribute : Attribute
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PreserveAttribute() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckResult(Void* result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckSizeOf(uint sizeOf) { }

	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreatePartiallyUnsafeWithHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSubContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreatePartiallyUnsafeWithSubHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(uint)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CallerCount(Count = 5)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetOrCreateSharedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128&), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Preserve]
	public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

}

