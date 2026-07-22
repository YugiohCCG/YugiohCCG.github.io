namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[RequiredByNativeCode]
[StaticAccessor("GetVFXManager()", StaticAccessorType::Dot (0))]
public static class VFXManager
{
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static VFXManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_ProcessCameraCommand_Injected(IntPtr cam, IntPtr cmd, in VFXCameraXRSettings camXRSettings, IntPtr cullResults, IntPtr customPassCullResults) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupVFXCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static VFXCameraBufferTypes IsCameraBufferNeeded_Injected(IntPtr cam) { }

	[CalledBy(Type = "UnityEngine.Rendering.CommandBufferHelpers", Member = "VFXManager_ProcessCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.UnsafeCommandBuffer", typeof(VFXCameraXRSettings), typeof(CullingResults)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupVFXCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetCameraBuffer_Injected(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height) { }

}

