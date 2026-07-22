namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[UsedByNativeCode]
public struct AnimatorClipInfo
{
	private int m_ClipInstanceID; //Field offset: 0x0
	private float m_Weight; //Field offset: 0x4

	public AnimationClip clip
	{
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
		[CallerCount(Count = 14)]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 111
	}

	public float weight
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
	}

	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton", typeof(bool), typeof(AnimatorClipInfo), typeof(AnimatorStateInfo), typeof(int), typeof(float), "Spine.MixBlend", typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skeleton"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Collections.Generic.KeyValuePair`2<Animation, Single>")]
	[CallerCount(Count = 14)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public AnimationClip get_clip() { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_weight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr InstanceIDToAnimationClipPPtr_Injected(int instanceID) { }

}

