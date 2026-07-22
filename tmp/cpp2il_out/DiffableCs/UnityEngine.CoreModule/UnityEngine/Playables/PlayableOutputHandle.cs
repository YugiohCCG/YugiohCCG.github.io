namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableOutputHandle Null
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static PlayableOutputHandle() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object p) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(PlayableOutputHandle other) { }

	[CallerCount(Count = 0)]
	public static PlayableOutputHandle get_Null() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(PlayableOutputHandle), Member = "IsPlayableOutputOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	internal Type GetPlayableOutputType() { }

	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = "Internal_CallOnPlayerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableOutputHandle), Member = "GetPlayableOutputType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Playables.DataPlayableOutput", Member = "Internal_CallOnPlayerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

}

