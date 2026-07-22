namespace DG.Tweening;

public abstract class Tweener : Tween
{
	internal bool hasManuallySetStartValue; //Field offset: 0x120
	internal bool isFromAllowed; //Field offset: 0x121

	[CalledBy(Type = typeof(TweenerCore`3), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Tweener() { }

	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = false) { }

	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Tweener), Member = "DOStartupSpecials", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "ShouldLogSafeModeCapturedError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = "get_TargetSite", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeModeReport), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeModeReportType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Tweener), Member = "DOStartupSpecials", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Tweener), Member = "DOStartupSpecials", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "Startup", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tweener), Member = "DOStartupSpecials", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "ShouldLogSafeModeCapturedError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Exception), Member = "get_TargetSite", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeModeReport), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeModeReportType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool DoStartup(TweenerCore<T1, T2, TPlugOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static void DOStartupDurationBased(TweenerCore<T1, T2, TPlugOptions> t) { }

	[CalledBy(Type = typeof(Tweener), Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeStartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpecialPluginsUtils), Member = "SetCameraShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialPluginsUtils), Member = "SetPunch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialPluginsUtils), Member = "SetShake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialPluginsUtils), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool DOStartupSpecials(TweenerCore<T1, T2, TPlugOptions> t) { }

	[CalledBy(Type = typeof(TweenerCore`3), Member = "UpdateDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static float DoUpdateDelay(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }

	internal abstract Tweener SetFrom(bool relative) { }

	[CalledBy(Type = typeof(DOTween), Member = "To", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool Setup(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) { }

}

