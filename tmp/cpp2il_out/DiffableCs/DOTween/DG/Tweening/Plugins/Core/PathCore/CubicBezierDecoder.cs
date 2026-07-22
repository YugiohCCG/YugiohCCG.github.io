namespace DG.Tweening.Plugins.Core.PathCore;

internal class CubicBezierDecoder : ABSPathDecoder
{
	private static readonly ControlPoint[] _PartialControlPs; //Field offset: 0x0
	private static readonly Vector3[] _PartialWps; //Field offset: 0x8

	internal virtual int minInputWaypoints
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static CubicBezierDecoder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CubicBezierDecoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CubicBezierDecoder), Member = "SetTimeToLengthTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CubicBezierDecoder), Member = "SetWaypointsLengths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal virtual void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal virtual int get_minInputWaypoints() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	[CalledBy(Type = typeof(CubicBezierDecoder), Member = "FinalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	[CalledBy(Type = typeof(CubicBezierDecoder), Member = "FinalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

}

