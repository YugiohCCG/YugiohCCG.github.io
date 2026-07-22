namespace TMPro;

public struct TMP_GlyphAdjustmentRecord
{
	[SerializeField]
	internal uint m_GlyphIndex; //Field offset: 0x0
	[SerializeField]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; //Field offset: 0x4

	public uint glyphIndex
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public TMP_GlyphValueRecord glyphValueRecord
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_glyphIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_glyphIndex(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

}

