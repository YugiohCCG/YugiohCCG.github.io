namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableHandle Null
	{
		[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static PlayableHandle() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object p) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(PlayableHandle other) { }

	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	public static PlayableHandle get_Null() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PlayableHandle), Member = "GetPlayableType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationOffsetPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationPosePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationRemoveScalePlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[CalledBy(Type = typeof(CameraPlayable), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraPlayable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialEffectPlayable), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialEffectPlayable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextureMixerPlayable), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureMixerPlayable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationClipPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationLayerMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationLayerMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationMotionXToDeltaPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationMotionXToDeltaPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimationScriptPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimationScriptPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Animations.AnimatorControllerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Animations.AnimatorControllerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Audio.AudioClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Audio.AudioClipPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Audio.AudioMixerPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Audio.AudioMixerPlayable"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Experimental.Video.VideoClipPlayable", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Video.VideoClipPlayable"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

}

