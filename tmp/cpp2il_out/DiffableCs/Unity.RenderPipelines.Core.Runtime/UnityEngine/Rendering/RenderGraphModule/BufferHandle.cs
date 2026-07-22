namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Buffer ({handle.index})")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct BufferHandle
{
	private static BufferHandle s_NullHandle; //Field offset: 0x0
	internal ResourceHandle handle; //Field offset: 0x0

	public static BufferHandle nullHandle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 98
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static BufferHandle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal BufferHandle(in ResourceHandle h) { }

	[CallerCount(Count = 0)]
	internal BufferHandle(int handle, bool shared = false) { }

	[CallerCount(Count = 0)]
	public static BufferHandle get_nullHandle() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.IndirectBufferContextHandles&", "UnityEngine.Rendering.OccluderHandles&", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderHandles", Member = "UseForOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseRenderGraphBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderHandles", Member = "UseForOccluderUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseRenderGraphBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.OccluderParameters&", "System.ReadOnlySpan`1<OccluderSubviewUpdate>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid() { }

	[CalledBy(Type = typeof(SupportResources), Member = "LoadFromShaderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResources)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportResources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResources)}, ReturnType = typeof(SupportResources))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass+<>c", Member = "<Render>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ProbeVolumeDebugPass+WriteApvData", typeof(ComputeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.IndirectBufferContextHandles&", "UnityEngine.Rendering.OccluderHandles&", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "SetDebugPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), "UnityEngine.Rendering.OcclusionTestComputeShader&", typeof(int), "UnityEngine.Rendering.OccluderHandles&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "<RenderDebugOcclusionTestOverlay>b__29_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OcclusionTestOverlayPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 4)]
	public static GraphicsBuffer op_Implicit(BufferHandle buffer) { }

}

