namespace DG.Tweening;

public abstract class Tween : ABSSequentiable
{
	public float timeScale; //Field offset: 0x28
	public bool isBackwards; //Field offset: 0x2C
	internal bool isInverted; //Field offset: 0x2D
	public object id; //Field offset: 0x30
	public string stringId; //Field offset: 0x38
	public int intId; //Field offset: 0x40
	public object target; //Field offset: 0x48
	internal UpdateType updateType; //Field offset: 0x50
	internal bool isIndependentUpdate; //Field offset: 0x54
	public TweenCallback onPlay; //Field offset: 0x58
	public TweenCallback onPause; //Field offset: 0x60
	public TweenCallback onRewind; //Field offset: 0x68
	public TweenCallback onUpdate; //Field offset: 0x70
	public TweenCallback onStepComplete; //Field offset: 0x78
	public TweenCallback onComplete; //Field offset: 0x80
	public TweenCallback onKill; //Field offset: 0x88
	public TweenCallback<Int32> onWaypointChange; //Field offset: 0x90
	internal bool isFrom; //Field offset: 0x98
	internal bool isBlendable; //Field offset: 0x99
	internal bool isRecyclable; //Field offset: 0x9A
	internal bool isSpeedBased; //Field offset: 0x9B
	internal bool autoKill; //Field offset: 0x9C
	internal float duration; //Field offset: 0xA0
	internal int loops; //Field offset: 0xA4
	internal LoopType loopType; //Field offset: 0xA8
	internal float delay; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <isRelative>k__BackingField; //Field offset: 0xB0
	internal Ease easeType; //Field offset: 0xB4
	internal EaseFunction customEase; //Field offset: 0xB8
	public float easeOvershootOrAmplitude; //Field offset: 0xC0
	public float easePeriod; //Field offset: 0xC4
	public string debugTargetId; //Field offset: 0xC8
	internal Type typeofT1; //Field offset: 0xD0
	internal Type typeofT2; //Field offset: 0xD8
	internal Type typeofTPlugOptions; //Field offset: 0xE0
	[CompilerGenerated]
	private bool <active>k__BackingField; //Field offset: 0xE8
	internal bool isSequenced; //Field offset: 0xE9
	internal Sequence sequenceParent; //Field offset: 0xF0
	internal int activeId; //Field offset: 0xF8
	internal SpecialStartupMode specialStartupMode; //Field offset: 0xFC
	internal bool creationLocked; //Field offset: 0x100
	internal bool startupDone; //Field offset: 0x101
	[CompilerGenerated]
	private bool <playedOnce>k__BackingField; //Field offset: 0x102
	[CompilerGenerated]
	private float <position>k__BackingField; //Field offset: 0x104
	internal float fullDuration; //Field offset: 0x108
	internal int completedLoops; //Field offset: 0x10C
	internal bool isPlaying; //Field offset: 0x110
	internal bool isComplete; //Field offset: 0x111
	internal float elapsedDelay; //Field offset: 0x114
	internal bool delayComplete; //Field offset: 0x118
	internal int miscInt; //Field offset: 0x11C

	public internal bool active
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public float fullPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 154
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 34
	}

	public bool hasLoops
	{
		[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public internal bool isRelative
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public private bool playedOnce
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public internal float position
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Tween() { }

	internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[CalledBy(Type = typeof(Tweener), Member = "DoChangeStartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_active() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public float get_fullPosition() { }

	[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_hasLoops() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_isRelative() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_playedOnce() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_position() { }

	[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debugger), Member = "ShouldLogSafeModeCapturedError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = "get_TargetSite", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeModeReport), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeModeReportType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static bool OnTweenCallback(TweenCallback<T> callback, Tween t, T param) { }

	[CalledBy(Type = typeof(Sequence), Member = "ApplyInternalCycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(float), typeof(UpdateMode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "EvaluateTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Pause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "AddTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(TweenLink)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "PurgeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(Debugger), Member = "ShouldLogSafeModeCapturedError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = "get_TargetSite", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeModeReport), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeModeReportType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal static bool OnTweenCallback(TweenCallback callback, Tween t) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	internal override void Reset() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_active(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public void set_fullPosition(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_isRelative(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_playedOnce(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_position(float value) { }

	internal abstract bool Startup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override float UpdateDelay(float elapsed) { }

	internal abstract bool Validate() { }

}

