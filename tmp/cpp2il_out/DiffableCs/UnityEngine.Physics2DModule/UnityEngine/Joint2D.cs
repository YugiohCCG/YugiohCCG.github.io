namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Joint2D.h")]
[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
public class Joint2D : Behaviour
{

	public Rigidbody2D connectedBody
	{
		[CalledBy(Type = "Spine.Unity.ActivateBasedOnFlipDirection", Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.HingeJoint2D[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 294
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Joint2D() { }

	[CalledBy(Type = "Spine.Unity.ActivateBasedOnFlipDirection", Member = "ResetJointPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.HingeJoint2D[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Rigidbody2D get_connectedBody() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_connectedBody_Injected(IntPtr _unity_self) { }

}

