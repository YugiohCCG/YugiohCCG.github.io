namespace UnityEngine.Rendering.RenderGraphModule;

internal class BufferPool : RenderGraphResourcePool<GraphicsBuffer>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourcePool`1), Member = ".ctor", ReturnType = typeof(void))]
	public BufferPool() { }

	[CallerCount(Count = 0)]
	protected virtual string GetResourceName(in GraphicsBuffer res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual long GetResourceSize(in GraphicsBuffer res) { }

	[CallerCount(Count = 0)]
	protected virtual string GetResourceTypeName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual int GetSortIndex(GraphicsBuffer res) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void ReleaseInternalResource(GraphicsBuffer res) { }

}

