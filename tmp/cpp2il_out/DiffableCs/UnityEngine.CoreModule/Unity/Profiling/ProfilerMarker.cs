namespace Unity.Profiling;

[IgnoredByDeepProfiler]
[UsedByNativeCode]
public struct ProfilerMarker
{
	[IgnoredByDeepProfiler]
	[UsedByNativeCode]
	internal struct AutoScope : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr m_Ptr; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal AutoScope(IntPtr markerPtr) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	public ProfilerMarker(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	public ProfilerMarker(ProfilerCategory category, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Pure]
	public AutoScope Auto() { }

}

