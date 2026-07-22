namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct FindMaterialDrawInstancesJob : IJobParallelForBatch
{
	public const int k_BatchSize = 128; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<UInt32> materialsSorted; //Field offset: 0x0
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32> outDrawInstanceIndicesWriter; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawInstance&))]
	[Calls(Type = typeof(NativeSortExtension), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParallelWriter), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Execute(int startIndex, int count) { }

}

