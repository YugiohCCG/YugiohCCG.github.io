namespace TMPro;

public struct MarkToMarkAdjustmentRecord
{
	[SerializeField]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[SerializeField]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public uint baseMarkGlyphID
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public uint combiningMarkGlyphID
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MarkPositionAdjustment combiningMarkPositionAdjustment
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
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_baseMarkGlyphID() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint get_combiningMarkGlyphID() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_baseMarkGlyphID(uint value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_combiningMarkGlyphID(uint value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

}

