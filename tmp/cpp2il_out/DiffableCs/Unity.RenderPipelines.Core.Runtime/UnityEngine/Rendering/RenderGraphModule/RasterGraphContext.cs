namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct RasterGraphContext : IDerivedRendergraphContext
{
	internal static RasterCommandBuffer rastercmd; //Field offset: 0x0
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x0
	public RasterCommandBuffer cmd; //Field offset: 0x8

	public RenderGraphDefaultResources defaultResources
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public RenderGraphObjectPool renderGraphPool
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static RasterGraphContext() { }

	[CalledBy(Type = typeof(RasterRenderGraphPass`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphDefaultResources get_defaultResources() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphObjectPool get_renderGraphPool() { }

}

