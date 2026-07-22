namespace UnityEngine.Rendering.Universal;

[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[VolumeComponentMenu("Post-processing/Color Adjustments")]
public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
{
	[Tooltip("Adjusts the overall exposure of the scene in EV100. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; //Field offset: 0x38
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public ClampedFloatParameter contrast; //Field offset: 0x40
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; //Field offset: 0x48
	[Tooltip("Shift the hue of all colors.")]
	public ClampedFloatParameter hueShift; //Field offset: 0x50
	[Tooltip("Pushes the intensity of all colors.")]
	public ClampedFloatParameter saturation; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public ColorAdjustments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Color>), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Single>), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.VolumeParameter`1<System.Single>), typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool IsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Obsolete("Unused #from(2023.1)", False)]
	public override bool IsTileCompatible() { }

}

