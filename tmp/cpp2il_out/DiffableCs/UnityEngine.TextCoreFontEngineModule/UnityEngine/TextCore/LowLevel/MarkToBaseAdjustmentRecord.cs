namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct MarkToBaseAdjustmentRecord
{
	[NativeName("baseGlyphID")]
	[SerializeField]
	private uint m_BaseGlyphID; //Field offset: 0x0
	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; //Field offset: 0x4
	[NativeName("markGlyphID")]
	[SerializeField]
	private uint m_MarkGlyphID; //Field offset: 0xC
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; //Field offset: 0x10

	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public uint baseGlyphID
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public uint markGlyphID
	{
		[CallerCount(Count = 118)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MarkPositionAdjustment markPositionAdjustment
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
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public uint get_baseGlyphID() { }

	[CallerCount(Count = 118)]
	[DeduplicatedMethod]
	public uint get_markGlyphID() { }

	[CallerCount(Count = 19)]
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

