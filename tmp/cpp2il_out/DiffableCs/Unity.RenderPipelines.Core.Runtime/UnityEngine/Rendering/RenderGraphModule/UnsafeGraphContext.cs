namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public class UnsafeGraphContext : IDerivedRendergraphContext
{
	internal static UnsafeCommandBuffer unsCmd; //Field offset: 0x0
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x10
	public UnsafeCommandBuffer cmd; //Field offset: 0x18

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
	[ContainsUnimplementedInstructions]
	private static UnsafeGraphContext() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeGraphContext() { }

	[CalledBy(Type = typeof(UnsafeRenderGraphPass`1), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
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

