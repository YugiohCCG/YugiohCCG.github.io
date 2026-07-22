namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
{
	private CullingResults m_CullingResults; //Field offset: 0x0
	private int m_LightIndex; //Field offset: 0x10
	private int m_SplitIndex; //Field offset: 0x14
	private int m_UseRenderingLayerMaskTest; //Field offset: 0x18
	private uint m_BatchLayerMask; //Field offset: 0x1C
	private ShadowSplitData m_SplitData; //Field offset: 0x20
	private ShadowObjectsFilter m_ObjectsFilter; //Field offset: 0x11C
	private BatchCullingProjectionType m_ProjectionType; //Field offset: 0x120

	public bool useRenderingLayerMaskTest
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ShadowSplitData), Member = "set_shadowCascadeBlendCullingFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex) { }

	[CalledBy(Type = typeof(ShadowDrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShadowSplitData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowSplitData)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool Equals(ShadowDrawingSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowDrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowDrawingSettings)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShadowSplitData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_useRenderingLayerMaskTest(bool value) { }

}

