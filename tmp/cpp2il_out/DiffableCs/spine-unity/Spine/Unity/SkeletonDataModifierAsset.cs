namespace Spine.Unity;

public abstract class SkeletonDataModifierAsset : ScriptableObject
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected SkeletonDataModifierAsset() { }

	public abstract void Apply(SkeletonData skeletonData) { }

}

