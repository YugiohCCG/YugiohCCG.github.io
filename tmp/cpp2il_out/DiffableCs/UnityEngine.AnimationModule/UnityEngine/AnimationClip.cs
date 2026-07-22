namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion
{

	[NativeProperty("Length", False, TargetType::Function (0))]
	public float length
	{
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AnimationClip() { }

	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

}

