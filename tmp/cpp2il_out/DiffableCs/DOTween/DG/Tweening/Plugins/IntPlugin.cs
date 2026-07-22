namespace DG.Tweening.Plugins;

public class IntPlugin : ABSTweenPlugin<Int32, Int32, NoOptions>
{

	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IntPlugin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int ConvertToStartValue(TweenerCore<Int32, Int32, NoOptions> t, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Int32> getter, DOSetter<Int32> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	public virtual float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset(TweenerCore<Int32, Int32, NoOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetChangeValue(TweenerCore<Int32, Int32, NoOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetFrom(TweenerCore<Int32, Int32, NoOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetFrom(TweenerCore<Int32, Int32, NoOptions> t, int fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetRelativeEndValue(TweenerCore<Int32, Int32, NoOptions> t) { }

}

