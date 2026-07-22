namespace UnityEngine.Rendering;

public class AnimationCurveParameter : VolumeParameter<AnimationCurve>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	public AnimationCurveParameter(AnimationCurve value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyframeUtility), Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Interp(AnimationCurve lhsCurve, AnimationCurve rhsCurve, float t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetValue(VolumeParameter parameter) { }

}

