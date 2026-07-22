namespace UnityEngine.Rendering;

public struct RenderStateBlock : IEquatable<RenderStateBlock>
{
	private BlendState m_BlendState; //Field offset: 0x0
	private RasterState m_RasterState; //Field offset: 0x44
	private DepthState m_DepthState; //Field offset: 0x54
	private StencilState m_StencilState; //Field offset: 0x56
	private int m_StencilReference; //Field offset: 0x64
	private RenderStateMask m_Mask; //Field offset: 0x68

	public BlendState blendState
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 1)]
		 set { } //Length: 37
	}

	public DepthState depthState
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 7
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public RenderStateMask mask
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public RasterState rasterState
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 1)]
		 set { } //Length: 8
	}

	public int stencilReference
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public StencilState stencilState
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 19
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.Universal.Internal.DeferredLights"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		 set { } //Length: 16
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), typeof(bool), typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.Universal.Internal.DeferredLights"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public RenderStateBlock(RenderStateMask mask) { }

	[CalledBy(Type = typeof(RenderStateBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BlendState), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlendState)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(RenderStateBlock other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderStateBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public DepthState get_depthState() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public RenderStateMask get_mask() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_stencilReference() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilState get_stencilState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlendState), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(sbyte), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(StencilState), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 1)]
	public void set_blendState(BlendState value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_depthState(DepthState value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public void set_mask(RenderStateMask value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 1)]
	public void set_rasterState(RasterState value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_stencilReference(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.Universal.Internal.DeferredLights"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	public void set_stencilState(StencilState value) { }

}

