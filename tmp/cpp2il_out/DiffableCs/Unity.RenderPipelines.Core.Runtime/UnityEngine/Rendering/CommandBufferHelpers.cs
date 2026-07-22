namespace UnityEngine.Rendering;

public struct CommandBufferHelpers
{
	internal static RasterCommandBuffer rasterCmd; //Field offset: 0x0
	internal static ComputeCommandBuffer computeCmd; //Field offset: 0x8
	internal static UnsafeCommandBuffer unsafeCmd; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private static CommandBufferHelpers() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static ComputeCommandBuffer GetComputeCommandBuffer(CommandBuffer baseBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static CommandBuffer GetNativeCommandBuffer(UnsafeCommandBuffer baseBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static RasterCommandBuffer GetRasterCommandBuffer(CommandBuffer baseBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static UnsafeCommandBuffer GetUnsafeCommandBuffer(CommandBuffer baseBuffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<ProcessVFXCameraCommand>b__142_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+VFXProcessCameraPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VFXManager), Member = "ProcessCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(VFXCameraXRSettings), typeof(CullingResults)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void VFXManager_ProcessCameraCommand(Camera cam, UnsafeCommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

}

