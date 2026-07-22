namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal abstract class BaseRenderGraphPass : RenderGraphPass
{
	internal PassData data; //Field offset: 0x0
	internal BaseRenderFunc<PassData, TRenderGraphContext> renderFunc; //Field offset: 0x0

	[CalledBy(Type = typeof(RenderGraphPass`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeRenderGraphPass`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RasterRenderGraphPass`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeRenderGraphPass`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderGraphPass), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected BaseRenderGraphPass`2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetRenderFuncHash() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool HasRenderFunc() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphPass), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void Initialize(int passIndex, PassData passData, string passName, RenderGraphPassType passType, ProfilingSampler sampler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "Release", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

