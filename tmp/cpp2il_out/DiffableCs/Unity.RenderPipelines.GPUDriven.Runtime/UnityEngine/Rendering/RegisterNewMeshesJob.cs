namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct RegisterNewMeshesJob : IJobParallelFor
{
	public const int k_BatchSize = 128; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<BatchMeshID> batchIDs; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32, BatchMeshID> hashMap; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParallelWriter), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	public override void Execute(int index) { }

}

