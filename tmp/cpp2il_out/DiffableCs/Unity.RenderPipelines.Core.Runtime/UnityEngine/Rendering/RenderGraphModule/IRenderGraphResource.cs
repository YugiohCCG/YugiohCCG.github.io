namespace UnityEngine.Rendering.RenderGraphModule;

internal class IRenderGraphResource
{
	public bool imported; //Field offset: 0x10
	public bool shared; //Field offset: 0x11
	public bool sharedExplicitRelease; //Field offset: 0x12
	public bool requestFallBack; //Field offset: 0x13
	public bool forceRelease; //Field offset: 0x14
	public uint writeCount; //Field offset: 0x18
	public uint readCount; //Field offset: 0x1C
	public int cachedHash; //Field offset: 0x20
	public int transientPassIndex; //Field offset: 0x24
	public int sharedResourceLastFrameUsed; //Field offset: 0x28
	public int version; //Field offset: 0x2C

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public IRenderGraphResource() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CreateGraphicsResource() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void CreatePooledGraphicsResource(int frameIndex, int executionCount) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int GetDescHashCode() { }

	[CallerCount(Count = 0)]
	public override string GetName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int GetSortIndex() { }

	[CallerCount(Count = 0)]
	public override void IncrementReadCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void IncrementWriteCount() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool IsCreated() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LogCreation(RenderGraphLogger logger) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void LogRelease(RenderGraphLogger logger) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool NeedsFallBack() { }

	[CallerCount(Count = 0)]
	public override int NewVersion() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ReleaseGraphicsResource() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ReleasePooledGraphicsResource(int frameIndex, int executionCount) { }

	[CallerCount(Count = 0)]
	public override void Reset(IRenderGraphResourcePool _ = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateGraphicsResource() { }

}

