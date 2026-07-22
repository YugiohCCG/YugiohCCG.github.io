namespace UnityEngine;

[NativeHeader("Runtime/Diagnostics/Validation.h")]
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	internal static ILogger s_Logger; //Field offset: 0x8

	public static bool isDebugBuild
	{
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputUpdateType", "UnityEngine.InputSystem.LowLevel.InputEventBuffer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "AreMaximumEventBytesPerUpdateExceeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "ResetCurrentProcessedEventBytesForDevices", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "RegisterDebug", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static ILogger unityLogger
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Logger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static Debug() { }

	[CallerCount(Count = 58)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition, string message) { }

	[CallerCount(Count = 252)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "RenderDebugXRViewsFrustum", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawLine_Injected(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest) { }

	[CalledBy(Type = typeof(StackTraceUtility), Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ThreadSafe]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ExtractStackTraceNoAlloc_Injected(Byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputUpdateType", "UnityEngine.InputSystem.LowLevel.InputEventBuffer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "AreMaximumEventBytesPerUpdateExceeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "ResetCurrentProcessedEventBytesForDevices", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "RegisterDebug", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_isDebugBuild() { }

	[CallerCount(Count = 0)]
	public static ILogger get_unityLogger() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled() { }

	[CallerCount(Count = 275)]
	[CallsUnknownMethods(Count = 2)]
	public static void Log(object message) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Log(object message, object context) { }

	[CalledBy(Type = "UnityEngine.UIElements.ComputedStyle", Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StylePropertyReader", "UnityEngine.UIElements.ComputedStyle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedStyle", Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StyleValueManaged", "UnityEngine.UIElements.ComputedStyle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Length"}, ReturnType = "UnityEngine.UIElements.Layout.LayoutValue")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Rotate")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Scale")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Translate")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleLength"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleVariableResolver", Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogError(object message, object context) { }

	[CallerCount(Count = 259)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogError(object message) { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "TryCheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "UnityEngine.UIElements.StyleValueType", "UnityEngine.UIElements.StyleValueHandle", "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "UnityEngine.UIElements.StyleValueType", "UnityEngine.UIElements.StyleValueHandle"}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "ReadFunctionName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleValueHandle"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextGenerator", Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.TextGenerationSettings", typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogErrorFormat(object context, string format, Object[] args) { }

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogErrorFormat(string format, Object[] args) { }

	[CalledBy(Type = typeof(SpriteRenderer), Member = "InvokeSpriteChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Vector3Int>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SyncTile[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Vector3Int>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogException(Exception exception, object context) { }

	[CallerCount(Count = 44)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogException(Exception exception) { }

	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "MatchAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "MatchAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(string), typeof(string), typeof(string), typeof(Transform), typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogFormat(string format, Object[] args) { }

	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DebugLogHandler), Member = "Internal_Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogWarning(object message, object context) { }

	[CallerCount(Count = 185)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogWarning(object message) { }

	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CachePseudoStateMasks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature", Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AnimationReferenceAsset", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.EventDataReferenceAsset", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogWarningFormat(string format, Object[] args) { }

	[CalledBy(Type = "UnityEngine.TextGenerator", Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextGenerationSettings"}, ReturnType = "UnityEngine.TextGenerationSettings")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void LogWarningFormat(object context, string format, Object[] args) { }

}

