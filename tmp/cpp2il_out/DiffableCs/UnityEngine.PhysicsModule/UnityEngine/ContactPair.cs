namespace UnityEngine;

[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair
{
	internal readonly int m_ColliderID; //Field offset: 0x0
	internal readonly int m_OtherColliderID; //Field offset: 0x4
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	internal readonly uint m_NbPoints; //Field offset: 0x10
	internal readonly CollisionPairFlags m_Flags; //Field offset: 0x14
	internal readonly CollisionPairEventFlags m_Events; //Field offset: 0x16
	internal readonly Vector3 m_ImpulseSum; //Field offset: 0x18

	public Collider collider
	{
		[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Collider))]
		 get { } //Length: 88
	}

	internal bool hasRemovedCollider
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 20
	}

	public bool isCollisionEnter
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool isCollisionExit
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool isCollisionStay
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public Collider otherCollider
	{
		[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Collider))]
		 get { } //Length: 90
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Collider))]
	public Collider get_collider() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_hasRemovedCollider() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isCollisionEnter() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isCollisionExit() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isCollisionStay() { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Collider))]
	public Collider get_otherCollider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	public ContactPairPoint GetContactPoint(int index) { }

	[CalledBy(Type = typeof(Collision), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPair), Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPoint[]), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ContactPair), Member = "GetContactPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint&))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

}

