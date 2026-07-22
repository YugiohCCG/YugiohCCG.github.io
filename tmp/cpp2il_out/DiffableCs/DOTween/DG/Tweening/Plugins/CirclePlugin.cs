namespace DG.Tweening.Plugins;

public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CirclePlugin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(DOTweenUtils), Member = "GetPointOnCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(CircleOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShapeCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, CircleOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PluginsManager), Member = "GetCustomPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPlugin", "T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenUtils), Member = "GetPointOnCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 2)]
	public Vector2 GetPositionOnCircle(CircleOptions options, float degrees) { }

	[CallerCount(Count = 0)]
	public virtual float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleOptions), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleOptions), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenUtils), Member = "GetPointOnCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleOptions), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenUtils), Member = "GetPointOnCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleOptions), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t) { }

}

