namespace DG.Tweening.Plugins;

public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
{
	public const float MinLookAhead = 0.0001; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PathPlugin() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) { }

	[CallerCount(Count = 0)]
	private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "CloneIncremental", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Path))]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Path), Member = "ConvertToConstantPathPerc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PathPlugin), Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(Path), typeof(float), typeof(Vector3), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tween), Member = "get_hasLoops", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", typeof(Tween), "T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUtils+Physics", Member = "CreateDOTweenPathTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(bool), typeof(bool), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3[]), typeof(float), typeof(PathType), typeof(PathMode), typeof(int), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3[]), typeof(float), typeof(PathType), typeof(PathMode), typeof(int), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(PluginsManager), Member = "GetCustomPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPlugin", "T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) { }

	[CallerCount(Count = 0)]
	private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Destroy", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Reset(TweenerCore<Vector3, Path, PathOptions> t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DOTweenUtils), Member = "Vector3AreApproximatelyEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative) { }

	[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(DOTweenUtils), Member = "Angle2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) { }

}

