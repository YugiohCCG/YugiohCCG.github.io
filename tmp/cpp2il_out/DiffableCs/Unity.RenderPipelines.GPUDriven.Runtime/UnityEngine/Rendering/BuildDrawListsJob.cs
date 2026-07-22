namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct BuildDrawListsJob : IJobParallelFor
{
	public const int k_BatchSize = 128; //Field offset: 0x0
	public const int k_IntsPerCacheLine = 16; //Field offset: 0x0
	[ReadOnly]
	public NativeParallelHashMap<DrawKey, Int32> batchHash; //Field offset: 0x0
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x18
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> internalDrawIndex; //Field offset: 0x20
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[WriteOnly]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawInstance&))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
	[Calls(Type = typeof(BuildDrawListsJob), Member = "IncrementCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Execute(int index) { }

	[CalledBy(Type = typeof(BuildDrawListsJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	private static int IncrementCounter(Int32* counter) { }

}

