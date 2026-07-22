namespace UnityEngine.Rendering.RenderGraphModule;

internal abstract class IRenderGraphResourcePool
{
	[CompilerGenerated]
	private bool <IntraFrameMemoryAliasing>k__BackingField; //Field offset: 0x10

	public bool IntraFrameMemoryAliasing
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IRenderGraphResourcePool() { }

	public abstract void CheckFrameAllocation(bool onException, int frameIndex) { }

	public abstract void Cleanup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IntraFrameMemoryAliasing() { }

	public abstract void LogResources(RenderGraphLogger logger) { }

	public abstract void PurgeUnusedResources(int currentFrameIndex) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IntraFrameMemoryAliasing(bool value) { }

}

