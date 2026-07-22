namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Texture ({handle.index})")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct TextureHandle
{
	private static TextureHandle s_NullHandle; //Field offset: 0x0
	internal ResourceHandle handle; //Field offset: 0x0
	private bool builtin; //Field offset: 0xC

	public static TextureHandle nullHandle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 90
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static TextureHandle() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal TextureHandle(in ResourceHandle h) { }

	[CallerCount(Count = 0)]
	internal TextureHandle(int handle, bool shared = false, bool builtin = false) { }

	[CallerCount(Count = 0)]
	public static TextureHandle get_nullHandle() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
	[CallsUnknownMethods(Count = 1)]
	public TextureDesc GetDescriptor(RenderGraph renderGraph) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool IsBuiltin() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid() { }

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsUnknownMethods(Count = 2)]
	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass+<>c", Member = "<Render>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.MotionVectorRenderPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderSMAA>b__127_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+SMAAPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<UberPostSetupBloomPass>b__129_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+UberSetupBloomPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderBloomTexture>b__134_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+BloomPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderDoFGaussian>b__137_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+DoFGaussianPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderDoFBokeh>b__139_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+DoFBokehPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareScreenSpace>b__152_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlareScreenSpacePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderUberPost>b__164_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+UberPostPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass+<>c", Member = "<RecordRenderGraph>b__52_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass+SSAOPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.TemporalAA+TaaPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 2)]
	public static Texture op_Implicit(TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTexture))]
	[CallsUnknownMethods(Count = 2)]
	public static RenderTexture op_Implicit(TextureHandle texture) { }

	[CallerCount(Count = 87)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	public static RTHandle op_Implicit(TextureHandle texture) { }

}

