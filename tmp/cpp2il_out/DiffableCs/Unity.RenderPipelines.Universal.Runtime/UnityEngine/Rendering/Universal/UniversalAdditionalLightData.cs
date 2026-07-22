namespace UnityEngine.Rendering.Universal;

[DisallowMultipleComponent]
[RequireComponent(typeof(Light))]
public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
{
	public static readonly int AdditionalLightsShadowResolutionTierCustom; //Field offset: 0x0
	public static readonly int AdditionalLightsShadowResolutionTierLow; //Field offset: 0x4
	public static readonly int AdditionalLightsShadowResolutionTierMedium; //Field offset: 0x8
	public static readonly int AdditionalLightsShadowResolutionTierHigh; //Field offset: 0xC
	public static readonly int AdditionalLightsShadowDefaultResolutionTier; //Field offset: 0x10
	public static readonly int AdditionalLightsShadowDefaultCustomResolution; //Field offset: 0x14
	public static readonly int AdditionalLightsShadowMinimumResolution; //Field offset: 0x18
	[SerializeField]
	private int m_Version; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
	private bool m_UsePipelineSettings; //Field offset: 0x24
	private Light m_Light; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
	private int m_AdditionalLightsShadowResolutionTier; //Field offset: 0x30
	[Obsolete("This is obsolete, please use m_RenderingLayerMask instead.", False)]
	[SerializeField]
	private LightLayerEnum m_LightLayerMask; //Field offset: 0x34
	[SerializeField]
	private uint m_RenderingLayers; //Field offset: 0x38
	[SerializeField]
	private bool m_CustomShadowLayers; //Field offset: 0x3C
	[SerializeField]
	private LightLayerEnum m_ShadowLayerMask; //Field offset: 0x40
	[SerializeField]
	private uint m_ShadowRenderingLayers; //Field offset: 0x44
	[SerializeField]
	private Vector2 m_LightCookieSize; //Field offset: 0x48
	[SerializeField]
	private Vector2 m_LightCookieOffset; //Field offset: 0x50
	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality; //Field offset: 0x58

	public int additionalLightsShadowResolutionTier
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool customShadowLayers
	{
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	internal Light light
	{
		[CalledBy(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		internal get { } //Length: 126
	}

	[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieOffset
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[Obsolete("This is obsolete, please use renderingLayerMask instead.", True)]
	public LightLayerEnum lightLayerMask
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint renderingLayers
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead.", True)]
	public LightLayerEnum shadowLayerMask
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint shadowRenderingLayers
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
	public SoftShadowQuality softShadowQuality
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool usePipelineSettings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal int version
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	private static UniversalAdditionalLightData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UniversalAdditionalLightData() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_additionalLightsShadowResolutionTier() { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public bool get_customShadowLayers() { }

	[CalledBy(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	internal Light get_light() { }

	[CallerCount(Count = 0)]
	public Vector2 get_lightCookieOffset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_lightCookieSize() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public LightLayerEnum get_lightLayerMask() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public uint get_renderingLayers() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public LightLayerEnum get_shadowLayerMask() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public uint get_shadowRenderingLayers() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public SoftShadowQuality get_softShadowQuality() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_usePipelineSettings() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal int get_version() { }

	[CallerCount(Count = 0)]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
	public void set_customShadowLayers(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_lightCookieOffset(Vector2 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_lightCookieSize(Vector2 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_lightLayerMask(LightLayerEnum value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
	public void set_renderingLayers(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_shadowLayerMask(LightLayerEnum value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalAdditionalLightData), Member = "SyncLightAndShadowLayers", ReturnType = typeof(void))]
	public void set_shadowRenderingLayers(uint value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_softShadowQuality(SoftShadowQuality value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_usePipelineSettings(bool value) { }

	[CalledBy(Type = typeof(UniversalAdditionalLightData), Member = "set_renderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalLightData), Member = "set_customShadowLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalLightData), Member = "set_shadowRenderingLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalAdditionalLightData), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "set_renderingLayerMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SyncLightAndShadowLayers() { }

}

