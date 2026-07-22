namespace UnityEngine.InputSystem.XR;

public struct Bone
{
	public uint m_ParentBoneIndex; //Field offset: 0x0
	public Vector3 m_Position; //Field offset: 0x4
	public Quaternion m_Rotation; //Field offset: 0x10

	public uint parentBoneIndex
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public Vector3 position
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public Quaternion rotation
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_parentBoneIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 get_position() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public Quaternion get_rotation() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_parentBoneIndex(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_position(Vector3 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_rotation(Quaternion value) { }

}

