namespace DG.Tweening.Core;

public static class DOTweenUtils
{
	private static Assembly[] _loadedAssemblies; //Field offset: 0x0
	private static readonly String[] _defAssembliesToQuery; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private static DOTweenUtils() { }

	[CalledBy(Type = typeof(PathPlugin), Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(Path), typeof(float), typeof(Vector3), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static float Angle2D(Vector3 from, Vector3 to) { }

	[CalledBy(Type = typeof(DOTweenComponent), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static Type GetLooseScriptType(string typeName) { }

	[CalledBy(Type = typeof(CirclePlugin), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), typeof(Vector2), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CircleOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector2>), typeof(float), typeof(Vector2), typeof(Vector2), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "GetPositionOnCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CircleOptions), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) { }

	[CalledBy(Type = typeof(PathPlugin), Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b) { }

	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static Vector3 Vector3FromAngle(float degrees, float magnitude) { }

}

