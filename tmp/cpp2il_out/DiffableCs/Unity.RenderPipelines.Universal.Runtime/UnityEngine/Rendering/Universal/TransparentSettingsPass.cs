namespace UnityEngine.Rendering.Universal;

internal class TransparentSettingsPass : ScriptableRenderPass
{
	private bool m_shouldReceiveShadows; //Field offset: 0xB8

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+<>c", Member = "<Render>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass+RenderingLayersPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MainLightShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	public static void ExecutePass(RasterCommandBuffer rasterCommandBuffer) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool Setup() { }

}

