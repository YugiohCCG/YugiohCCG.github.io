namespace DG.Tweening.Plugins.Core.PathCore;

public class Path
{
	private static CatmullRomDecoder _catmullRomDecoder; //Field offset: 0x0
	private static LinearDecoder _linearDecoder; //Field offset: 0x8
	private static CubicBezierDecoder _cubicBezierDecoder; //Field offset: 0x10
	public Single[] wpLengths; //Field offset: 0x10
	[SerializeField]
	public Vector3[] wps; //Field offset: 0x18
	[SerializeField]
	internal PathType type; //Field offset: 0x20
	[SerializeField]
	internal int subdivisionsXSegment; //Field offset: 0x24
	[SerializeField]
	internal int subdivisions; //Field offset: 0x28
	[SerializeField]
	internal ControlPoint[] controlPoints; //Field offset: 0x30
	[SerializeField]
	internal float length; //Field offset: 0x38
	[SerializeField]
	internal bool isFinalized; //Field offset: 0x3C
	[SerializeField]
	internal Single[] timesTable; //Field offset: 0x40
	[SerializeField]
	internal Single[] lengthsTable; //Field offset: 0x48
	internal int linearWPIndex; //Field offset: 0x50
	internal bool addedExtraStartWp; //Field offset: 0x54
	internal bool addedExtraEndWp; //Field offset: 0x55
	internal PathOptions plugOptions; //Field offset: 0x58
	private Path _incrementalClone; //Field offset: 0xC8
	private int _incrementalIndex; //Field offset: 0xD0
	private ABSPathDecoder _decoder; //Field offset: 0xD8
	private bool _changed; //Field offset: 0xE0
	internal Vector3[] nonLinearDrawWps; //Field offset: 0xE8
	internal Vector3 targetPosition; //Field offset: 0xF0
	internal Nullable<Vector3> lookAtPosition; //Field offset: 0xFC
	internal Color gizmoColor; //Field offset: 0x10C

	internal int minInputWaypoints
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 42
	}

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3[]), typeof(float), typeof(PathType), typeof(PathMode), typeof(int), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3[]), typeof(float), typeof(PathType), typeof(PathMode), typeof(int), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Path() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void AssignDecoder(PathType pathType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false) { }

	[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Destroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal Path CloneIncremental(int loopIncrement) { }

	[CalledBy(Type = typeof(PathPlugin), Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathOptions), typeof(Tween), typeof(bool), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Path), typeof(Path), typeof(float), typeof(bool), typeof(UpdateNotice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal float ConvertToConstantPathPerc(float perc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions) { }

	[CalledBy(Type = typeof(PathPlugin), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "CloneIncremental", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Path))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void Destroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path)}, ReturnType = typeof(void))]
	internal void Draw() { }

	[CalledBy(Type = typeof(Path), Member = "Draw", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void Draw(Path p) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_minInputWaypoints() { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetDrawPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int)}, ReturnType = typeof(Vector3[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "ConvertToConstantPathPerc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void RefreshNonLinearDrawWps(Path p) { }

}

