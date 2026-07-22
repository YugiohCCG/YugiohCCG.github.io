namespace UnityEngine.Rendering;

internal struct GPUInstanceDataBufferUploader : IDisposable
{
	internal struct GPUResources : IDisposable
	{
		public ComputeBuffer instanceData; //Field offset: 0x0
		public ComputeBuffer instanceIndices; //Field offset: 0x8
		public ComputeBuffer inputComponentOffsets; //Field offset: 0x10
		public ComputeBuffer validComponentIndices; //Field offset: 0x18
		public ComputeShader cs; //Field offset: 0x20
		public int kernelId; //Field offset: 0x28
		private int m_InstanceDataByteSize; //Field offset: 0x2C
		private int m_InstanceCount; //Field offset: 0x30
		private int m_ComponentCounts; //Field offset: 0x34
		private int m_ValidComponentIndicesCount; //Field offset: 0x38

		[CalledBy(Type = typeof(GPUInstanceDataBufferUploader), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(GPUResources&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		public void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount) { }

		[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

		[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public void LoadShaders(GPUResidentDrawerResources resources) { }

	}

	private static class UploadKernelIDs
	{
		public static readonly int _InputValidComponentCounts; //Field offset: 0x0
		public static readonly int _InputInstanceCounts; //Field offset: 0x4
		public static readonly int _InputInstanceByteSize; //Field offset: 0x8
		public static readonly int _InputComponentOffsets; //Field offset: 0xC
		public static readonly int _InputInstanceData; //Field offset: 0x10
		public static readonly int _InputInstanceIndices; //Field offset: 0x14
		public static readonly int _InputValidComponentIndices; //Field offset: 0x18
		public static readonly int _InputComponentAddresses; //Field offset: 0x1C
		public static readonly int _InputComponentByteCounts; //Field offset: 0x20
		public static readonly int _InputComponentInstanceIndexRanges; //Field offset: 0x24
		public static readonly int _OutputBuffer; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static UploadKernelIDs() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	public struct WriteInstanceDataParameterJob : IJobParallelFor
	{
		public const int k_BatchSize = 512; //Field offset: 0x0
		[ReadOnly]
		public bool gatherData; //Field offset: 0x0
		[ReadOnly]
		public int parameterIndex; //Field offset: 0x4
		[ReadOnly]
		public int uintPerParameter; //Field offset: 0x8
		[ReadOnly]
		public int uintPerInstance; //Field offset: 0xC
		[ReadOnly]
		public NativeArray<Int32> componentDataIndex; //Field offset: 0x10
		[ReadOnly]
		public NativeArray<Int32> gatherIndices; //Field offset: 0x20
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<UInt32> instanceData; //Field offset: 0x30
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<UInt32> tmpDataBuffer; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Set_RefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InstanceHandle), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InstanceAllocators), Member = "AllocateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(InstanceHandle))]
		[Calls(Type = typeof(CPUInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Get_RefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InstanceAllocators), Member = "AllocateSharedInstance", ReturnType = typeof(SharedInstanceHandle))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_hasTree", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnly), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>+Enumerator<T>")]
		[Calls(Type = typeof(CPUInstanceData), Member = "IsValidInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InstanceAllocators), Member = "FreeSharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InstanceAllocators), Member = "FreeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InstanceHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CPUInstanceData), Member = "Get_SharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(SharedInstanceHandle))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		public override void Execute(int index) { }

	}

	private int m_UintPerInstance; //Field offset: 0x0
	private int m_Capacity; //Field offset: 0x4
	private int m_InstanceCount; //Field offset: 0x8
	private NativeArray<Boolean> m_ComponentIsInstanced; //Field offset: 0x10
	private NativeArray<Int32> m_ComponentDataIndex; //Field offset: 0x20
	private NativeArray<Int32> m_DescriptionsUintSize; //Field offset: 0x30
	private NativeArray<UInt32> m_TmpDataBuffer; //Field offset: 0x40
	private NativeList<Int32> m_WritenComponentIndices; //Field offset: 0x50
	private NativeArray<Int32> m_DummyArray; //Field offset: 0x58

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "CreateDataBufferUploader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InstanceType)}, ReturnType = typeof(GPUInstanceDataBufferUploader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public GPUInstanceDataBufferUploader(in NativeArray<GPUInstanceComponentDesc>& descriptions, int capacity, InstanceType instanceType) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void AllocateUploadHandles(int handlesLength) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public int GetParamUIntOffset(int parameterIndex) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int GetUIntPerInstance() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IntPtr GetUploadBufferPtr() { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeListExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>", "U"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int PrepareParamWrite(int parameterIndex) { }

	[CalledBy(Type = typeof(GPUInstanceDataBufferUploader), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUResources&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(GPUInstanceDataBufferUploader&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUResources), Member = "CreateResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUResources gpuResources, bool submitOnlyWrittenParams) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUInstanceDataBufferUploader&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferUploader), Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(GPUResources&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<InstanceHandle> instances, ref GPUResources gpuResources, bool submitOnlyWrittenParams) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JobHandle WriteInstanceDataJob(int parameterIndex, NativeArray<T> instanceData) { }

	[CalledBy(Type = typeof(GPUResidentBatcher), Member = "UpdateRendererInstancesAndBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(System.Collections.Generic.IList`1<UnityEngine.Mesh>), typeof(System.Collections.Generic.IList`1<UnityEngine.Material>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeListExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>", "U"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.UInt32>))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteInstanceDataParameterJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteInstanceDataParameterJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public JobHandle WriteInstanceDataJob(int parameterIndex, NativeArray<T> instanceData, NativeArray<Int32> gatherIndices) { }

}

