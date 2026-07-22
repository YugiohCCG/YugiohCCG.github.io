namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public Vector3 position
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass0_0", Member = "<DOMove>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass1_0", Member = "<DOMoveX>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass2_0", Member = "<DOMoveY>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass3_0", Member = "<DOMoveZ>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__1", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__2", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__3", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__4", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass7_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass9_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 11)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
		[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public Quaternion rotation
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass4_0", Member = "<DORotate>b__0", ReturnType = typeof(Quaternion))]
		[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass5_0", Member = "<DOLookAt>b__0", ReturnType = typeof(Quaternion))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUtils+Physics", Member = "SetOrientationOnPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", typeof(Quaternion), typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		 set { } //Length: 863
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Rigidbody() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass0_0", Member = "<DOMove>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass1_0", Member = "<DOMoveX>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass2_0", Member = "<DOMoveY>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass3_0", Member = "<DOMoveZ>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__2", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__3", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass7_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass9_0", Member = "<DOPath>b__0", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 11)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_position() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass4_0", Member = "<DORotate>b__0", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass5_0", Member = "<DOLookAt>b__0", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Quaternion get_rotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass10_0", Member = "<DOLocalPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass8_0", Member = "<DOLocalPath>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void MovePosition(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MovePosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void MoveRotation(Quaternion rot) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MoveRotation_Injected(IntPtr _unity_self, in Quaternion rot) { }

	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_position(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUtils+Physics", Member = "SetOrientationOnPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", typeof(Quaternion), typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void set_rotation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

}

