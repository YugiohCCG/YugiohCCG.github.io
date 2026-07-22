namespace UnityEngine.Profiling;

[UsedByNativeCode]
public sealed class Recorder
{
	private const ProfilerRecorderOptions s_RecorderDefaultOptions = 153; //Field offset: 0x0
	internal static Recorder s_InvalidRecorder; //Field offset: 0x0
	private ProfilerRecorder m_RecorderCPU; //Field offset: 0x10
	private ProfilerRecorder m_RecorderGPU; //Field offset: 0x18

	public long elapsedNanoseconds
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_LastValue", ReturnType = typeof(long))]
		 get { } //Length: 48
	}

	public bool enabled
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuSampleCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuSampleCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuSampleCount", ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_IsRunning", ReturnType = typeof(bool))]
		 get { } //Length: 13
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "Start", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 set { } //Length: 108
	}

	public long gpuElapsedNanoseconds
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_LastValue", ReturnType = typeof(long))]
		 get { } //Length: 48
	}

	public int gpuSampleBlockCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuSampleCount", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "GetSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ProfilerRecorderSample))]
		 get { } //Length: 77
	}

	public int sampleBlockCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuSampleCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuSampleCount", ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ProfilerRecorder), Member = "GetSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ProfilerRecorderSample))]
		 get { } //Length: 77
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Recorder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Recorder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerRecorderHandle), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle), typeof(int), typeof(ProfilerRecorderOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerRecorderHandle), Member = "GetDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(ProfilerRecorderDescription))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Recorder(ProfilerRecorderHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_LastValue", ReturnType = typeof(long))]
	public long get_elapsedNanoseconds() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuSampleCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuSampleCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuSampleCount", ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_IsRunning", ReturnType = typeof(bool))]
	public bool get_enabled() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_LastValue", ReturnType = typeof(long))]
	public long get_gpuElapsedNanoseconds() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_gpuSampleCount", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "GetSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ProfilerRecorderSample))]
	public int get_gpuSampleBlockCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_cpuSampleCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "get_inlineCpuSampleCount", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "GetSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ProfilerRecorderSample))]
	public int get_sampleBlockCount() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "Start", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void set_enabled(bool value) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ProfilerRecorder), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = "Start", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetEnabled(bool state) { }

}

