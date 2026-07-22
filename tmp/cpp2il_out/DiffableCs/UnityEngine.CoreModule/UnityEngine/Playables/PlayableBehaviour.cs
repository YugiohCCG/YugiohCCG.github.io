namespace UnityEngine.Playables;

[RequiredByNativeCode]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PlayableBehaviour() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object Clone() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnGraphStart(Playable playable) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnGraphStop(Playable playable) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnPlayableCreate(Playable playable) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnPlayableDestroy(Playable playable) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void PrepareFrame(Playable playable, FrameData info) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

