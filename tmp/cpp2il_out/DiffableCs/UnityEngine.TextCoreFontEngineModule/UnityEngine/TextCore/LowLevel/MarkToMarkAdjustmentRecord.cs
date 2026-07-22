namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToMarkAdjustmentRecord
{
	[NativeName("baseMarkGlyphID")]
	[SerializeField]
	private uint m_BaseMarkGlyphID; //Field offset: 0x0
	[NativeName("baseMarkAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; //Field offset: 0x4
	[NativeName("combiningMarkGlyphID")]
	[SerializeField]
	private uint m_CombiningMarkGlyphID; //Field offset: 0xC
	[NativeName("combiningMarkPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public uint baseMarkGlyphID
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public uint combiningMarkGlyphID
	{
		[CallerCount(Count = 118)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public uint get_baseMarkGlyphID() { }

	[CallerCount(Count = 118)]
	[DeduplicatedMethod]
	public uint get_combiningMarkGlyphID() { }

	[CallerCount(Count = 19)]
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

