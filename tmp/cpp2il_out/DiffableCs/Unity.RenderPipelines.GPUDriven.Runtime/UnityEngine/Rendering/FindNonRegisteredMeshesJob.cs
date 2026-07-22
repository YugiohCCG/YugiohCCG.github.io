namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct FindNonRegisteredMeshesJob : IJobParallelForBatch
{
	public const int k_BatchSize = 128; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeParallelHashMap<Int32, BatchMeshID> hashMap; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32> outInstancesWriter; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeList`1), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelWriter), Member = "AddRangeNoResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Execute(int startIndex, int count) { }

}

