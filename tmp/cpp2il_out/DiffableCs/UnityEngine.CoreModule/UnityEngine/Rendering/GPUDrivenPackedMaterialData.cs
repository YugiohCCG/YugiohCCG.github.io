namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct GPUDrivenPackedMaterialData
{
	private uint data; //Field offset: 0x0

	public bool hasTessellation
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 7
	}

	public bool isMotionVectorsPassEnabled
	{
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public bool isTransparent
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public GPUDrivenPackedMaterialData() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawerBurst+GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&", "ReadOnly<Int32, GPUDrivenPackedMaterialData>&", "Unity.Collections.NativeHashSet`1<Int32>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawerBurst", Member = "GetMaterialsWithChangedPackedMaterial$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&", "ReadOnly<Int32, GPUDrivenPackedMaterialData>&", "Unity.Collections.NativeHashSet`1<Int32>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool Equals(GPUDrivenPackedMaterialData other) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_hasTessellation() { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isMotionVectorsPassEnabled() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public bool get_isTransparent() { }

}

