namespace UnityEngine.Rendering;

public class KeyframeUtility
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeyframeUtility() { }

	[CalledBy(Type = typeof(KeyframeUtility), Member = "EvalKeyAtTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Keyframe>), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime) { }

	[CalledBy(Type = typeof(KeyframeUtility), Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(KeyframeUtility), Member = "FetchKeyFromIndexClampEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Keyframe>), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(KeyframeUtility), Member = "EvalCurveSegmentAndDeriv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(Keyframe), typeof(Keyframe), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	private static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime) { }

	[CalledBy(Type = typeof(KeyframeUtility), Member = "EvalKeyAtTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Keyframe>), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	private static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime) { }

	[CalledBy(Type = typeof(KeyframeUtility), Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index) { }

	[CalledBy(Type = typeof(AnimationCurveParameter), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(KeyframeUtility), Member = "GetKeyframeAndClampEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Keyframe>), typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(KeyframeUtility), Member = "EvalKeyAtTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Keyframe>), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(KeyframeUtility), Member = "LerpSingleKeyframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe), typeof(Keyframe), typeof(float)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(AnimationCurve), Member = "ClearKeys", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t) { }

	[CalledBy(Type = typeof(KeyframeUtility), Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "ClearKeys", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAnimationCurve(AnimationCurve curve) { }

}

