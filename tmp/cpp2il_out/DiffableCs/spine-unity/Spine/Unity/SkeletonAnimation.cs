namespace Spine.Unity;

[AddComponentMenu("Spine/SkeletonAnimation")]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonAnimation-Component")]
public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, ISpineComponent, IAnimationStateComponent
{
	public AnimationState state; //Field offset: 0xE8
	private bool wasUpdatedAfterInit; //Field offset: 0xF0
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; //Field offset: 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; //Field offset: 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; //Field offset: 0x108
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; //Field offset: 0x110
	[SerializeField]
	[SpineAnimation(null, null, True, False)]
	private string _animationName; //Field offset: 0x118
	public bool loop; //Field offset: 0x120
	public float timeScale; //Field offset: 0x124

	protected event UpdateBonesDelegate _BeforeApply
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateComplete
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateLocal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	protected event UpdateBonesDelegate _UpdateWorld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public event UpdateBonesDelegate BeforeApply
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateComplete
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateLocal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateWorld
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 remove { } //Length: 146
	}

	public string AnimationName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 80
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
		[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
		[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
		[Calls(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 268
	}

	public override AnimationState AnimationState
	{
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Play", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "OnStop", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 43
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
	public SkeletonAnimation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "AddSpineComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SkeletonDataAsset), typeof(bool)}, ReturnType = "T")]
	public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void ApplyAnimation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "ClearState", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ClearTracks", ReturnType = typeof(void))]
	public virtual void ClearState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[CallsUnknownMethods(Count = 1)]
	public string get_AnimationName() { }

	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Play", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "OnStop", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override AnimationState get_AnimationState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(AnimationState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationStateData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Initialize(bool overwrite, bool quiet = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonAnimation), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "LateUpdate", ReturnType = typeof(void))]
	public virtual void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "NewSpineGameObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonDataAsset), typeof(bool)}, ReturnType = "T")]
	public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset, bool quiet = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonAnimation), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void OnBecameVisible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "GetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(AnimationState), Member = "ClearTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_AnimationName(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[ContainsInvalidInstructions]
	private void Update() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonAnimation), Member = "OnBecameVisible", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skeleton), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Update(float deltaTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateAnimationStatus(float deltaTime) { }

}

