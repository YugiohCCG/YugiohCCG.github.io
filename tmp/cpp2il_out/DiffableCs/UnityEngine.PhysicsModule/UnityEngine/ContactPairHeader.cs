namespace UnityEngine;

[IsReadOnly]
[UsedByNativeCode]
public struct ContactPairHeader
{
	internal readonly int m_BodyID; //Field offset: 0x0
	internal readonly int m_OtherBodyID; //Field offset: 0x4
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	internal readonly uint m_NbPairs; //Field offset: 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; //Field offset: 0x14
	internal readonly Vector3 m_RelativeVelocity; //Field offset: 0x18

	public Component body
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Component))]
		 get { } //Length: 74
	}

	internal bool hasRemovedBody
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 20
	}

	public Component otherBody
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Component))]
		 get { } //Length: 75
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Component))]
	public Component get_body() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_hasRemovedBody() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Component))]
	public Component get_otherBody() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactPairHeader), Member = "GetContactPair_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair*))]
	public ContactPair GetContactPair(int index) { }

	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "GetContactPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair&))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal ContactPair* GetContactPair_Internal(int index) { }

}

