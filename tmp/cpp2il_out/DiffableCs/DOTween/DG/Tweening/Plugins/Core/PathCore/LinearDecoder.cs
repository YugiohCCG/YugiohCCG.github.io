namespace DG.Tweening.Plugins.Core.PathCore;

internal class LinearDecoder : ABSPathDecoder
{

	internal virtual int minInputWaypoints
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LinearDecoder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinearDecoder), Member = "SetTimeToLengthTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal virtual int get_minInputWaypoints() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	[CalledBy(Type = typeof(LinearDecoder), Member = "FinalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

}

