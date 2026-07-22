namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
public struct SortJobDefer
{
	[BurstCompile]
	internal struct SegmentSort : IJobParallelForDefer
	{
		[ReadOnly]
		internal NativeList<T> DataRO; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeList<T>* Data; //Field offset: 0x0
		internal U Comp; //Field offset: 0x0
		internal int SegmentWidth; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 28)]
		[DeduplicatedMethod]
		public override void Execute(int index) { }

	}

	[BurstCompile]
	internal struct SegmentSortMerge : IJob
	{
		[NativeDisableUnsafePtrRestriction]
		internal NativeList<T> Data; //Field offset: 0x0
		internal U Comp; //Field offset: 0x0
		internal int SegmentWidth; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unmanaged), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 56)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	public NativeList<T> Data; //Field offset: 0x0
	public U Comp; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 56)]
	[DeduplicatedMethod]
	public JobHandle Schedule(JobHandle inputDeps = null) { }

}

