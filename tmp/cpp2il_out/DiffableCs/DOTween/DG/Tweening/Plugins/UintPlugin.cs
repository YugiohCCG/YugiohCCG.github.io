namespace DG.Tweening.Plugins;

public class UintPlugin : ABSTweenPlugin<UInt32, UInt32, UintOptions>
{

	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UintPlugin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual uint ConvertToStartValue(TweenerCore<UInt32, UInt32, UintOptions> t, uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<UInt32> getter, DOSetter<UInt32> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset(TweenerCore<UInt32, UInt32, UintOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void SetChangeValue(TweenerCore<UInt32, UInt32, UintOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetFrom(TweenerCore<UInt32, UInt32, UintOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetFrom(TweenerCore<UInt32, UInt32, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetRelativeEndValue(TweenerCore<UInt32, UInt32, UintOptions> t) { }

}

