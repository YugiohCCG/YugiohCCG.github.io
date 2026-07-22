namespace UnityEngine.InputSystem.XR;

public struct Eyes
{
	public Vector3 m_LeftEyePosition; //Field offset: 0x0
	public Quaternion m_LeftEyeRotation; //Field offset: 0xC
	public Vector3 m_RightEyePosition; //Field offset: 0x1C
	public Quaternion m_RightEyeRotation; //Field offset: 0x28
	public Vector3 m_FixationPoint; //Field offset: 0x38
	public float m_LeftEyeOpenAmount; //Field offset: 0x44
	public float m_RightEyeOpenAmount; //Field offset: 0x48

	public Vector3 fixationPoint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public float leftEyeOpenAmount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Vector3 leftEyePosition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 15
	}

	public Quaternion leftEyeRotation
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	public float rightEyeOpenAmount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Vector3 rightEyePosition
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		 set { } //Length: 16
	}

	public Quaternion rightEyeRotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 get_fixationPoint() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_leftEyeOpenAmount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 get_leftEyePosition() { }

	[CallerCount(Count = 0)]
	public Quaternion get_leftEyeRotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_rightEyeOpenAmount() { }

	[CallerCount(Count = 0)]
	public Vector3 get_rightEyePosition() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Quaternion get_rightEyeRotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_fixationPoint(Vector3 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_leftEyeOpenAmount(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_leftEyePosition(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void set_leftEyeRotation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_rightEyeOpenAmount(float value) { }

	[CallerCount(Count = 0)]
	public void set_rightEyePosition(Vector3 value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_rightEyeRotation(Quaternion value) { }

}

