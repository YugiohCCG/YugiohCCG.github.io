namespace UnityEngine;

[NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
public class AnchoredJoint2D : Joint2D
{

	public Vector2 connectedAnchor
	{
		[CalledBy(Type = "Spine.Unity.ActivateBasedOnFlipDirection", Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.HingeJoint2D[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 135
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AnchoredJoint2D() { }

	[CalledBy(Type = "Spine.Unity.ActivateBasedOnFlipDirection", Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.HingeJoint2D[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_connectedAnchor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_connectedAnchor_Injected(IntPtr _unity_self, out Vector2 ret) { }

}

