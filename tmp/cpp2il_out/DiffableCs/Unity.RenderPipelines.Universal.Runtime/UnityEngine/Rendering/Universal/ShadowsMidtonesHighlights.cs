namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Shadows, Midtones, Highlights")]
public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
{
	public Vector4Parameter shadows; //Field offset: 0x38
	public Vector4Parameter midtones; //Field offset: 0x40
	public Vector4Parameter highlights; //Field offset: 0x48
	[Header("Shadow Limits")]
	[Tooltip("Start point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsStart; //Field offset: 0x50
	[Tooltip("End point of the transition between shadows and midtones.")]
	public MinFloatParameter shadowsEnd; //Field offset: 0x58
	[Header("Highlight Limits")]
	[Tooltip("Start point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsStart; //Field offset: 0x60
	[Tooltip("End point of the transition between midtones and highlights.")]
	public MinFloatParameter highlightsEnd; //Field offset: 0x68

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public ShadowsMidtonesHighlights() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector4>), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector4>), typeof(Vector4)}, ReturnType = typeof(bool))]
	public override bool IsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

}

