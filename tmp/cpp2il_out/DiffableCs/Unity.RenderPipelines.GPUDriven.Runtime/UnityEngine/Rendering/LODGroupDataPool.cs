namespace UnityEngine.Rendering;

internal class LODGroupDataPool : IDisposable
{
	private static class LodGroupShaderIDs
	{
		public static readonly int _SupportDitheringCrossFade; //Field offset: 0x0
		public static readonly int _LodGroupCullingDataGPUByteSize; //Field offset: 0x4
		public static readonly int _LodGroupCullingDataStartOffset; //Field offset: 0x8
		public static readonly int _LodCullingDataQueueCount; //Field offset: 0xC
		public static readonly int _InputLodCullingDataIndices; //Field offset: 0x10
		public static readonly int _InputLodCullingDataBuffer; //Field offset: 0x14
		public static readonly int _LodGroupCullingData; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static LodGroupShaderIDs() { }

	}

	private NativeList<LODGroupData> m_LODGroupData; //Field offset: 0x10
	private NativeParallelHashMap<Int32, GPUInstanceIndex> m_LODGroupDataHash; //Field offset: 0x18
	private NativeList<LODGroupCullingData> m_LODGroupCullingData; //Field offset: 0x28
	private NativeList<GPUInstanceIndex> m_FreeLODGroupDataHandles; //Field offset: 0x30
	private int m_CrossfadedRendererCount; //Field offset: 0x38
	private bool m_SupportDitheringCrossFade; //Field offset: 0x3C

	public int activeLodGroupCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 75
	}

	public int crossfadedRendererCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataHash
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public LODGroupDataPool(GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUInstanceIndex>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeLODGroupData(NativeArray<Int32> destroyedLODGroupsID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_activeLodGroupCount() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_crossfadedRendererCount() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public NativeList<LODGroupCullingData> get_lodGroupCullingData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NativeParallelHashMap<Int32, GPUInstanceIndex> get_lodGroupDataHash() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateLODGroupData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenLODGroupData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupDataJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupDataJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateLODGroupData(in GPUDrivenLODGroupData inputData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateLODGroupTransformJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	public void UpdateLODGroupTransformData(in GPUDrivenLODGroupData inputData) { }

}

