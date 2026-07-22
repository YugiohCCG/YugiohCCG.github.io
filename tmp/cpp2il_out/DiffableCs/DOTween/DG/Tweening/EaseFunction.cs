namespace DG.Tweening;

public sealed class EaseFunction : MulticastDelegate
{

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(AnimationCurve)}, ReturnType = "T")]
	[CalledBy(Type = typeof(EaseManager), Member = "ToEaseFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease)}, ReturnType = typeof(EaseFunction))]
	[CallerCount(Count = 37)]
	[CallsUnknownMethods(Count = 4)]
	public EaseFunction(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override float EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override float Invoke(float time, float duration, float overshootOrAmplitude, float period) { }

}

