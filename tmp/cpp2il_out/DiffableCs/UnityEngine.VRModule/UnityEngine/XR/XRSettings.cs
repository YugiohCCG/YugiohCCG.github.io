namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Modules/VR/VRModule.h")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
public static class XRSettings
{

	public static bool enabled
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_enabled", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_isDeviceActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_loadedDeviceName", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_supportedDevices", ReturnType = "System.String[]")]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_occlusionMeshScale", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_mirrorViewMode", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_mirrorViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 2)]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
		 get { } //Length: 42
	}

	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[NativeName("IntermediateEyeTextureDesc")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 73
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static int eyeTextureHeight
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static int eyeTextureWidth
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static bool isDeviceActive
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_isDeviceActive", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeName("DeviceName")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static string loadedDeviceName
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_loadedDeviceName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 164
	}

	public static String[] supportedDevices
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_supportedDevices", ReturnType = "System.String[]")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_enabled", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_isDeviceActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_loadedDeviceName", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_supportedDevices", ReturnType = "System.String[]")]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_occlusionMeshScale", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_mirrorViewMode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_mirrorViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static bool get_enabled() { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_eyeTextureHeight() { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_eyeTextureWidth() { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_isDeviceActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_isDeviceActive() { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_loadedDeviceName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public static string get_loadedDeviceName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_loadedDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "get_supportedDevices", ReturnType = "System.String[]")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static String[] get_supportedDevices() { }

}

