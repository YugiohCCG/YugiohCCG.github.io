namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
internal abstract class RenderGraphResource : IRenderGraphResource
{
	public DescType desc; //Field offset: 0x0
	public bool validDesc; //Field offset: 0x0
	public ResType graphicsResource; //Field offset: 0x0
	protected RenderGraphResourcePool<ResType> m_Pool; //Field offset: 0x0

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RenderGraphResource`2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourcePool`1), Member = "TryGetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Type&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual void CreatePooledGraphicsResource(int frameIndex, int executionCount) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool IsCreated() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void ReleaseGraphicsResource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual void ReleasePooledGraphicsResource(int frameIndex, int executionCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public virtual void Reset(IRenderGraphResourcePool pool = null) { }

}

