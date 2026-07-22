namespace UnityEngine;

[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Misc/Player.h")]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public LogCallback(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public LowMemoryCallback(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String> deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action unloading; //Field offset: 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	public static event Action<String> deepLinkActivated
	{
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 263
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 263
	}

	public static event Action<Boolean> focusChanged
	{
		[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onPlayerFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 263
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onPlayerFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Shutdown", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 263
	}

	public static event Action quitting
	{
		[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "OnLoad", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 242
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static string companyName
	{
		[CalledBy(Type = "Manager.Customization", Member = "get_LogPath", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetPlayerSettings().GetCompanyName")]
		 get { } //Length: 222
	}

	public static string consoleLogPath
	{
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetConsoleLogPath")]
		 get { } //Length: 222
	}

	public static string dataPath
	{
		[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
		 get { } //Length: 222
	}

	public static NetworkReachability internetReachability
	{
		[CalledBy(Type = "Manager.Helper+<NetworkCheck>d__102", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetInternetReachability")]
		 get { } //Length: 42
	}

	public static bool isBatchMode
	{
		[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("::IsBatchmode")]
		 get { } //Length: 42
	}

	public static bool isEditor
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static bool isFocused
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "get_isAppFocused", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem+UpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "InitializeData", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_isPlayerFocused", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("IsPlayerFocused")]
		 get { } //Length: 42
	}

	public static bool isMobilePlatform
	{
		[CallerCount(Count = 22)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 146
	}

	public static bool isPlaying
	{
		[CallerCount(Count = 45)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("IsWorldPlaying")]
		 get { } //Length: 42
	}

	public static string persistentDataPath
	{
		[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		 get { } //Length: 222
	}

	public static RuntimePlatform platform
	{
		[CallerCount(Count = 85)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		 get { } //Length: 42
	}

	public static string productName
	{
		[CalledBy(Type = "Manager.Customization", Member = "get_LogPath", ReturnType = typeof(string))]
		[CalledBy(Type = "Manager.Updater", Member = "get_UserAgent", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetPlayerSettings().GetProductName")]
		 get { } //Length: 222
	}

	public static bool runInBackground
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_runInBackground", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		 set { } //Length: 51
	}

	public static string streamingAssetsPath
	{
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "RefreshAssetPath", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "GetAssetPath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		 get { } //Length: 222
	}

	public static int targetFrameRate
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGraphics", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetTargetFrameRate")]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper", Member = "SetFPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("SetTargetFrameRate")]
		 set { } //Length: 49
	}

	public static string temporaryCachePath
	{
		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater", Member = "get_TempZipPath", ReturnType = typeof(string))]
		[CalledBy(Type = "Manager.Updater", Member = "get_UpdateAPKPath", ReturnType = typeof(string))]
		[CalledBy(Type = "Card.Manager", Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		 get { } //Length: 222
	}

	internal static int unityVersionMaj
	{
		[CalledBy(Type = typeof(RayTracingShaderHelpURLAttribute), Member = "get_URL", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = True)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 42
	}

	internal static int unityVersionVer
	{
		[CalledBy(Type = typeof(RayTracingShaderHelpURLAttribute), Member = "get_URL", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = True)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 42
	}

	public static string version
	{
		[CalledBy(Type = "Scenes.Menu.MainMenu", Member = "UpdateLanguage", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater", Member = "get_UserAgent", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetApplicationInfo().GetVersion")]
		 get { } //Length: 222
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Application() { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_deepLinkActivated(Action<String> value) { }

	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onPlayerFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_focusChanged(Action<Boolean> value) { }

	[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "OnLoad", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[CalledBy(Type = "Manager.Customization", Member = "get_LogPath", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetPlayerSettings().GetCompanyName")]
	public static string get_companyName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_companyName_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetConsoleLogPath")]
	public static string get_consoleLogPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_consoleLogPath_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	public static string get_dataPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_dataPath_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Manager.Helper+<NetworkCheck>d__102", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetInternetReachability")]
	public static NetworkReachability get_internetReachability() { }

	[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("::IsBatchmode")]
	public static bool get_isBatchMode() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public static bool get_isEditor() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "get_isAppFocused", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem+UpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "InitializeData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_isPlayerFocused", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("IsPlayerFocused")]
	public static bool get_isFocused() { }

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_isMobilePlatform() { }

	[CallerCount(Count = 45)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("IsWorldPlaying")]
	public static bool get_isPlaying() { }

	[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	public static string get_persistentDataPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 85)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	public static RuntimePlatform get_platform() { }

	[CalledBy(Type = "Manager.Customization", Member = "get_LogPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_UserAgent", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetPlayerSettings().GetProductName")]
	public static string get_productName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_productName_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_runInBackground", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetPlayerSettingsRunInBackground")]
	public static bool get_runInBackground() { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "RefreshAssetPath", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "GetAssetPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	public static string get_streamingAssetsPath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGraphics", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetTargetFrameRate")]
	public static int get_targetFrameRate() { }

	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization", Member = "DefinePaths", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "get_TempZipPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_UpdateAPKPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager", Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	public static string get_temporaryCachePath() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = typeof(RayTracingShaderHelpURLAttribute), Member = "get_URL", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static int get_unityVersionMaj() { }

	[CalledBy(Type = typeof(RayTracingShaderHelpURLAttribute), Member = "get_URL", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static int get_unityVersionVer() { }

	[CalledBy(Type = "Scenes.Menu.MainMenu", Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "get_UserAgent", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetApplicationInfo().GetVersion")]
	public static string get_version() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static bool HasLogCallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void Internal_InitializeExitCancellationToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	private static void Internal_RaiseExitCancellationToken() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeforeRenderHelper), Member = "Invoke", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[CalledBy(Type = "Manager.Helper+<>c__DisplayClass77_0", Member = "<OpenURL>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextEventHandler", Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("OpenURL")]
	public static void OpenURL(string url) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "QuitGame", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void Quit() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_deepLinkActivated(Action<String> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onPlayerFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_focusChanged(Action<Boolean> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("SetPlayerSettingsRunInBackground")]
	public static void set_runInBackground(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "SetFPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("SetTargetFrameRate")]
	public static void set_targetFrameRate(int value) { }

}

