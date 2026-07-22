namespace UnityEngine.Rendering.Universal;

internal struct PostProcessPasses : IDisposable
{
	private ColorGradingLutPass m_ColorGradingLutPass; //Field offset: 0x0
	private PostProcessPass m_PostProcessPass; //Field offset: 0x8
	private PostProcessPass m_FinalPostProcessPass; //Field offset: 0x10
	internal RTHandle m_AfterPostProcessColor; //Field offset: 0x18
	internal RTHandle m_ColorGradingLut; //Field offset: 0x20
	private PostProcessData m_RendererPostProcessData; //Field offset: 0x28
	private PostProcessData m_CurrentPostProcessData; //Field offset: 0x30
	private Material m_BlitMaterial; //Field offset: 0x38

	public RTHandle afterPostProcessColor
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public RTHandle colorGradingLut
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ColorGradingLutPass colorGradingLutPass
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public PostProcessPass finalPostProcessPass
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool isCreated
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "ShouldApplyPostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CameraHasPostProcessingWithDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 80
	}

	public PostProcessPass postProcessPass
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPasses), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public PostProcessPasses(PostProcessData rendererPostProcessData, ref PostProcessParams postProcessParams) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorGradingLutPass), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public RTHandle get_afterPostProcessColor() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RTHandle get_colorGradingLut() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public ColorGradingLutPass get_colorGradingLutPass() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public PostProcessPass get_finalPostProcessPass() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateColorTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "ShouldApplyPostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CameraHasPostProcessingWithDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequiresIntermediateAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CalculateTextureCopySchedules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), "UnityEngine.Rendering.Universal.UniversalRenderer+RenderPassInputSummary", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderer+TextureCopySchedules")]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RequireDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool), typeof(RenderPassInputSummary&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_isCreated() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PostProcessPass get_postProcessPass() { }

	[CalledBy(Type = typeof(PostProcessPasses), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColorGradingLutPass), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorGradingLutPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(PostProcessData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void Recreate(PostProcessData data, ref PostProcessParams ppParams) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "ReleaseRenderTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "Dispose", ReturnType = typeof(void))]
	internal void ReleaseRenderTargets() { }

}

