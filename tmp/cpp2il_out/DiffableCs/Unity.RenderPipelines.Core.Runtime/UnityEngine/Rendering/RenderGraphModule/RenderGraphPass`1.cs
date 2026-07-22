namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class RenderGraphPass : BaseRenderGraphPass<PassData, RenderGraphContext>
{
	internal static RenderGraphContext c; //Field offset: 0x0

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static RenderGraphPass`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRenderGraphPass`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public RenderGraphPass`1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "Release", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

