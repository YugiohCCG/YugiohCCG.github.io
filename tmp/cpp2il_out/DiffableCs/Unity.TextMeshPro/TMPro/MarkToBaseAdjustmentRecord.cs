namespace TMPro;

public struct MarkToBaseAdjustmentRecord
{
	[SerializeField]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[SerializeField]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public uint baseGlyphID
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public uint markGlyphID
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MarkPositionAdjustment markPositionAdjustment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_baseGlyphID() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint get_markGlyphID() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_baseGlyphID(uint value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_markGlyphID(uint value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

}

