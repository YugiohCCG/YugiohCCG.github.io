namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct GPUDrivenPackedRendererData
{
	private uint data; //Field offset: 0x0

	public bool hasTree
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystemBurst", Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedRendererData>&", "Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<Int32>&", "UnityEngine.Rendering.InstanceAllocators&", "UnityEngine.Rendering.CPUInstanceData&", "UnityEngine.Rendering.CPUSharedInstanceData&", "Unity.Collections.NativeArray`1<InstanceHandle>&", "Unity.Collections.NativeParallelMultiHashMap`2<Int32, InstanceHandle>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool isPartOfStaticBatch
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public LightProbeUsage lightProbeUsage
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 9
	}

	public byte lodMask
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 6
	}

	public MotionVectorGenerationMode motionVecGenMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 9
	}

	public ShadowCastingMode shadowCastingMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 9
	}

	public bool smallMeshCulling
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool staticShadowCaster
	{
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public GPUDrivenPackedRendererData() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystemBurst", Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedRendererData>&", "Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<Int32>&", "UnityEngine.Rendering.InstanceAllocators&", "UnityEngine.Rendering.CPUInstanceData&", "UnityEngine.Rendering.CPUSharedInstanceData&", "Unity.Collections.NativeArray`1<InstanceHandle>&", "Unity.Collections.NativeParallelMultiHashMap`2<Int32, InstanceHandle>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_hasTree() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isPartOfStaticBatch() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public LightProbeUsage get_lightProbeUsage() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public byte get_lodMask() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public MotionVectorGenerationMode get_motionVecGenMode() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public ShadowCastingMode get_shadowCastingMode() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_smallMeshCulling() { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_staticShadowCaster() { }

}

