namespace Spine.Unity;

[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanimRootMotion")]
public class SkeletonMecanimRootMotion : SkeletonRootMotionBase
{
	private const int DefaultMecanimLayerFlags = -1; //Field offset: 0x0
	public int mecanimLayerFlags; //Field offset: 0x90
	protected Vector2 movementDelta; //Field offset: 0x94
	private SkeletonMecanim skeletonMecanim; //Field offset: 0xA0

	public SkeletonMecanim SkeletonMecanim
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 167
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SkeletonMecanimRootMotion() { }

	[CallerCount(Count = 0)]
	protected virtual Vector2 CalculateAnimationsMovementDelta() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public SkeletonMecanim get_SkeletonMecanim() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MecanimTranslator), Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<Spine.Animation, System.Single>))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector2 GetRemainingRootMotion(int layerIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MecanimTranslator), Member = "GetActiveAnimationAndTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<Spine.Animation, System.Single>))]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(float)}, ReturnType = typeof(RootMotionInfo))]
	[CallsUnknownMethods(Count = 1)]
	public virtual RootMotionInfo GetRootMotionInfo(int layerIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "GetAnimationRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Animation)}, ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	private void OnClipApplied(Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRootMotionBase), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OnClipAppliedDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void Start() { }

}

