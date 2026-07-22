namespace DG.Tweening;

public class DOTween
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public float v; //Field offset: 0x10
		public DOSetter<Single> setter; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass66_0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <To>b__0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <To>b__1(float x) { }

	}

	public static readonly string Version; //Field offset: 0x0
	public static bool useSafeMode; //Field offset: 0x8
	public static SafeModeLogBehaviour safeModeLogBehaviour; //Field offset: 0xC
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0x10
	public static bool showUnityEditorReport; //Field offset: 0x14
	public static float timeScale; //Field offset: 0x18
	public static bool useSmoothDeltaTime; //Field offset: 0x1C
	public static float maxSmoothUnscaledTime; //Field offset: 0x20
	internal static RewindCallbackMode rewindCallbackMode; //Field offset: 0x24
	private static LogBehaviour _logBehaviour; //Field offset: 0x28
	public static Func<LogType, Object, Boolean> onWillLog; //Field offset: 0x30
	public static bool drawGizmos; //Field offset: 0x38
	public static bool debugMode; //Field offset: 0x39
	private static bool _fooDebugStoreTargetId; //Field offset: 0x3A
	public static UpdateType defaultUpdateType; //Field offset: 0x3C
	public static bool defaultTimeScaleIndependent; //Field offset: 0x40
	public static AutoPlay defaultAutoPlay; //Field offset: 0x44
	public static bool defaultAutoKill; //Field offset: 0x48
	public static LoopType defaultLoopType; //Field offset: 0x4C
	public static bool defaultRecyclable; //Field offset: 0x50
	public static Ease defaultEaseType; //Field offset: 0x54
	public static float defaultEaseOvershootOrAmplitude; //Field offset: 0x58
	public static float defaultEasePeriod; //Field offset: 0x5C
	public static DOTweenComponent instance; //Field offset: 0x60
	private static bool _foo_isQuitting; //Field offset: 0x68
	internal static int maxActiveTweenersReached; //Field offset: 0x6C
	internal static int maxActiveSequencesReached; //Field offset: 0x70
	internal static SafeModeReport safeModeReport; //Field offset: 0x74
	internal static readonly List<TweenCallback> GizmosDelegates; //Field offset: 0x88
	internal static bool initialized; //Field offset: 0x90
	private static int _isQuittingFrame; //Field offset: 0x94

	public static bool debugStoreTargetId
	{
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		 get { } //Length: 151
		[CallerCount(Count = 0)]
		 set { } //Length: 84
	}

	internal static bool isQuitting
	{
		[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
		[CalledBy(Type = typeof(DOTween), Member = "AutoInit", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
		internal get { } //Length: 208
		[CalledBy(Type = typeof(DOTweenComponent), Member = "OnApplicationQuit", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
		internal set { } //Length: 138
	}

	public static LogBehaviour logBehaviour
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Debugger), Member = "SetLogPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogBehaviour)}, ReturnType = typeof(void))]
		 set { } //Length: 106
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static DOTween() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DOTween() { }

	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(DOVirtual), Member = "Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(float), typeof(DG.Tweening.TweenCallback`1<UnityEngine.Color>)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOTween), Member = "ToAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Color>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Color>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Color>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Color>), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(TweenManager), Member = "GetTweener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(Tweener), Member = "Setup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DOTween), Member = "get_isQuitting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	private static void AutoInit() { }

	[CalledBy(Type = typeof(DOTween), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTweenComponent), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "PurgeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PluginsManager), Member = "PurgeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "SetLogPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenComponent), Member = "DestroyInstance", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void Clear(bool destroy, bool isApplicationQuitting) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public static void Clear(bool destroy = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "PurgePools", ReturnType = typeof(void))]
	public static void ClearCachedTweens() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Complete(object targetOrId, bool withCallbacks = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int CompleteAll(bool withCallbacks = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	internal static int CompleteAndReturnKilledTot(object target, object id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	[CalledBy(Type = typeof(DOTween), Member = "KillAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DOTween), Member = "KillAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	internal static int CompleteAndReturnKilledTot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	internal static int CompleteAndReturnKilledTotExceptFor(Object[] excludeTargetsOrIds) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOFlip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Flip(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int FlipAll() { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	public static bool get_debugStoreTargetId() { }

	[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	[CalledBy(Type = typeof(DOTween), Member = "AutoInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	internal static bool get_isQuitting() { }

	[CallerCount(Count = 0)]
	public static LogBehaviour get_logBehaviour() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer), typeof(float), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Goto(object targetOrId, float to, bool andPlay = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int GotoAll(float to, bool andPlay = false) { }

	[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	[CalledBy(Type = typeof(DOTween), Member = "AutoInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(DOTween), Member = "set_logBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenComponent), Member = "Create", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<Boolean> recycleAllByDefault, Nullable<Boolean> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DOTween), Member = "get_isQuitting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	public static IDOTweenInit Init(Nullable<Boolean> recycleAllByDefault = null, Nullable<Boolean> useSafeMode = null, Nullable<LogBehaviour> logBehaviour = null) { }

	[CalledBy(Type = typeof(DOTween), Member = "ManualUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTween), Member = "To", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DOTween), Member = "get_isQuitting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	private static void InitCheck() { }

	[CalledBy(Type = "Extensions.General", Member = "IsTweening", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Kill(object target, object id, bool complete = false) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOKill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOKill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOKill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Kill(object targetOrId, bool complete = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DOTween), Member = "CompleteAndReturnKilledTot", ReturnType = typeof(int))]
	[Calls(Type = typeof(TweenManager), Member = "DespawnAll", ReturnType = typeof(int))]
	public static int KillAll(bool complete, Object[] idsOrTargetsToExclude) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "CompleteAndReturnKilledTot", ReturnType = typeof(int))]
	[Calls(Type = typeof(TweenManager), Member = "DespawnAll", ReturnType = typeof(int))]
	public static int KillAll(bool complete = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateType), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Pause(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PauseAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetActiveTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	public static List<Tween> PausedTweens(List<Tween> fillableList = null) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOPlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Play(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Play(object target, object id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayAll() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOPlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayBackwards(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayBackwards(object target, object id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayBackwardsAll() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOPlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayForward(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayForward(object target, object id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int PlayForwardAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetActiveTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	public static List<Tween> PlayingTweens(List<Tween> fillableList = null) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOPunchAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPunchPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPunchScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPunchRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendablePunchRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DOTween), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3[]), typeof(Single[])}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[Calls(Type = typeof(Extensions), Member = "NoFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Extensions), Member = "SetSpecialStartupMode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(SpecialStartupMode)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DORestart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int RestartAll(bool includeDelay = true) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DORewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int Rewind(object targetOrId, bool includeDelay = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int RewindAll(bool includeDelay = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	public static Sequence Sequence(object target) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(DOTween), Member = "Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetSequence", ReturnType = typeof(Sequence))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Sequence Sequence() { }

	[CallerCount(Count = 0)]
	public static void set_debugStoreTargetId(bool value) { }

	[CalledBy(Type = typeof(DOTweenComponent), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	internal static void set_isQuitting(bool value) { }

	[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debugger), Member = "SetLogPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogBehaviour)}, ReturnType = typeof(void))]
	public static void set_logBehaviour(LogBehaviour value) { }

	[CalledBy(Type = "Manager.Helper+<PostLoading>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "SetCapacities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShakeAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(Vector2), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Extensions), Member = "SetSpecialStartupMode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(SpecialStartupMode)}, ReturnType = "T")]
	[Calls(Type = typeof(Random), Member = "Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(DOTweenUtils), Member = "Vector3FromAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DOTween), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3[]), typeof(Single[])}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[Calls(Type = typeof(Extensions), Member = "NoFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShakeAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = true, bool fadeOut = true) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOSmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int SmoothRewind(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int SmoothRewindAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.UInt64>), typeof(DG.Tweening.Core.DOSetter`1<System.UInt64>), typeof(ulong), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.UInt64, System.UInt64, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.UInt64, System.UInt64, DG.Tweening.Plugins.Options.NoOptions>))]
	public static TweenerCore<UInt64, UInt64, NoOptions> To(DOGetter<UInt64> getter, DOSetter<UInt64> setter, ulong endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Int64>), typeof(DG.Tweening.Core.DOSetter`1<System.Int64>), typeof(long), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Int64, System.Int64, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Int64, System.Int64, DG.Tweening.Plugins.Options.NoOptions>))]
	public static TweenerCore<Int64, Int64, NoOptions> To(DOGetter<Int64> getter, DOSetter<Int64> setter, long endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Object>), typeof(DG.Tweening.Core.DOSetter`1<System.Object>), typeof(object), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Object, System.Object, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Object, System.Object, DG.Tweening.Plugins.Options.NoOptions>))]
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(string), typeof(float), typeof(bool), typeof(ScrambleMode), typeof(string)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<String, String, StringOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(StringOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Object>), typeof(DG.Tweening.Core.DOSetter`1<System.Object>), typeof(object), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Object, System.Object, DG.Tweening.Plugins.Options.StringOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Object, System.Object, DG.Tweening.Plugins.Options.StringOptions>))]
	public static TweenerCore<String, String, StringOptions> To(DOGetter<String> getter, DOSetter<String> setter, string endValue, float duration) { }

	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DORotateQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Quaternion), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalRotateQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Quaternion), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DOTween), Member = "InitCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetTweener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(NoOptions)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>))]
	[Calls(Type = typeof(Tweener), Member = "Setup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static TweenerCore<T1, T2, TPlugOptions> To(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(Extensions), Member = "NoFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Tweener To(DOSetter<Single> setter, float startValue, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(RectOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Rect>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Rect>), typeof(Rect), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>))]
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color2), typeof(Color2), typeof(ColorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<DG.Tweening.Color2>), typeof(DG.Tweening.Core.DOSetter`1<DG.Tweening.Color2>), typeof(Color2), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>))]
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Double>), typeof(DG.Tweening.Core.DOSetter`1<System.Double>), typeof(double), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Double, System.Double, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Double, System.Double, DG.Tweening.Plugins.Options.NoOptions>))]
	public static TweenerCore<Double, Double, NoOptions> To(DOGetter<Double> getter, DOSetter<Double> setter, double endValue, float duration) { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(FloatOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	public static TweenerCore<Single, Single, FloatOptions> To(DOGetter<Single> getter, DOSetter<Single> setter, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UintOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.UInt32>), typeof(DG.Tweening.Core.DOSetter`1<System.UInt32>), typeof(uint), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.UInt32, System.UInt32, DG.Tweening.Plugins.Options.UintOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.UInt32, System.UInt32, DG.Tweening.Plugins.Options.UintOptions>))]
	public static TweenerCore<UInt32, UInt32, UintOptions> To(DOGetter<UInt32> getter, DOSetter<UInt32> setter, uint endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Outline", typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DORotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(AxisConstraint), "System.Nullable`1<Vector3>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3), typeof(QuaternionOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Quaternion>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Quaternion>), typeof(Vector3), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>))]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(VectorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector4>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector4>), typeof(Vector4), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>))]
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(int), typeof(int), typeof(float), typeof(bool), typeof(CultureInfo)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Int32, Int32, NoOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Int32>), typeof(DG.Tweening.Core.DOSetter`1<System.Int32>), typeof(int), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>))]
	public static TweenerCore<Int32, Int32, NoOptions> To(DOGetter<Int32> getter, DOSetter<Int32> setter, int endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(VectorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(VectorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector2>), typeof(Vector2), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>))]
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(float), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", typeof(float), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(float), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Outline", typeof(float), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(float), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	[CalledBy(Type = typeof(DOTween), Member = "Punch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(object), typeof(Vector3ArrayOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(object), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, System.Object, DG.Tweening.Plugins.Options.Vector3ArrayOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, System.Object, DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[Calls(Type = typeof(Extensions), Member = "NoFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, Single[] durations) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(VectorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CallsUnknownMethods(Count = 1)]
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleAudio", Member = "DOTogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioMixer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int TogglePause(object targetOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	public static int TogglePauseAll() { }

	[CallerCount(Count = 0)]
	public static int TotalActiveTweens() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "TotalPlayingTweens", ReturnType = typeof(int))]
	public static int TotalPlayingTweens() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetTweensById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	public static List<Tween> TweensById(object id, bool playingOnly = false, List<Tween> fillableList = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "GetTweensByTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	public static List<Tween> TweensByTarget(object target, bool playingOnly = false, List<Tween> fillableList = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Validate", ReturnType = typeof(int))]
	public static int Validate() { }

}

