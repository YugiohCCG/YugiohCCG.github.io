namespace DG.Tweening.Core.Easing;

public static class Bounce
{

	[CalledBy(Type = typeof(Bounce), Member = "EaseInOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_28", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_30", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bounce), Member = "EaseIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_29", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) { }

}

