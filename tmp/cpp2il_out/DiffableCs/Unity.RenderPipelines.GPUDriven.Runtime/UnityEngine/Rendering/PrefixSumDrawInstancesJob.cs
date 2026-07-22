namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct PrefixSumDrawInstancesJob : IJob
{
	[ReadOnly]
	public NativeParallelHashMap<RangeKey, Int32> rangeHash; //Field offset: 0x0
	public NativeList<DrawRange> drawRanges; //Field offset: 0x10
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x18
	public NativeArray<Int32> drawBatchIndices; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Execute() { }

}

