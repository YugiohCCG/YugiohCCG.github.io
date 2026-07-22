namespace DG.Tweening;

public class EaseFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public float motionDelay; //Field offset: 0x10
		public EaseFunction customEase; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period) { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EaseFactory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(EaseManager), Member = "ToEaseFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease)}, ReturnType = typeof(EaseFunction))]
	[Calls(Type = typeof(EaseFactory), Member = "StopMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EaseFunction)}, ReturnType = typeof(EaseFunction))]
	public static EaseFunction StopMotion(int motionFps, Nullable<Ease> ease = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseFactory), Member = "StopMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EaseFunction)}, ReturnType = typeof(EaseFunction))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve) { }

	[CalledBy(Type = typeof(EaseFactory), Member = "StopMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Nullable`1<DG.Tweening.Ease>)}, ReturnType = typeof(EaseFunction))]
	[CalledBy(Type = typeof(EaseFactory), Member = "StopMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AnimationCurve)}, ReturnType = typeof(EaseFunction))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static EaseFunction StopMotion(int motionFps, EaseFunction customEase) { }

}

