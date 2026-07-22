namespace UnityEngine.Rendering;

[MovedFrom(False, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset")]
internal class ProbeVolumeStreamableAsset
{
	[MovedFrom(False, "UnityEngine.Rendering", "Unity.RenderPipelines.Core.Runtime", "ProbeVolumeBakingSet.StreamableAsset.StreamableCellDesc")]
	internal struct StreamableCellDesc
	{
		public int offset; //Field offset: 0x0
		public int elementCount; //Field offset: 0x4

	}

	[FormerlySerializedAs("assetGUID")]
	[SerializeField]
	private string m_AssetGUID; //Field offset: 0x10
	[FormerlySerializedAs("streamableAssetPath")]
	[SerializeField]
	private string m_StreamableAssetPath; //Field offset: 0x18
	[FormerlySerializedAs("elementSize")]
	[SerializeField]
	private int m_ElementSize; //Field offset: 0x20
	[FormerlySerializedAs("streamableCellDescs")]
	[SerializeField]
	private SerializedDictionary<Int32, StreamableCellDesc> m_StreamableCellDescs; //Field offset: 0x28
	[SerializeField]
	private TextAsset m_Asset; //Field offset: 0x30
	private string m_FinalAssetPath; //Field offset: 0x38
	private FileHandle m_AssetFileHandle; //Field offset: 0x40

	public TextAsset asset
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string assetGUID
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int elementSize
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public SerializedDictionary<Int32, StreamableCellDesc> streamableCellDescs
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ProbeVolumeStreamableAsset(string apvStreamingAssetsPath, SerializedDictionary<Int32, StreamableCellDesc> cellDescs, int elementSize, string bakingSetGUID, string assetGUID) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateDiskStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FileHandle), Member = "get_JobHandle", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(FileHandle), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void CloseFile() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FileHandle), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose() { }

	[CalledBy(Type = typeof(PerScenarioDataInfo), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSHBands)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PerScenarioDataInfo), Member = "ComputeHasValidData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSHBands)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ComputeHasValidSharedData", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "ComputeHasSupportData", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "GetAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(AsyncReadManager), Member = "GetFileInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfoResult*)}, ReturnType = typeof(ReadHandle))]
	[Calls(Type = typeof(ReadHandle), Member = "get_JobHandle", ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool FileExists() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public TextAsset get_asset() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_assetGUID() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_elementSize() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public SerializedDictionary<Int32, StreamableCellDesc> get_streamableCellDescs() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(ProbeVolumeStreamableAsset), Member = "FileExists", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeStreamableAsset), Member = "GetFileSize", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ProbeVolumeStreamableAsset), Member = "OpenFile", ReturnType = typeof(FileHandle))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string GetAssetPath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "GetAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileInfo), Member = "get_Length", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	public long GetFileSize() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool HasValidAssetReference() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateDiskStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsOpen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public bool IsValid() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ProcessDiskStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CellStreamingRequest)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ProbeVolumeStreamableAsset), Member = "GetAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(AsyncReadManager), Member = "OpenFileAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	public FileHandle OpenFile() { }

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeStreamableAsset), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void RefreshAssetPath() { }

}

