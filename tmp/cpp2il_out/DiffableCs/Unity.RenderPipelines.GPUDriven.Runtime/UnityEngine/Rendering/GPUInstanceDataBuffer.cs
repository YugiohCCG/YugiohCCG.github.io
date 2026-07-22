namespace UnityEngine.Rendering;

internal class GPUInstanceDataBuffer : IDisposable
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct ConvertCPUInstancesToGPUInstancesJob : IJobParallelFor
	{
		public const int k_BatchSize = 512; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x10
		[WriteOnly]
		public NativeArray<GPUInstanceIndex> gpuInstanceIndices; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
		public override void Execute(int index) { }

	}

	[IsReadOnly]
	public struct ReadOnly
	{
		private readonly NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ReadOnly(GPUInstanceDataBuffer buffer) { }

		[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
		public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

		[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "EncodeGPUInstanceIndexAndCrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
		public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance) { }

	}

	private static int s_NextLayoutVersion; //Field offset: 0x0
	public InstanceNumInfo instanceNumInfo; //Field offset: 0x10
	public NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x18
	public NativeArray<Int32> instancesSpan; //Field offset: 0x28
	public int byteSize; //Field offset: 0x38
	public int perInstanceComponentCount; //Field offset: 0x3C
	public int version; //Field offset: 0x40
	public int layoutVersion; //Field offset: 0x44
	public GraphicsBuffer gpuBuffer; //Field offset: 0x48
	public GraphicsBuffer validComponentsIndicesGpuBuffer; //Field offset: 0x50
	public GraphicsBuffer componentAddressesGpuBuffer; //Field offset: 0x58
	public GraphicsBuffer componentInstanceIndexRangesGpuBuffer; //Field offset: 0x60
	public GraphicsBuffer componentByteCountsGpuBuffer; //Field offset: 0x68
	public NativeArray<GPUInstanceComponentDesc> descriptions; //Field offset: 0x70
	public NativeArray<MetadataValue> defaultMetadata; //Field offset: 0x80
	public NativeArray<Int32> gpuBufferComponentAddress; //Field offset: 0x90
	public NativeParallelHashMap<Int32, Int32> nameToMetadataMap; //Field offset: 0xA0

	public bool valid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 51
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public GPUInstanceDataBuffer() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_instanceDataBuffer", ReturnType = typeof(ReadOnly))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertCPUInstancesToGPUInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertCPUInstancesToGPUInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
	[CalledBy(Type = typeof(ConvertCPUInstancesToGPUInstancesJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUInstanceDataBuffer), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
	[CallerCount(Count = 3)]
	private static GPUInstanceIndex CPUInstanceToGPUInstance(in NativeArray<Int32>& instancesNumPrefixSum, InstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "CPUInstanceToGPUInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(InstanceHandle)}, ReturnType = typeof(GPUInstanceIndex))]
	public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	public int GetGpuAddress(string strName, bool assertOnFail = true) { }

	[CalledBy(Type = typeof(RenderersParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersParameters), Member = "<.ctor>g__GetParamInfo|14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&), typeof(int), typeof(bool)}, ReturnType = typeof(ParamInfo))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	public int GetGpuAddress(int propertyID, bool assertOnFail = true) { }

	[CalledBy(Type = typeof(RenderersParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersParameters), Member = "<.ctor>g__GetParamInfo|14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer&), typeof(int), typeof(bool)}, ReturnType = typeof(ParamInfo))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	public int GetPropertyIndex(int propertyID, bool assertOnFail = true) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InstanceHandle GPUInstanceToCPUInstance(GPUInstanceIndex gpuInstanceIndex) { }

	[CallerCount(Count = 0)]
	public static int NextVersion() { }

}

