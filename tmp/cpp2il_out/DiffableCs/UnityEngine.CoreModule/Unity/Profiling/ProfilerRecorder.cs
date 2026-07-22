namespace Unity.Profiling;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ProfilerRecorderDebugView))]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
[UsedByNativeCode]
public struct ProfilerRecorder : IDisposable
{
	public enum ControlOptions
	{
		Start = 0,
		Stop = 1,
		Reset = 2,
		Release = 4,
		SetFilterToCurrentThread = 5,
		SetToCollectFromAllThreads = 6,
	}

	public enum CountOptions
	{
		Count = 0,
		MaxCount = 1,
	}

	internal const ProfilerRecorderOptions SharedRecorder = 128; //Field offset: 0x0
	internal ulong handle; //Field offset: 0x0

	public int Count
	{
		[CalledBy(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 145
	}

	public bool IsRunning
	{
		[CalledBy(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 143
	}

	public long LastValue
	{
		[CalledBy(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 143
	}

	public bool Valid
	{
		[CalledBy(Type = typeof(Recorder), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Recorder), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 81
	}

	[CalledBy(Type = typeof(Recorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	[BurstDiscard]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void CheckInitializedAndThrow() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static void Control(ProfilerRecorder handle, ControlOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Control_Injected(in ProfilerRecorder handle, ControlOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Create_Injected(in ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) { }

	[CalledBy(Type = typeof(Recorder), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public int get_Count() { }

	[CalledBy(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public bool get_IsRunning() { }

	[CalledBy(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public long get_LastValue() { }

	[CalledBy(Type = typeof(Recorder), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Recorder), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_Valid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static int GetCount(ProfilerRecorder handle, CountOptions countOptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetCount_Injected(in ProfilerRecorder handle, CountOptions countOptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static long GetLastValue(ProfilerRecorder handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long GetLastValue_Injected(in ProfilerRecorder handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static bool GetRunning(ProfilerRecorder handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetRunning_Injected(in ProfilerRecorder handle) { }

	[CalledBy(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public ProfilerRecorderSample GetSample(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetSampleInternal_Injected(in ProfilerRecorder handle, int index, out ProfilerRecorderSample ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static bool GetValid(ProfilerRecorder handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetValid_Injected(in ProfilerRecorder handle) { }

	[CalledBy(Type = typeof(Recorder), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Recorder), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void Start() { }

	[CalledBy(Type = typeof(Recorder), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Recorder), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void Stop() { }

}

