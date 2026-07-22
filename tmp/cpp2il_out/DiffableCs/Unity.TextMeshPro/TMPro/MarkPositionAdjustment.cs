namespace TMPro;

public struct MarkPositionAdjustment
{
	[SerializeField]
	private float m_XPositionAdjustment; //Field offset: 0x0
	[SerializeField]
	private float m_YPositionAdjustment; //Field offset: 0x4

	public float xPositionAdjustment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float yPositionAdjustment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public MarkPositionAdjustment(float x, float y) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_xPositionAdjustment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yPositionAdjustment() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_xPositionAdjustment(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_yPositionAdjustment(float value) { }

}

