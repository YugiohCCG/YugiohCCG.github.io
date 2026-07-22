namespace UnityEngine.Rendering.RenderGraphModule;

internal class RenderGraphLogger
{
	private Dictionary<String, StringBuilder> m_LogMap; //Field offset: 0x10
	private StringBuilder m_CurrentBuilder; //Field offset: 0x18
	private int m_CurrentIndentation; //Field offset: 0x20

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphDebugParams), typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RenderGraphLogger() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public void DecrementIndentation(int value) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "EndFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "FlushLogs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public string GetAllLogs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetLog(string logName) { }

	[CallerCount(Count = 0)]
	public void IncrementIndentation(int value) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize(string logName) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CullUnusedPasses", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogFrameInformation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogRendererListsCreation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogRenderPassBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogCulledPasses", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourcePool`1), Member = "LogResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "LogResources", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	public void LogLine(string format, Object[] args) { }

}

