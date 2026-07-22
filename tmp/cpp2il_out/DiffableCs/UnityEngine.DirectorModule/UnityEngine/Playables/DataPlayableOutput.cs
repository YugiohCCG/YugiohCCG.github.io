namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
internal struct DataPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems+DataPlayableOutputList+DataPlayableOutputEnumerator", Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
	[CalledBy(Type = "UnityEngine.Playables.PlayableSystems+DataPlayableOutputList", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataPlayableOutput))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal DataPlayableOutput(PlayableOutputHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[RequiredByNativeCode]
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }

}

