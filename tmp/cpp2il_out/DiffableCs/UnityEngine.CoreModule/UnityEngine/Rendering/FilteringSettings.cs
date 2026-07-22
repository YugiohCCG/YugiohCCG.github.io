namespace UnityEngine.Rendering;

public struct FilteringSettings : IEquatable<FilteringSettings>
{
	private RenderQueueRange m_RenderQueueRange; //Field offset: 0x0
	private int m_LayerMask; //Field offset: 0x8
	private uint m_RenderingLayerMask; //Field offset: 0xC
	private uint m_BatchLayerMask; //Field offset: 0x10
	private int m_ExcludeMotionVectorObjects; //Field offset: 0x14
	private int m_ForceAllMotionVectorObjects; //Field offset: 0x18
	private SortingLayerRange m_SortingLayerRange; //Field offset: 0x1C

	public uint batchLayerMask
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool excludeMotionVectorObjects
	{
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public bool forceAllMotionVectorObjects
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public RenderQueueRange renderQueueRange
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), "UnityEngine.Rendering.Universal.DBufferSettings", "UnityEngine.Rendering.Universal.DecalDrawDBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawGBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(Material), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthOnlyPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.Universal.Internal.DeferredLights"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	public FilteringSettings(Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0) { }

	[CalledBy(Type = typeof(FilteringSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(FilteringSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FilteringSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilteringSettings)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public RenderQueueRange get_renderQueueRange() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(FilteringSettings left, FilteringSettings right) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_batchLayerMask(uint value) { }

	[CallerCount(Count = 0)]
	public void set_excludeMotionVectorObjects(bool value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_forceAllMotionVectorObjects(bool value) { }

}

