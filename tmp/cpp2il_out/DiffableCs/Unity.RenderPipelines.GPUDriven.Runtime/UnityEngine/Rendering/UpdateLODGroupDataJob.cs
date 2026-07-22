namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct UpdateLODGroupDataJob : IJobParallelFor
{
	public const int k_BatchSize = 256; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<GPUInstanceIndex> lodGroupInstances; //Field offset: 0x0
	[ReadOnly]
	public GPUDrivenLODGroupData inputData; //Field offset: 0x10
	[ReadOnly]
	public bool supportDitheringCrossFade; //Field offset: 0xE0
	public NativeArray<LODGroupData> lodGroupsData; //Field offset: 0xE8
	public NativeArray<LODGroupCullingData> lodGroupsCullingData; //Field offset: 0xF8
	[NativeDisableUnsafePtrRestriction]
	public UnsafeAtomicCounter32 rendererCount; //Field offset: 0x108

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int index) { }

}

