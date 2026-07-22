namespace UnityEngine;

[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType::Arrow (1))]
public class Physics2D
{
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; //Field offset: 0x0

	public static PhysicsScene2D defaultPhysicsScene
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static Vector2 gravity
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 107
	}

	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Physics2D() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 get_gravity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_gravity_Injected(out Vector2 ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_queriesHitTriggers() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[RequiredByNativeCode]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask = -5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersectionAll_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[ExcludeFromDocs]
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float)}, ReturnType = typeof(RaycastHit2D[]))]
	[CalledBy(Type = typeof(Physics2D), Member = "GetRayIntersectionAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D[]))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", StaticAccessorType::DoubleColon (2))]
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask = -5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromDocs]
	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[CallsUnknownMethods(Count = 2)]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene2D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(ContactFilter2D))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene2D), Member = "RaycastList_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene2D), typeof(Vector2), typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(System.Collections.Generic.List`1<UnityEngine.RaycastHit2D>)}, ReturnType = typeof(int))]
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

}

