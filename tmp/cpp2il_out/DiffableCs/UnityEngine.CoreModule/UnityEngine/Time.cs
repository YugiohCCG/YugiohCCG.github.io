namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
public class Time
{

	public static float deltaTime
	{
		[CallerCount(Count = 27)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static float fixedDeltaTime
	{
		[CalledBy(Type = "PhaseChange", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.Janken", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LPChange+<Animation>d__17", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "OnChangeLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.DiscordController", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<FixedUpdateTick>d__44", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.DraggableFrame", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General+<Fade>d__92", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.InteractableObject", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.RealtimeSearch", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static float fixedUnscaledTime
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeForFixedUpdate", ReturnType = typeof(double))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static int frameCount
	{
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup
	{
		[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "InitializeQuickLinks", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "OnApplicationPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DebugHandler+DebugSetupPassData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Panel", Member = "DefaultTimeSinceStartupMs", ReturnType = typeof(long))]
		[CalledBy(Type = "UnityEngine.UIElements.Panel", Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
		[CalledBy(Type = "Extensions.FPSData", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FPSData", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Execute", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	public static double realtimeSinceStartupAsDouble
	{
		[CalledBy(Type = "UnityEngine.InputSystem.Editor.SampleFrequencyCalculator", Member = "Update", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static float smoothDeltaTime
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	public static float time
	{
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnSortButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnShuffleButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	public static double timeAsDouble
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("CurTimeRational")]
	public static RationalTime timeAsRational
	{
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext", "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Time", Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "get_m_CurrentTime", ReturnType = typeof(DiscreteTime))]
		[CallerCount(Count = 20)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	public static float timeScale
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyGameplay", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper", Member = "SetTimeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 58
	}

	public static float unscaledDeltaTime
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayStats`1", Member = "UpdateDetailedStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static float unscaledTime
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_deltaTime() { }

	[CalledBy(Type = "PhaseChange", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.Janken", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LPChange+<Animation>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "OnChangeLP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.DiscordController", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<FixedUpdateTick>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General+<Fade>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.InteractableObject", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RealtimeSearch", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_fixedDeltaTime() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeForFixedUpdate", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_fixedUnscaledTime() { }

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_frameCount() { }

	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FPSData", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FPSData", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Panel", Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.UIElements.Panel", Member = "DefaultTimeSinceStartupMs", ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DebugHandler+DebugSetupPassData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "OnApplicationPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_realtimeSinceStartup() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Editor.SampleFrequencyCalculator", Member = "Update", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static double get_realtimeSinceStartupAsDouble() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_renderedFrameCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_smoothDeltaTime() { }

	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnSortButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnShuffleButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "RepositionCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+PassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_time() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static double get_timeAsDouble() { }

	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "get_m_CurrentTime", ReturnType = typeof(DiscreteTime))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Time", Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RequestCurrentState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.Event+Type"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnSubmitPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnCancelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext", "UnityEngine.InputForUI.EventSource", "UnityEngine.InputForUI.PointerEvent+Button"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnScrollWheelPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 2)]
	public static RationalTime get_timeAsRational() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_timeAsRational_Injected(out RationalTime ret) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_timeScale() { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayStats`1", Member = "UpdateDetailedStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_unscaledDeltaTime() { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_unscaledTime() { }

	[CalledBy(Type = "Manager.Helper", Member = "SetTimeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_timeScale(float value) { }

}

