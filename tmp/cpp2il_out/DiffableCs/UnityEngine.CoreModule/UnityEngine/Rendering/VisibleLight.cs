namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VisibleLight : IEquatable<VisibleLight>
{
	private LightType m_LightType; //Field offset: 0x0
	private Color m_FinalColor; //Field offset: 0x4
	private Rect m_ScreenRect; //Field offset: 0x14
	private Matrix4x4 m_LocalToWorldMatrix; //Field offset: 0x24
	private float m_Range; //Field offset: 0x64
	private float m_SpotAngle; //Field offset: 0x68
	private int m_InstanceId; //Field offset: 0x6C
	private VisibleLightFlags m_Flags; //Field offset: 0x70

	public Color finalColor
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public Light light
	{
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 122
	}

	public LightType lightType
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Matrix4x4 localToWorldMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "PassData&", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		 get { } //Length: 35
	}

	public float range
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), "System.Collections.Generic.List`1<Vector4>", typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		 get { } //Length: 8
	}

	public float spotAngle
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), "System.Collections.Generic.List`1<Vector4>", typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		 get { } //Length: 8
	}

	[CalledBy(Type = typeof(VisibleLight), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rect), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(VisibleLight other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleLight), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Color get_finalColor() { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 1)]
	public Light get_light() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public LightType get_lightType() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "SetupShadowCasterConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(VisibleLight&), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "RenderAdditionalShadowmapAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "PassData&", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	public Matrix4x4 get_localToWorldMatrix() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), "System.Collections.Generic.List`1<Vector4>", typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	public float get_range() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), "System.Collections.Generic.List`1<Vector4>", typeof(bool), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightMinMaxZJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TilingJob", Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeLightConstants_Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<VisibleLight>", typeof(int), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool), "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData", "Unity.Collections.NativeArray`1<VisibleLight>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	public float get_spotAngle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Rect), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

