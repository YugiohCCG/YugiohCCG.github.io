namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Lens Flare (SRP)")]
[ExecuteAlways]
public sealed class LensFlareComponentSRP : MonoBehaviour
{
	private enum Version
	{
		Initial = 0,
	}

	private static float sCelestialAngularRadius; //Field offset: 0x0
	[SerializeField]
	private LensFlareDataSRP m_LensFlareData; //Field offset: 0x20
	[SerializeField]
	private Version version; //Field offset: 0x28
	[Min(0)]
	public float intensity; //Field offset: 0x2C
	[Min(1E-05)]
	public float maxAttenuationDistance; //Field offset: 0x30
	[Min(1E-05)]
	public float maxAttenuationScale; //Field offset: 0x34
	public AnimationCurve distanceAttenuationCurve; //Field offset: 0x38
	public AnimationCurve scaleByDistanceCurve; //Field offset: 0x40
	public bool attenuationByLightShape; //Field offset: 0x48
	public AnimationCurve radialScreenAttenuationCurve; //Field offset: 0x50
	public bool useOcclusion; //Field offset: 0x58
	[Obsolete("Replaced by environmentOcclusion.")]
	public bool useBackgroundCloudOcclusion; //Field offset: 0x59
	[FormerlySerializedAs("volumetricCloudOcclusion")]
	[FormerlySerializedAs("useFogOpacityOcclusion")]
	public bool environmentOcclusion; //Field offset: 0x5A
	[Obsolete("Replaced by environmentOcclusion.")]
	public bool useWaterOcclusion; //Field offset: 0x5B
	[Min(0)]
	public float occlusionRadius; //Field offset: 0x5C
	[Range(1, 64)]
	public uint sampleCount; //Field offset: 0x60
	public float occlusionOffset; //Field offset: 0x64
	[Min(0)]
	public float scale; //Field offset: 0x68
	public bool allowOffScreen; //Field offset: 0x6C
	[Obsolete("Please use environmentOcclusion instead.")]
	public bool volumetricCloudOcclusion; //Field offset: 0x6D
	public TextureCurve occlusionRemapCurve; //Field offset: 0x70
	public Light lightOverride; //Field offset: 0x78

	public LensFlareDataSRP lensFlareData
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "AddData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "RemoveData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 237
	}

	[CallerCount(Count = 0)]
	private static LensFlareComponentSRP() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AnimationCurve))]
	[Calls(Type = typeof(TextureCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(float), typeof(bool), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public LensFlareComponentSRP() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void Awake() { }

	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public float celestialProjectedOcclusionRadius(Camera mainCam) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public LensFlareDataSRP get_lensFlareData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCurve), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "RemoveData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "RemoveData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "AddData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "AddData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "RemoveData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "AddData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "RemoveData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareComponentSRP)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_lensFlareData(LensFlareDataSRP value) { }

}

