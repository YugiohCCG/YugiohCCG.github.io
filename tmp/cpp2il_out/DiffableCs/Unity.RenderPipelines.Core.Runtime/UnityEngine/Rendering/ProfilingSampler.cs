namespace UnityEngine.Rendering;

[IgnoredByDeepProfiler]
public class ProfilingSampler
{
	[CompilerGenerated]
	private CustomSampler <sampler>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CustomSampler <inlineSampler>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x20
	private Recorder m_Recorder; //Field offset: 0x28
	private Recorder m_InlineRecorder; //Field offset: 0x30

	public float cpuElapsedTime
	{
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 81
	}

	public int cpuSampleCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	public bool enableRecording
	{
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "DisableProfilingRecorders", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 68
	}

	public float gpuElapsedTime
	{
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 81
	}

	public int gpuSampleCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	public float inlineCpuElapsedTime
	{
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 81
	}

	public int inlineCpuSampleCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
	}

	internal CustomSampler inlineSampler
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string name
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal CustomSampler sampler
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private ProfilingSampler() { }

	[CallerCount(Count = 124)]
	[Calls(Type = typeof(CustomSampler), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CustomSampler))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public ProfilingSampler(string name) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph+<>c", Member = "<BeginProfilingSampler>b__115_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph+ProfilingScopePassData", typeof(RenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Begin(CommandBuffer cmd) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph+<>c", Member = "<EndProfilingSampler>b__116_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph+ProfilingScopePassData", typeof(RenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void End(CommandBuffer cmd) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public static ProfilingSampler Get(TEnum marker) { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_cpuElapsedTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_cpuSampleCount() { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_gpuElapsedNanoseconds", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_gpuElapsedTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_gpuSampleBlockCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_gpuSampleCount() { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_elapsedNanoseconds", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_inlineCpuElapsedTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Recorder), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Recorder), Member = "get_sampleBlockCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_inlineCpuSampleCount() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal CustomSampler get_inlineSampler() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal CustomSampler get_sampler() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool IsValid() { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "DisableProfilingRecorders", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_enableRecording(bool value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_inlineSampler(CustomSampler value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_name(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_sampler(CustomSampler value) { }

}

