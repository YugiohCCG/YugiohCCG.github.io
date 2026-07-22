namespace UnityEngine.Rendering;

public class DebugFrameTiming
{
	private const string k_FpsFormatString = "{0:F1}"; //Field offset: 0x0
	private const string k_MsFormatString = "{0:F2}ms"; //Field offset: 0x0
	private const float k_RefreshRate = 0.2; //Field offset: 0x0
	internal FrameTimeSampleHistory m_FrameHistory; //Field offset: 0x10
	internal BottleneckHistory m_BottleneckHistory; //Field offset: 0x18
	[CompilerGenerated]
	private int <bottleneckHistorySize>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <sampleHistorySize>k__BackingField; //Field offset: 0x24
	private FrameTiming[] m_Timing; //Field offset: 0x28
	private FrameTimeSample m_Sample; //Field offset: 0x30

	public int bottleneckHistorySize
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int sampleHistorySize
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public DebugFrameTiming() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_0() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_10() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_11() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_12() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_13() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_14() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_15() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_16() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_17() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_18() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_19() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_2() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_20() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_21() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_3() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_4() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_5() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_6() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_7() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_8() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private object <RegisterDebugUI>b__17_9() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_bottleneckHistorySize() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_sampleHistorySize() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "RegisterDebugUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Widget>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 50)]
	[CallsUnknownMethods(Count = 160)]
	public void RegisterDebugUI(List<Widget> list) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void Reset() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_bottleneckHistorySize(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_sampleHistorySize(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FrameTimingManager), Member = "CaptureFrameTimings", ReturnType = typeof(void))]
	[Calls(Type = typeof(FrameTimingManager), Member = "GetLatestTimings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FrameTiming[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FrameTiming)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.FrameTiming>)}, ReturnType = typeof(FrameTiming))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FrameTimeSampleHistory), Member = "ComputeAggregateValues", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void UpdateFrameTiming() { }

}

