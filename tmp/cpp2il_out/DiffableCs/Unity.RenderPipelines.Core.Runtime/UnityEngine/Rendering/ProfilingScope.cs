namespace UnityEngine.Rendering;

public struct ProfilingScope : IDisposable
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public ProfilingScope(ProfilingSampler sampler) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public ProfilingScope(BaseCommandBuffer cmd, ProfilingSampler sampler) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

}

