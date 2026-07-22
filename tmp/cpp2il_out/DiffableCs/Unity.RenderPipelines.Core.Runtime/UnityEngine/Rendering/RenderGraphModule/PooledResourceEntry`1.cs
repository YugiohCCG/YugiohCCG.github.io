namespace UnityEngine.Rendering.RenderGraphModule;

[IsReadOnly]
internal struct PooledResourceEntry
{
	public readonly Type resource; //Field offset: 0x0
	public readonly int frameIndex; //Field offset: 0x0
	public readonly int executionCount; //Field offset: 0x0

	[CallerCount(Count = 94)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public PooledResourceEntry`1(Type resource, int frameIndex, int executionCount) { }

}

