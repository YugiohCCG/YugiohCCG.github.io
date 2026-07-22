namespace UnityEngine.Rendering;

internal struct OccluderContext : IDisposable
{
	private static class ShaderIDs
	{
		public static readonly int _SrcDepth; //Field offset: 0x0
		public static readonly int _DstDepth; //Field offset: 0x4
		public static readonly int OccluderDepthPyramidConstants; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderIDs() { }

	}

	public const int k_FirstDepthMipIndex = 3; //Field offset: 0x0
	public const int k_MaxOccluderMips = 8; //Field offset: 0x0
	public const int k_MaxSilhouettePlanes = 6; //Field offset: 0x0
	public const int k_MaxSubviewsPerView = 6; //Field offset: 0x0
	public int version; //Field offset: 0x0
	public Vector2Int depthBufferSize; //Field offset: 0x4
	public NativeArray<OccluderDerivedData> subviewData; //Field offset: 0x10
	public int subviewValidMask; //Field offset: 0x20
	public NativeArray<OccluderMipBounds> occluderMipBounds; //Field offset: 0x28
	public Vector2Int occluderMipLayoutSize; //Field offset: 0x38
	public Vector2Int occluderDepthPyramidSize; //Field offset: 0x40
	public RTHandle occluderDepthPyramid; //Field offset: 0x48
	public int occlusionDebugOverlaySize; //Field offset: 0x50
	public GraphicsBuffer occlusionDebugOverlay; //Field offset: 0x58
	public bool debugNeedsClear; //Field offset: 0x60
	public ComputeBuffer constantBuffer; //Field offset: 0x68
	public NativeArray<OccluderDepthPyramidConstants> constantBufferData; //Field offset: 0x70

	public Vector2 depthBufferSizeInOccluderPixels
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 43
	}

	public int subviewCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(OccluderContext), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(UsageFlags), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OccluderDepthPyramidConstants>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void AllocateTexturesIfNecessary(bool debugOverlayEnabled) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(OccluderHandles&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OccluderContext), Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>)}, ReturnType = typeof(OccluderDepthPyramidConstants))]
	[Calls(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderDepthPyramidConstants)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.OccluderDepthPyramidConstants>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles, NativeArray<Plane> silhouettePlanes, ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "DeleteContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	public Vector2 get_depthBufferSizeInOccluderPixels() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_subviewCount() { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "GetOcclusionTestDebugOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OcclusionCullingDebugOutput))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal OcclusionCullingDebugOutput GetDebugOutput() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public OccluderHandles Import(RenderGraph renderGraph) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsSubviewValid(int subviewIndex) { }

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OccluderParameters&)}, ReturnType = typeof(OccluderHandles))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "GetDebugStats", ReturnType = typeof(DebugRendererBatcherStats))]
	[Calls(Type = typeof(OccluderContext), Member = "UpdateMipBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(OccluderContext), Member = "AllocateTexturesIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void PrepareOccluders(in OccluderParameters occluderParams) { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(IndirectBufferContextHandles&), typeof(OccluderHandles&), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetKeyword(ComputeCommandBuffer cmd, ComputeShader cs, in LocalKeyword keyword, bool value) { }

	[CalledBy(Type = typeof(OccluderContext), Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderParameters&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(OccluderHandles&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OccluderDerivedData), Member = "FromParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderSubviewUpdate&)}, ReturnType = typeof(OccluderDerivedData))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, NativeArray<Plane> silhouettePlanes) { }

	[CalledBy(Type = typeof(OccluderContext), Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OccluderParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	private void UpdateMipBounds() { }

}

