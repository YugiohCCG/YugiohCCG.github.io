namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header; //Field offset: 0x10
	private ContactPair m_Pair; //Field offset: 0x38
	private bool m_Flipped; //Field offset: 0x60
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	internal bool Flipped
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Collision() { }

	[CalledBy(Type = typeof(Physics), Member = "GetCollisionToReport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(Collision))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Flipped(bool value) { }

}

