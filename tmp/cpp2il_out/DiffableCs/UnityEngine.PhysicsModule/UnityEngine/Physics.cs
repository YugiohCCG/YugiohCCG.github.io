namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
public class Physics
{
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ContactEventDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, IntPtr, Int32, Boolean> GenericContactModifyEvent; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x18
	private static readonly Collision s_ReusableCollision; //Field offset: 0x20

	public static PhysicsScene defaultPhysicsScene
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public static bool invokeCollisionCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static bool reuseCollisionCallbacks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Action`4<UnityEngine.PhysicsScene, System.IntPtr, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static Physics() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PhysicsScene get_defaultPhysicsScene() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_invokeCollisionCallbacks() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_reuseCollisionCallbacks() { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "get_body", ReturnType = typeof(Component))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "get_otherBody", ReturnType = typeof(Component))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetBodyByInstanceID_Injected(int instanceID) { }

	[CalledBy(Type = typeof(ContactPair), Member = "get_collider", ReturnType = typeof(Collider))]
	[CalledBy(Type = typeof(ContactPair), Member = "get_otherCollider", ReturnType = typeof(Collider))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetColliderByInstanceID_Injected(int instanceID) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Collision), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("Physics::RaycastAll")]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RaycastAll_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[Calls(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float)}, ReturnType = typeof(RaycastHit[]))]
	[CalledBy(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Physics), Member = "Internal_RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene), typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[CallsUnknownMethods(Count = 2)]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(RaycastHit[]))]
	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[CalledBy(Type = typeof(Physics), Member = "OnSceneContact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PhysicsScene), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rigidbody2D", Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContactPairHeader), Member = "GetContactPair_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair*))]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContactPair), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(ContactPair), Member = "get_otherCollider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Physics), Member = "GetCollisionToReport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(Collision))]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Physics), Member = "SendOnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Collision)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

}

