namespace UnityEngine.Rendering.Universal;

internal class UniversalRenderPipelineDebugDisplayStats : DebugDisplayStats<URPProfileId>
{
	private DebugFrameTiming m_DebugFrameTiming; //Field offset: 0x30
	private List<URPProfileId> m_RecordedSamplers; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugFrameTiming), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UniversalRenderPipelineDebugDisplayStats() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <RegisterDebugUI>b__4_0() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <RegisterDebugUI>b__4_1(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <RegisterDebugUI>b__4_2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <RegisterDebugUI>b__4_3(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilingSampler), Member = "set_enableRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void DisableProfilingRecorders() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = "GetProfilerIdsToDisplay", ReturnType = "System.Collections.Generic.List`1<TProfileId>")]
	[CallsUnknownMethods(Count = 1)]
	public virtual void EnableProfilingRecorders() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugFrameTiming), Member = "RegisterDebugUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = "BuildDetailedStatsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(Widget))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	public virtual void RegisterDebugUI(List<Widget> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugFrameTiming), Member = "UpdateFrameTiming", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = "UpdateDetailedStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Update() { }

}

