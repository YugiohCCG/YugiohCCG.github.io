namespace TMPro;

public struct GlyphAnchorPoint
{
	[SerializeField]
	private float m_XCoordinate; //Field offset: 0x0
	[SerializeField]
	private float m_YCoordinate; //Field offset: 0x4

	public float xCoordinate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float yCoordinate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_xCoordinate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yCoordinate() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_xCoordinate(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_yCoordinate(float value) { }

}

