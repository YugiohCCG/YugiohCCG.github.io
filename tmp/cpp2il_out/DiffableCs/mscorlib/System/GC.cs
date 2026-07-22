namespace System;

public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE; //Field offset: 0x0

	public static int MaxGeneration
	{
		[CalledBy(Type = "Manager.Helper+<CleanMemory>d__132", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 62
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void _ReRegisterForFinalize(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void _SuppressFinalize(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static GC() { }

	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCapture", Member = "InvokeOnCapturedPhotoToMemoryDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Windows.WebCam.PhotoCapture+OnCapturedToMemoryCallback", typeof(long), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCaptureFrame", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static void AddMemoryPressure(long bytesAllocated) { }

	[CalledBy(Type = "Manager.Helper+<CleanMemory>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting) { }

	[CalledBy(Type = "System.Diagnostics.Switch", Member = "_pruneCachedSwitches", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int CollectionCount(int generation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static object get_ephemeron_tombstone() { }

	[CalledBy(Type = "Manager.Helper+<CleanMemory>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_MaxGeneration() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetCollectionCount(int generation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int GetMaxGeneration() { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "GetMemoryPressure", ReturnType = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>")]
	[CallerCount(Count = 2)]
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	[CallerCount(Count = 0)]
	private static void InternalCollect(int generation) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void KeepAlive(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void RecordPressure(long bytesAllocated) { }

	[CalledBy(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConditionalWeakTable`2), Member = "Rehash", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCaptureFrame", Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "MarkAsUnhandled", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void ReRegisterForFinalize(object obj) { }

	[CallerCount(Count = 164)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void SuppressFinalize(object obj) { }

	[CalledBy(Type = "Manager.Helper+<CleanMemory>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void WaitForPendingFinalizers() { }

}

