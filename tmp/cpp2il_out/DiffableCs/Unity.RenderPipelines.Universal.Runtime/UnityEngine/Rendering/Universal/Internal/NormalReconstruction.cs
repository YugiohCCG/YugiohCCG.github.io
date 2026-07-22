namespace UnityEngine.Rendering.Universal.Internal;

public static class NormalReconstruction
{
	private static readonly int s_NormalReconstructionMatrixID; //Field offset: 0x0
	private static Matrix4x4[] s_NormalReconstructionMatrix; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static NormalReconstruction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_universalCameraData", ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetupProperties(CommandBuffer cmd, in CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_universalCameraData", ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	public static void SetupProperties(RasterCommandBuffer cmd, in CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetupProperties(CommandBuffer cmd, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(DecalGBufferRenderPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DecalGBufferRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalScreenSpaceRenderPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalReconstruction), Member = "SetupProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetupProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData) { }

}

