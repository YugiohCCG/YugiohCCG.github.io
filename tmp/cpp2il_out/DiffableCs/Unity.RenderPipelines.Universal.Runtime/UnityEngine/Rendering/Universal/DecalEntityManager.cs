namespace UnityEngine.Rendering.Universal;

internal class DecalEntityManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<CombinedChunks> <>9__26_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal int <Update>b__26_0(CombinedChunks a, CombinedChunks b) { }

	}

	private struct CombinedChunks
	{
		public DecalEntityChunk entityChunk; //Field offset: 0x0
		public DecalCachedChunk cachedChunk; //Field offset: 0x8
		public DecalCulledChunk culledChunk; //Field offset: 0x10
		public DecalDrawCallChunk drawCallChunk; //Field offset: 0x18
		public int previousChunkIndex; //Field offset: 0x20
		public bool valid; //Field offset: 0x24

	}

	public List<DecalEntityChunk> entityChunks; //Field offset: 0x10
	public List<DecalCachedChunk> cachedChunks; //Field offset: 0x18
	public List<DecalCulledChunk> culledChunks; //Field offset: 0x20
	public List<DecalDrawCallChunk> drawCallChunks; //Field offset: 0x28
	public int chunkCount; //Field offset: 0x30
	private ProfilingSampler m_AddDecalSampler; //Field offset: 0x38
	private ProfilingSampler m_ResizeChunks; //Field offset: 0x40
	private ProfilingSampler m_SortChunks; //Field offset: 0x48
	private DecalEntityIndexer m_DecalEntityIndexer; //Field offset: 0x50
	private Dictionary<Material, Int32> m_MaterialToChunkIndex; //Field offset: 0x58
	private List<CombinedChunks> m_CombinedChunks; //Field offset: 0x60
	private List<Int32> m_CombinedChunkRemmap; //Field offset: 0x68
	private Material m_ErrorMaterial; //Field offset: 0x70
	private Mesh m_DecalProjectorMesh; //Field offset: 0x78

	public Mesh decalProjectorMesh
	{
		[CalledBy(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CoreUtils), Member = "CreateCubeMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Mesh))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 238
	}

	public Material errorMaterial
	{
		[CalledBy(Type = typeof(DecalDrawErrorSystem), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityChunk)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
		[CalledBy(Type = typeof(DecalEntityManager), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 186
	}

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	public DecalEntityManager() { }

	[CalledBy(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private int CreateChunkIndex(Material material) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_errorMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(DecalEntityManager), Member = "CreateChunkIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int32>), Member = "Dequeue", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TransformAccessArray), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalEntityManager), Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity), typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 39)]
	public DecalEntity CreateDecalEntity(DecalProjector decalProjector) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalEntityIndexer), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Int32>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyDecalEntity(DecalEntity decalEntity) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 17)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateCubeMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Mesh))]
	[CallsUnknownMethods(Count = 1)]
	public Mesh get_decalProjectorMesh() { }

	[CalledBy(Type = typeof(DecalDrawErrorSystem), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityChunk)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[CalledBy(Type = typeof(DecalEntityManager), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[CallsUnknownMethods(Count = 1)]
	public Material get_errorMaterial() { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalMaterialChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DecalEntityIndexer), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid(DecalEntity decalEntity) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_errorMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	public void Update() { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnAllDecalPropertyChange", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityIndexer), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalEntityManager), Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntity), typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateAllDecalEntitiesData() { }

	[CalledBy(Type = typeof(DecalEntityManager), Member = "CreateDecalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(DecalEntity))]
	[CalledBy(Type = typeof(DecalEntityManager), Member = "UpdateAllDecalEntitiesData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "OnDecalPropertyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalProjector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RenderingLayerUtils), Member = "ToValidRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(GameObject), Member = "get_sceneCullingMask", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector) { }

}

