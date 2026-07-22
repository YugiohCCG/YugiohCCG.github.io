namespace UnityEngine.Rendering.Universal;

internal abstract class DecalDrawSystem
{
	internal static readonly uint MaxBatchSize; //Field offset: 0x0
	protected DecalEntityManager m_EntityManager; //Field offset: 0x10
	private Matrix4x4[] m_WorldToDecals; //Field offset: 0x18
	private Matrix4x4[] m_NormalToDecals; //Field offset: 0x20
	private Single[] m_DecalLayerMasks; //Field offset: 0x28
	private ProfilingSampler m_Sampler; //Field offset: 0x30
	[CompilerGenerated]
	private Material <overrideMaterial>k__BackingField; //Field offset: 0x38

	public Material overrideMaterial
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	private static DecalDrawSystem() { }

	[CalledBy(Type = typeof(DecalDrawDBufferSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawFowardEmissiveSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawErrorSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager), typeof(DecalTechnique)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawGBufferSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawScreenSpaceSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public DecalDrawSystem(string sampler, DecalEntityManager entityManager) { }

	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_decalProjectorMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Draw(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_decalProjectorMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_camera", ReturnType = typeof(Camera&))]
	[Calls(Type = typeof(Graphics), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(Camera), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }

	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_decalProjectorMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DrawInstanced(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex) { }

	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecalEntityManager), Member = "get_decalProjectorMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_camera", ReturnType = typeof(Camera&))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Execute(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(DBufferRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DBufferRenderPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DBufferRenderPass+PassData", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass+<>c", Member = "<RecordRenderGraph>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalForwardEmissivePass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalForwardEmissivePass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalForwardEmissivePass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DecalForwardEmissivePass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalDrawSystem), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DecalGBufferRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalScreenSpaceRenderPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	internal void Execute(RasterCommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Execute(RasterCommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "OnCameraPreCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	public void Execute(in CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalDrawSystem), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(DecalEntityChunk), typeof(DecalCachedChunk), typeof(DecalDrawCallChunk)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count) { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Material get_overrideMaterial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override Material GetMaterial(DecalEntityChunk decalEntityChunk) { }

	protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_overrideMaterial(Material value) { }

}

