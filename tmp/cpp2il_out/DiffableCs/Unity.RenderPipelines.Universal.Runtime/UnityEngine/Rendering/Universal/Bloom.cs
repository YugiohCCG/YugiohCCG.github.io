namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Bloom")]
public sealed class Bloom : VolumeComponent, IPostProcessComponent
{
	[Obsolete("This is obsolete, please use maxIterations instead.", True)]
	[Tooltip("The number of final iterations to skip in the effect processing sequence.")]
	public ClampedIntParameter skipIterations; //Field offset: 0x38
	[Header("Bloom")]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public MinFloatParameter threshold; //Field offset: 0x40
	[Tooltip("Strength of the bloom filter.")]
	public MinFloatParameter intensity; //Field offset: 0x48
	[Tooltip("Set the radius of the bloom effect.")]
	public ClampedFloatParameter scatter; //Field offset: 0x50
	[Tooltip("Set the maximum intensity that Unity uses to calculate Bloom. If pixels in your Scene are more intense than this, URP renders them at their current intensity, but uses this intensity value for the purposes of Bloom calculations.")]
	public MinFloatParameter clamp; //Field offset: 0x58
	[Tooltip("Use the color picker to select a color for the Bloom effect to tint to.")]
	public ColorParameter tint; //Field offset: 0x60
	[Tooltip("Use bicubic sampling instead of bilinear sampling for the upsampling passes. This is slightly more expensive but helps getting smoother visuals.")]
	public BoolParameter highQualityFiltering; //Field offset: 0x68
	[AdditionalProperty]
	[Tooltip("The starting resolution that this effect begins processing.")]
	public DownscaleParameter downscale; //Field offset: 0x70
	[AdditionalProperty]
	[Tooltip("The maximum number of iterations in the effect processing sequence.")]
	public ClampedIntParameter maxIterations; //Field offset: 0x78
	[Header("Lens Dirt")]
	[Tooltip("Dirtiness texture to add smudges or dust to the bloom effect.")]
	public TextureParameter dirtTexture; //Field offset: 0x80
	[Tooltip("Amount of dirtiness.")]
	public MinFloatParameter dirtIntensity; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClampedIntParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public Bloom() { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool IsActive() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

}

