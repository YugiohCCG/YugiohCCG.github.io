namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RayTracingAccelerationStructure ({handle.index})")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public struct RayTracingAccelerationStructureHandle
{
	private static RayTracingAccelerationStructureHandle s_NullHandle; //Field offset: 0x0
	internal ResourceHandle handle; //Field offset: 0x0

	public static RayTracingAccelerationStructureHandle nullHandle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 98
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static RayTracingAccelerationStructureHandle() { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure&), typeof(string)}, ReturnType = typeof(RayTracingAccelerationStructureHandle))]
	[CallerCount(Count = 1)]
	internal RayTracingAccelerationStructureHandle(int handle) { }

	[CallerCount(Count = 0)]
	public static RayTracingAccelerationStructureHandle get_nullHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object&))]
	[CallsUnknownMethods(Count = 4)]
	public static RayTracingAccelerationStructure op_Implicit(RayTracingAccelerationStructureHandle handle) { }

}

