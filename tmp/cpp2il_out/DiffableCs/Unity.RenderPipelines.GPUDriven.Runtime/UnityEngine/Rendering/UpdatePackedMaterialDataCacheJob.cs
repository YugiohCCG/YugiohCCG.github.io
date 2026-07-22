namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct UpdatePackedMaterialDataCacheJob : IJob
{
	[ReadOnly]
	public ReadOnly<Int32> materialIDs; //Field offset: 0x0
	[ReadOnly]
	public ReadOnly<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	public NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> packedMaterialHash; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdatePackedMaterialDataCacheJob), Member = "ProcessMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void Execute() { }

	[CalledBy(Type = typeof(UpdatePackedMaterialDataCacheJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessMaterial(int i) { }

}

