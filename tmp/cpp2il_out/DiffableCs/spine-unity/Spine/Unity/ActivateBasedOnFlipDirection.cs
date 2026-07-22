namespace Spine.Unity;

public class ActivateBasedOnFlipDirection : MonoBehaviour
{
	public SkeletonRenderer skeletonRenderer; //Field offset: 0x20
	public SkeletonGraphic skeletonGraphic; //Field offset: 0x28
	public GameObject activeOnNormalX; //Field offset: 0x30
	public GameObject activeOnFlippedX; //Field offset: 0x38
	private HingeJoint2D[] jointsNormalX; //Field offset: 0x40
	private HingeJoint2D[] jointsFlippedX; //Field offset: 0x48
	private ISkeletonComponent skeletonComponent; //Field offset: 0x50
	private bool wasFlippedXBefore; //Field offset: 0x58

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ActivateBasedOnFlipDirection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CompensateMovementAfterFlipX(Transform toActivate, Transform toDeactivate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivateBasedOnFlipDirection), Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HingeJoint2D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void FixedUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ActivateBasedOnFlipDirection), Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HingeJoint2D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void HandleFlip(bool isFlippedX) { }

	[CalledBy(Type = typeof(ActivateBasedOnFlipDirection), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActivateBasedOnFlipDirection), Member = "HandleFlip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Joint2D), Member = "get_connectedBody", ReturnType = typeof(Rigidbody2D))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(AnchoredJoint2D), Member = "get_connectedAnchor", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ResetJointPositions(HingeJoint2D[] joints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	private void Start() { }

}

