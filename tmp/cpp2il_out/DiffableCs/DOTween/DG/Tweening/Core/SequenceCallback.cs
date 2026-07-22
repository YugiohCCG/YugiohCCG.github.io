namespace DG.Tweening.Core;

internal class SequenceCallback : ABSSequentiable
{

	[CalledBy(Type = typeof(Sequence), Member = "DoInsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SequenceCallback(float sequencedPosition, TweenCallback callback) { }

}

