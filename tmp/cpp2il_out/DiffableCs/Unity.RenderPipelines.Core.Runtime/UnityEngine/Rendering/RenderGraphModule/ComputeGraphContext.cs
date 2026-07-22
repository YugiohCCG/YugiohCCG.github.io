namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public class ComputeGraphContext : IDerivedRendergraphContext
{
	internal static ComputeCommandBuffer computecmd; //Field offset: 0x0
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x10
	public ComputeCommandBuffer cmd; //Field offset: 0x18

	public RenderGraphDefaultResources defaultResources
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public RenderGraphObjectPool renderGraphPool
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ComputeGraphContext() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ComputeGraphContext() { }

	[CalledBy(Type = typeof(ComputeRenderGraphPass`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphDefaultResources get_defaultResources() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphObjectPool get_renderGraphPool() { }

}

