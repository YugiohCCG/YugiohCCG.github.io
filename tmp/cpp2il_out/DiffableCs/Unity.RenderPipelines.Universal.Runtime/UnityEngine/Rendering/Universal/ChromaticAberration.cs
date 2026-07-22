namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Chromatic Aberration")]
public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Use the slider to set the strength of the Chromatic Aberration effect.")]
	public ClampedFloatParameter intensity; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ChromaticAberration() { }

	[CallerCount(Count = 9)]
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

