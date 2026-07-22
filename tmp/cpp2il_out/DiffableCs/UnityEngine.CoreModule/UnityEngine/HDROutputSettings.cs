namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
[UsedByNativeCode]
public class HDROutputSettings
{
	public static HDROutputSettings[] displays; //Field offset: 0x0
	private static HDROutputSettings _mainDisplay; //Field offset: 0x8
	private int m_DisplayIndex; //Field offset: 0x10

	public bool active
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__0", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public bool automaticHDRTonemapping
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__4", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 118
	}

	public bool available
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__1", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__2", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__3", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__4", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__5", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__6", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__7", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__8", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__9", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public ColorGamut displayColorGamut
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputColorGamut", ReturnType = typeof(ColorGamut))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__2", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public GraphicsFormat graphicsFormat
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__3", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public bool HDRModeChangeRequested
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__9", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public static HDROutputSettings main
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput", Member = "CreateHDROuputDisplayTable", ReturnType = "UnityEngine.Rendering.DebugUI+Table")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		 get { } //Length: 79
	}

	public int maxFullFrameToneMapLuminance
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__8", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public int maxToneMapLuminance
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__7", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public int minToneMapLuminance
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__6", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	public float paperWhiteNits
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__5", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 102
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static HDROutputSettings() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal HDROutputSettings() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal HDROutputSettings(int displayIndex) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "get_isHDRDisplayOutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__0", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_active() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__4", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_automaticHDRTonemapping() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__1", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__2", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__3", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__4", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__5", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__6", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__7", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__8", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__9", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_available() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputColorGamut", ReturnType = typeof(ColorGamut))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__2", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public ColorGamut get_displayColorGamut() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__3", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GraphicsFormat get_graphicsFormat() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__9", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_HDRModeChangeRequested() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput", Member = "CreateHDROuputDisplayTable", ReturnType = "UnityEngine.Rendering.DebugUI+Table")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForMainDisplayIsActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	public static HDROutputSettings get_main() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__8", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int get_maxFullFrameToneMapLuminance() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__7", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public int get_maxToneMapLuminance() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__6", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int get_minToneMapLuminance() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "get_hdrDisplayOutputInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsHDROutput+<>c__DisplayClass1_0", Member = "<CreateHDROuputDisplayTable>b__5", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = "UnityEngine.Rendering.HDROutputUtils+HDRDisplayInformation")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float get_paperWhiteNits() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetActive(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetAutomaticHDRTonemapping(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetAvailable(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = False, ThrowsException = True)]
	private static ColorGamut GetDisplayColorGamut(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetGraphicsFormat", HasExplicitThis = False, ThrowsException = True)]
	private static GraphicsFormat GetGraphicsFormat(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetHDRModeChangeRequested", HasExplicitThis = False, ThrowsException = True)]
	private static bool GetHDRModeChangeRequested(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMaxFullFrameToneMapLuminance(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMaxToneMapLuminance(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = False, ThrowsException = True)]
	private static int GetMinToneMapLuminance(int displayIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = False, ThrowsException = True)]
	private static float GetPaperWhiteNits(int displayIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RequestHDRModeChange(bool enabled) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = False, ThrowsException = True)]
	private static void RequestHDRModeChangeInternal(int displayIndex, bool enabled) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetHDRState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_automaticHDRTonemapping(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = False, ThrowsException = True)]
	private static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted) { }

}

