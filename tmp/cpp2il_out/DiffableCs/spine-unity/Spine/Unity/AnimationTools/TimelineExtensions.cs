namespace Spine.Unity.AnimationTools;

[Extension]
public static class TimelineExtensions
{

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetTimelineMovementDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(TranslateTimeline), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(TranslateTimeline), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Vector2 Evaluate(TranslateTimeline timeline, float time, SkeletonData skeletonData = null) { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetTimelineMovementDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(TranslateXTimeline), typeof(TranslateYTimeline), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CurveTimeline1), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 Evaluate(TranslateXTimeline xTimeline, TranslateYTimeline yTimeline, float time, SkeletonData skeletonData = null) { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Extension]
	public static T FindTimelineForBone(Animation a, int boneIndex) { }

	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static TranslateTimeline FindTranslateTimelineForBone(Animation a, int boneIndex) { }

}

