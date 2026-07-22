namespace DG.Tweening.Plugins;

public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
{

	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector3Plugin() { }

	[CallerCount(Count = 0)]
	public virtual Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) { }

}

