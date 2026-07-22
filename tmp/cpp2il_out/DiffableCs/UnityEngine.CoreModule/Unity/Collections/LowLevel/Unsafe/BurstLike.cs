namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType::DoubleColon (2))]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
internal static class BurstLike
{
	public static class SharedStatic
	{

		[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContext"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = "Unity.Collections.LowLevel.Unsafe.BurstLike+SharedStatic`1<T>")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

	}

	[IsReadOnly]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	public struct SharedStatic
	{
		private readonly Void* _buffer; //Field offset: 0x0

		public T Data
		{
			[CallerCount(Count = 65)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 36
		}

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		private SharedStatic`1(Void* buffer) { }

		[CallerCount(Count = 65)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public T get_Data() { }

		[CalledBy(Type = typeof(JobStruct`1), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForJobStruct`1), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParallelForJobStruct`1), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	}


}

