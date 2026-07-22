namespace UnityEngine.Rendering;

public struct RenderQueueRange : IEquatable<RenderQueueRange>
{
	private const int k_MinimumBound = 0; //Field offset: 0x0
	public static readonly int minimumBound; //Field offset: 0x0
	private const int k_MaximumBound = 5000; //Field offset: 0x0
	public static readonly int maximumBound; //Field offset: 0x4
	private int m_LowerBound; //Field offset: 0x0
	private int m_UpperBound; //Field offset: 0x4

	public static RenderQueueRange all
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 22
	}

	public int lowerBound
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static RenderQueueRange opaque
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), "UnityEngine.Rendering.Universal.DBufferSettings", "UnityEngine.Rendering.Universal.DecalDrawDBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawGBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(Material), typeof(LayerMask)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		 get { } //Length: 22
	}

	public static RenderQueueRange transparent
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 22
	}

	public int upperBound
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	private static RenderQueueRange() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(RenderQueueRange other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public static RenderQueueRange get_all() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_lowerBound() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), "UnityEngine.Rendering.Universal.DBufferSettings", "UnityEngine.Rendering.Universal.DecalDrawDBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawGBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(Material), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	public static RenderQueueRange get_opaque() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static RenderQueueRange get_transparent() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public int get_upperBound() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(RenderQueueRange left, RenderQueueRange right) { }

}

