namespace UnityEngine;

[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <isAnimatorMotion>k__BackingField; //Field offset: 0x18

	public bool isLooping
	{
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("IsLooping")]
		 get { } //Length: 118
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Motion() { }

	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("IsLooping")]
	public bool get_isLooping() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isLooping_Injected(IntPtr _unity_self) { }

}

