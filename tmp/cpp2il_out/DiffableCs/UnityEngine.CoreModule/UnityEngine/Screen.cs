namespace UnityEngine;

[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static bool autorotateToLandscapeLeft
	{
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 56
	}

	public static bool autorotateToLandscapeRight
	{
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 56
	}

	public static bool autorotateToPortrait
	{
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 56
	}

	public static bool autorotateToPortraitUpsideDown
	{
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 56
	}

	public static Resolution currentResolution
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Coffee.UISoftMask.SoftMask+DownSamplingRate", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	public static float dpi
	{
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "UpdateScreenDPI", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("GetDPI")]
		 get { } //Length: 42
	}

	public static bool fullScreen
	{
		[CalledBy(Type = "Manager.Helper", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("IsFullscreen")]
		 get { } //Length: 42
	}

	public static FullScreenMode fullScreenMode
	{
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Coffee.UISoftMask.SoftMask+DownSamplingRate", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("GetFullscreenMode")]
		 get { } //Length: 42
	}

	public static int height
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 2)]
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static int msaaSamples
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static ScreenOrientation orientation
	{
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 292
	}

	public static Resolution[] resolutions
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "UpdateResolutions", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[FreeFunction("ScreenScripting::GetResolutions")]
		 get { } //Length: 179
	}

	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout
	{
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper", Member = "SetDisplayNeverSleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	public static int width
	{
		[CallerCount(Count = 26)]
		[CallsUnknownMethods(Count = 2)]
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Coffee.UISoftMask.SoftMask+DownSamplingRate", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Resolution get_currentResolution() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_currentResolution_Injected(out Resolution ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "UpdateScreenDPI", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[CalledBy(Type = "Manager.Helper", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Coffee.UISoftMask.SoftMask+DownSamplingRate", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("GetFullscreenMode")]
	public static FullScreenMode get_fullScreenMode() { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_msaaSamples() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static ScreenOrientation get_orientation() { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "UpdateResolutions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("ScreenScripting::GetResolutions")]
	public static Resolution[] get_resolutions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_resolutions_Injected(out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[NativeName("GetRequestedMSAASamples")]
	private static int GetMSAASamples() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static ScreenOrientation GetScreenOrientation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RequestOrientation(ScreenOrientation orient) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_autorotateToLandscapeLeft(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_autorotateToLandscapeRight(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_autorotateToPortrait(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_autorotateToPortraitUpsideDown(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void set_orientation(ScreenOrientation value) { }

	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "SetDisplayNeverSleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_sleepTimeout(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "AdjustAndGetScreenMSAASamples", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("SetRequestedMSAASamples")]
	public static void SetMSAASamples(int numSamples) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("SetIsOrientationEnabled")]
	private static void SetOrientationEnabled(EnabledOrientation orient, bool enabled) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	[CalledBy(Type = "Manager.Helper", Member = "DefineResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetResolution(int width, int height, bool fullscreen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

}

