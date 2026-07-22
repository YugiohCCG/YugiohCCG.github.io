namespace UnityEngine.Rendering;

public abstract class DebugDisplayStats
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public TProfileId samplerId; //Field offset: 0x0
		public ProfilingSampler sampler; //Field offset: 0x0
		public DebugProfilingType<TProfileId> type; //Field offset: 0x0
		public DebugDisplayStats<TProfileId> <>4__this; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass19_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugDisplayStats`1), Member = "GetSamplerTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal object <BuildProfilingSamplerWidgetList>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public TProfileId samplerId; //Field offset: 0x0
		public DebugDisplayStats<TProfileId> <>4__this; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass19_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <BuildProfilingSamplerWidgetList>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public ProfilingSampler sampler; //Field offset: 0x0
		public <>c__DisplayClass19_1<TProfileId> CS$<>8__locals1; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass19_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugDisplayStats`1), Member = "<BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(Value))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Value <BuildProfilingSamplerWidgetList>b__3(DebugProfilingType<TProfileId> e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Type type; //Field offset: 0x0
		public Func<MemberInfo, Boolean> <>9__0; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetProfilerIdsToDisplay>b__0(MemberInfo m) { }

	}

	private class AccumulatedTiming
	{
		public float accumulatedValue; //Field offset: 0x0
		public float lastAverage; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AccumulatedTiming() { }

		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal void UpdateLastAverage(int frameCount) { }

	}

	private enum DebugProfilingType
	{
		CPU = 0,
		InlineCPU = 1,
		GPU = 2,
	}

	private static readonly String[] k_DetailedStatsColumnLabels; //Field offset: 0x0
	private const float k_AccumulationTimeInSeconds = 1; //Field offset: 0x0
	private Dictionary<TProfileId, AccumulatedTiming<TProfileId>>[] m_AccumulatedTiming; //Field offset: 0x0
	private float m_TimeSinceLastAvgValue; //Field offset: 0x0
	private int m_AccumulatedFrames; //Field offset: 0x0
	private HashSet<TProfileId> m_HiddenProfileIds; //Field offset: 0x0
	protected bool averageProfilerTimingsOverASecond; //Field offset: 0x0
	protected bool hideEmptyScopes; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private static DebugDisplayStats`1() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	protected DebugDisplayStats`1() { }

	[CalledBy(Type = typeof(<>c__DisplayClass19_2), Member = "<BuildProfilingSamplerWidgetList>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(Value))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Value), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Value <BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0(TProfileId samplerId, ProfilingSampler sampler, DebugProfilingType<TProfileId> type) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "RegisterDebugUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Widget>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[Calls(Type = typeof(Foldout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected Widget BuildDetailedStatsList(string title, List<TProfileId> samplers) { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildDetailedStatsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(Widget))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObservableList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = "set_enableRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueTuple), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 26)]
	[DeduplicatedMethod]
	private ObservableList<Widget> BuildProfilingSamplerWidgetList(IEnumerable<TProfileId> samplers) { }

	public abstract void DisableProfilingRecorders() { }

	public abstract void EnableProfilingRecorders() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "EnableProfilingRecorders", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Type), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MemberInfo[]))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	protected List<TProfileId> GetProfilerIdsToDisplay() { }

	[CalledBy(Type = typeof(<>c__DisplayClass19_0), Member = "<BuildProfilingSamplerWidgetList>b__1", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private float GetSamplerTiming(TProfileId samplerId, ProfilingSampler sampler, DebugProfilingType<TProfileId> type) { }

	public abstract void RegisterDebugUI(List<Widget> list) { }

	public abstract void Update() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = "UpdateListOfAveragedProfilerTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected void UpdateDetailedStats(List<TProfileId> samplers) { }

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "UpdateDetailedStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_cpuElapsedTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_inlineCpuElapsedTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ProfilingSampler), Member = "get_gpuElapsedTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(AccumulatedTiming), Member = "UpdateLastAverage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, List<TProfileId> samplers) { }

}

