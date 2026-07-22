namespace UnityEngine.Rendering;

[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[VolumeComponentMenu("Lighting/Adaptive Probe Volumes Options")]
public sealed class ProbeVolumesOptions : VolumeComponent
{
	[Tooltip("The overridden normal bias to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
	public ClampedFloatParameter normalBias; //Field offset: 0x38
	[Tooltip("A bias alongside the view vector to be applied to the world position when sampling the Adaptive Probe Volumes data structure. Unit is meters.")]
	public ClampedFloatParameter viewBias; //Field offset: 0x40
	[Tooltip("Whether to scale the bias for Adaptive Probe Volumes by the minimum distance between probes.")]
	public BoolParameter scaleBiasWithMinProbeDistance; //Field offset: 0x48
	[Tooltip("Noise to be applied to the sampling position. It can hide seams issues between subdivision levels, but introduces noise.")]
	public ClampedFloatParameter samplingNoise; //Field offset: 0x50
	[Tooltip("Whether to animate the noise when TAA is enabled. It can potentially remove the visible noise patterns.")]
	public BoolParameter animateSamplingNoise; //Field offset: 0x58
	[Tooltip("Method used to reduce leaks. Currently available modes are crude, but cheap methods.")]
	public APVLeakReductionModeParameter leakReductionMode; //Field offset: 0x60
	[Obsolete("This parameter isn't used anymore.")]
	public ClampedFloatParameter minValidDotProductValue; //Field offset: 0x68
	[Tooltip("When enabled, reflection probe normalization can only decrease the reflection intensity.")]
	public BoolParameter occlusionOnlyReflectionNormalization; //Field offset: 0x70
	[AdditionalProperty]
	[Tooltip("Global probe volumes weight. Allows for fading out probe volumes influence falling back to ambient probe.")]
	public ClampedFloatParameter intensityMultiplier; //Field offset: 0x78
	[AdditionalProperty]
	[Tooltip("Multiplier applied on the sky lighting when using sky occlusion.")]
	public ClampedFloatParameter skyOcclusionIntensityMultiplier; //Field offset: 0x80
	[AdditionalProperty]
	[Tooltip("Offset applied at runtime to probe positions in world space.\nThis is not considered while baking.")]
	public Vector3Parameter worldOffset; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClampedFloatParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3Parameter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private ProbeVolumesOptions() { }

}

