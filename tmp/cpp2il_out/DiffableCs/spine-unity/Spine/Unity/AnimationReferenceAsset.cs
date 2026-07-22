namespace Spine.Unity;

[CreateAssetMenu(menuName = "Spine/Animation Reference Asset", order = 100)]
public class AnimationReferenceAsset : ScriptableObject, IHasSkeletonDataAsset, ISpineComponent
{
	private const bool QuietSkeletonData = True; //Field offset: 0x0
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; //Field offset: 0x18
	[SerializeField]
	[SpineAnimation(null, null, True, False)]
	protected string animationName; //Field offset: 0x20
	private Animation animation; //Field offset: 0x28

	public Animation Animation
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AnimationReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
		 get { } //Length: 43
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public AnimationReferenceAsset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	public Animation get_Animation() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	[CalledBy(Type = typeof(AnimationReferenceAsset), Member = "get_Animation", ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(AnimationReferenceAsset), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationReferenceAsset)}, ReturnType = typeof(Animation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Animation op_Implicit(AnimationReferenceAsset asset) { }

}

