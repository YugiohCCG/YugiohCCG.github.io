namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Vignette")]
public sealed class Vignette : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Vignette color.")]
	public ColorParameter color; //Field offset: 0x38
	[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
	public Vector2Parameter center; //Field offset: 0x40
	[Tooltip("Use the slider to set the strength of the Vignette effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x48
	[Tooltip("Smoothness of the vignette borders.")]
	public ClampedFloatParameter smoothness; //Field offset: 0x50
	[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
	public BoolParameter rounded; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Vignette() { }

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool IsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

}

