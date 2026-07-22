namespace DG.Tweening.Core;

public class TweenerCore : Tweener
{
	private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; //Field offset: 0x0
	public T2 startValue; //Field offset: 0x0
	public T2 endValue; //Field offset: 0x0
	public T2 changeValue; //Field offset: 0x0
	public TPlugOptions plugOptions; //Field offset: 0x0
	public DOGetter<T1> getter; //Field offset: 0x0
	public DOSetter<T1> setter; //Field offset: 0x0
	internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin; //Field offset: 0x0
	private Type _colorType; //Field offset: 0x0
	private Type _color32Type; //Field offset: 0x0

	[CalledBy(Type = typeof(TweenManager), Member = "GetTweener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Tweener), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal TweenerCore`3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "ShouldLogSafeModeCapturedError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = "get_TargetSite", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeModeReport), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeModeReportType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public virtual Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoChangeStartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tweener), Member = "DoChangeStartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public virtual Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Tweener), Member = "DoChangeValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public virtual Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoChangeValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tween), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual Tweener SetFrom(bool relative) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	internal virtual bool Startup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tweener), Member = "DoUpdateDelay", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", typeof(float)}, ReturnType = typeof(float))]
	[DeduplicatedMethod]
	internal virtual float UpdateDelay(float elapsed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual bool Validate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool ValidateChangeValueType(Type newType, out bool isColor32ToColor) { }

}

