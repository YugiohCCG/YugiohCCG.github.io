namespace UnityEngine.Experimental.Rendering;

public static class XRBuiltinShaderConstants
{
	public static readonly int unity_StereoCameraProjection; //Field offset: 0x0
	public static readonly int unity_StereoCameraInvProjection; //Field offset: 0x4
	public static readonly int unity_StereoMatrixV; //Field offset: 0x8
	public static readonly int unity_StereoMatrixInvV; //Field offset: 0xC
	public static readonly int unity_StereoMatrixP; //Field offset: 0x10
	public static readonly int unity_StereoMatrixInvP; //Field offset: 0x14
	public static readonly int unity_StereoMatrixVP; //Field offset: 0x18
	public static readonly int unity_StereoMatrixInvVP; //Field offset: 0x1C
	public static readonly int unity_StereoWorldSpaceCameraPos; //Field offset: 0x20
	public static readonly int unity_StereoEyeIndex; //Field offset: 0x24
	private static Matrix4x4[] s_cameraProjMatrix; //Field offset: 0x28
	private static Matrix4x4[] s_invCameraProjMatrix; //Field offset: 0x30
	private static Matrix4x4[] s_viewMatrix; //Field offset: 0x38
	private static Matrix4x4[] s_invViewMatrix; //Field offset: 0x40
	private static Matrix4x4[] s_projMatrix; //Field offset: 0x48
	private static Matrix4x4[] s_invProjMatrix; //Field offset: 0x50
	private static Matrix4x4[] s_viewProjMatrix; //Field offset: 0x58
	private static Matrix4x4[] s_invViewProjMatrix; //Field offset: 0x60
	private static Vector4[] s_worldSpaceCameraPos; //Field offset: 0x68

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 9)]
	private static XRBuiltinShaderConstants() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetBuiltinShaderConstants(CommandBuffer cmd) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetBuiltinShaderConstants(RasterCommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex) { }

}

