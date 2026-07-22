namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
{
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(AnimatorControllerPlayable), Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	private static AnimatorControllerPlayable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
	[Calls(Type = typeof(AnimatorControllerPlayable), Member = "SetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	public override bool Equals(AnimatorControllerPlayable other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override PlayableHandle GetHandle() { }

	[CalledBy(Type = typeof(AnimatorControllerPlayable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimatorControllerPlayable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableHandle), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayableHandle), Member = "IsPlayableOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void SetHandle(PlayableHandle handle) { }

}

