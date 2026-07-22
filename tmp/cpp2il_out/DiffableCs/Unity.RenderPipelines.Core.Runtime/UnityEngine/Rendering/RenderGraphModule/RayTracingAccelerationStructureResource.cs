namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RayTracingAccelerationStructureResource ({desc.name})")]
internal class RayTracingAccelerationStructureResource : RenderGraphResource<RayTracingAccelerationStructureDesc, RayTracingAccelerationStructure>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RayTracingAccelerationStructureResource() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public virtual string GetName() { }

}

