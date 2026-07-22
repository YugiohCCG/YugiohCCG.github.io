namespace Spine.Unity;

public interface IAnimationStateComponent : ISpineComponent
{

	public AnimationState AnimationState
	{
		 get { } //Length: 0
	}

	public AnimationState get_AnimationState() { }

}

