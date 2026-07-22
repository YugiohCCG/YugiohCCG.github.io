namespace DG.Tweening.Core;

public abstract class ABSSequentiable
{
	internal TweenType tweenType; //Field offset: 0x10
	internal float sequencedPosition; //Field offset: 0x14
	internal float sequencedEndPosition; //Field offset: 0x18
	internal TweenCallback onStart; //Field offset: 0x20

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ABSSequentiable() { }

}

