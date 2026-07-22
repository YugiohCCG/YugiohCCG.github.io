namespace UnityEngine.Rendering;

public struct ShaderTagId : IEquatable<ShaderTagId>
{
	public static readonly ShaderTagId none; //Field offset: 0x0
	private int m_Id; //Field offset: 0x0

	internal int id
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		internal set { } //Length: 3
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), "UnityEngine.Rendering.Universal.DBufferSettings", "UnityEngine.Rendering.Universal.DecalDrawDBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthOnlyPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<ShaderTagId>", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "System.String[]", "UnityEngine.Rendering.Universal.RenderQueueType", typeof(int), "UnityEngine.Rendering.Universal.RenderObjects+CustomCameraSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalScreenSpaceSettings", "UnityEngine.Rendering.Universal.DecalDrawGBufferSystem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem"}, ReturnType = typeof(void))]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public ShaderTagId(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(ShaderTagId other) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	internal int get_id() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(ShaderTagId tag1, ShaderTagId tag2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(ShaderTagId tag1, ShaderTagId tag2) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	internal void set_id(int value) { }

}

