namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{

	public RigidbodyType2D bodyType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("SetBodyType_Binding")]
		 set { } //Length: 131
	}

	public float gravityScale
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoneRigidbody2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool), typeof(float)}, ReturnType = typeof(Rigidbody2D))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "AddBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("Please use Rigidbody2D.bodyType instead.", False)]
	public bool isKinematic
	{
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoneRigidbody2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool), typeof(float)}, ReturnType = typeof(Rigidbody2D))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "AddBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public Vector2 linearVelocity
	{
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 135
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 128
	}

	public Vector2 position
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass0_0", Member = "<DOMove>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass1_0", Member = "<DOMoveX>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass2_0", Member = "<DOMoveY>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__2", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__3", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__5", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass5_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass7_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 9)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 135
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 128
	}

	public float rotation
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass3_0", Member = "<DORotate>b__0", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("Please use Rigidbody2D.linearVelocity instead. (UnityUpgradable) -> linearVelocity", False)]
	public Vector2 velocity
	{
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 135
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
		[Calls(Type = "UnityEngine.Physics", Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<ContactPairHeader>+ReadOnly<ContactPairHeader>"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsInvalidInstructions]
		 set { } //Length: 312
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Rigidbody2D() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_gravityScale() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_gravityScale_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Vector2 get_linearVelocity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass0_0", Member = "<DOMove>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass1_0", Member = "<DOMoveX>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass2_0", Member = "<DOMoveY>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__3", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass5_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass7_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_position() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_position_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass3_0", Member = "<DORotate>b__0", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_rotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_rotation_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Vector2 get_velocity() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass5_0", Member = "<DOPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass6_0", Member = "<DOLocalPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass7_0", Member = "<DOPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass8_0", Member = "<DOLocalPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void MovePosition(Vector2 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MovePosition_Injected(IntPtr _unity_self, in Vector2 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void MoveRotation(float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeMethod("MoveRotation")]
	private void MoveRotation_Angle(float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MoveRotation_Angle_Injected(IntPtr _unity_self, float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("SetBodyType_Binding")]
	public void set_bodyType(RigidbodyType2D value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_bodyType_Injected(IntPtr _unity_self, RigidbodyType2D value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoneRigidbody2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool), typeof(float)}, ReturnType = typeof(Rigidbody2D))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "AddBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_gravityScale(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_gravityScale_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoneRigidbody2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool), typeof(float)}, ReturnType = typeof(Rigidbody2D))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "AddBoundingBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_isKinematic(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_linearVelocity(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_linearVelocity_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_position(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_position_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_rotation(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_rotation_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = "UnityEngine.Physics", Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<ContactPairHeader>+ReadOnly<ContactPairHeader>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public void set_velocity(Vector2 value) { }

}

