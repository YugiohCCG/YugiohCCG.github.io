namespace DG.Tweening.Plugins;

public class FloatPlugin : ABSTweenPlugin<Single, Single, FloatOptions>
{

	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FloatPlugin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual float ConvertToStartValue(TweenerCore<Single, Single, FloatOptions> t, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<Single> getter, DOSetter<Single> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	public virtual float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset(TweenerCore<Single, Single, FloatOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetChangeValue(TweenerCore<Single, Single, FloatOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void SetFrom(TweenerCore<Single, Single, FloatOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void SetFrom(TweenerCore<Single, Single, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetRelativeEndValue(TweenerCore<Single, Single, FloatOptions> t) { }

}

