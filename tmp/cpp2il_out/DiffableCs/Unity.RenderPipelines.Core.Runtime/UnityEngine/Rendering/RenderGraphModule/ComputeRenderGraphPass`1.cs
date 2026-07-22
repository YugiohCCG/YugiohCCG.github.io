namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class ComputeRenderGraphPass : BaseRenderGraphPass<PassData, ComputeGraphContext>
{
	internal static ComputeGraphContext c; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static ComputeRenderGraphPass`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRenderGraphPass`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ComputeRenderGraphPass`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeGraphContext), Member = "FromInternalContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "Release", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

