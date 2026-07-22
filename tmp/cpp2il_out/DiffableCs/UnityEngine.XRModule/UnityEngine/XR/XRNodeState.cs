namespace UnityEngine.XR;

[UsedByNativeCode]
public struct XRNodeState
{
	private XRNode m_Type; //Field offset: 0x0
	private AvailableTrackingData m_AvailableFields; //Field offset: 0x4
	private Vector3 m_Position; //Field offset: 0x8
	private Quaternion m_Rotation; //Field offset: 0x14
	private Vector3 m_Velocity; //Field offset: 0x24
	private Vector3 m_AngularVelocity; //Field offset: 0x30
	private Vector3 m_Acceleration; //Field offset: 0x3C
	private Vector3 m_AngularAcceleration; //Field offset: 0x48
	private int m_Tracked; //Field offset: 0x54
	private ulong m_UniqueID; //Field offset: 0x58

	public XRNode nodeType
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public bool tracked
	{
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public ulong uniqueID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_nodeType(XRNode value) { }

	[CallerCount(Count = 0)]
	public void set_tracked(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_uniqueID(ulong value) { }

}

