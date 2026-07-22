namespace Unity.Profiling.LowLevel.Unsafe;

[IgnoredByDeepProfiler]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility
{

	[CallerCount(Count = 37)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void BeginSample(IntPtr markerPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static ushort CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static Void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	[CallerCount(Count = 186)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ThreadSafe]
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[CallerCount(Count = 102)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void EndSample(IntPtr markerPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, byte type, byte unit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

}

