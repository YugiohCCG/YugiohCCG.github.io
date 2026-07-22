namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Color Lookup")]
public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
{
	[Tooltip("A 2D Lookup Texture (LUT) to use for color grading.")]
	public TextureParameter texture; //Field offset: 0x38
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public ClampedFloatParameter contribution; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public ColorLookup() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "SetupColorGrading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderUberPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(UniversalPostProcessingData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public override bool IsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_sRGB", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public bool ValidateLUT() { }

}

