namespace DG.Tweening.Core.Easing;

public static class Flash
{

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_31", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Flash), Member = "WeightedEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Ease(float time, float duration, float overshootOrAmplitude, float period) { }

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Flash), Member = "WeightedEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period) { }

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Flash), Member = "WeightedEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period) { }

	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseManager+<>c", Member = "<ToEaseFunction>b__4_33", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Flash), Member = "WeightedEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period) { }

	[CalledBy(Type = typeof(Flash), Member = "Ease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Flash), Member = "EaseIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Flash), Member = "EaseOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Flash), Member = "EaseInOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res) { }

}

