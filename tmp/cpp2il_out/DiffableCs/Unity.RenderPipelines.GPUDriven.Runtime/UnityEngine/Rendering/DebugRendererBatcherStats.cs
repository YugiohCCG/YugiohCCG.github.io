namespace UnityEngine.Rendering;

internal class DebugRendererBatcherStats : IDisposable
{
	public bool enabled; //Field offset: 0x10
	public NativeList<InstanceCullerViewStats> instanceCullerStats; //Field offset: 0x18
	public NativeList<InstanceOcclusionEventStats> instanceOcclusionEventStats; //Field offset: 0x20
	public NativeList<DebugOccluderStats> occluderStats; //Field offset: 0x28
	public bool occlusionOverlayEnabled; //Field offset: 0x30
	public bool occlusionOverlayCountVisible; //Field offset: 0x31
	public bool overrideOcclusionTestToAlwaysPass; //Field offset: 0x32

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceCullerViewStats>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DebugRendererBatcherStats() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceCullerViewStats>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceOcclusionEventStats>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DebugOccluderStats>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InstanceCuller), Member = "FlushDebugCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "UpdateFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public void FinalizeInstanceCullerViewStats() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private InstanceOcclusionEventStats GetLastInstanceOcclusionEventStatsForView(int viewIndex) { }

}

