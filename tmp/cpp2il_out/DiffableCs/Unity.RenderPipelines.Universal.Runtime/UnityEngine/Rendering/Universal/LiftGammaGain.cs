namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Lift, Gamma, Gain")]
public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
{
	public Vector4Parameter lift; //Field offset: 0x38
	public Vector4Parameter gamma; //Field offset: 0x40
	public Vector4Parameter gain; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public LiftGammaGain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector4>), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector4>), typeof(Vector4)}, ReturnType = typeof(bool))]
	public override bool IsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

}

