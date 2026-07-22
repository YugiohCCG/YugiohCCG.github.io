namespace TMPro;

public class TMP_GlyphPairAdjustmentRecord
{
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x10
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x24
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x38

	public FontFeatureLookupFlags featureLookupFlags
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		 set { } //Length: 14
	}

	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		 set { } //Length: 14
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[CallsDeduplicatedMethods(Count = 14)]
	internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[CallerCount(Count = 0)]
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	[CallerCount(Count = 0)]
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	[CallerCount(Count = 0)]
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

}

