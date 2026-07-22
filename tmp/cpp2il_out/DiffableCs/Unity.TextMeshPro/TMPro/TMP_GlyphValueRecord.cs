namespace TMPro;

public struct TMP_GlyphValueRecord
{
	[SerializeField]
	internal float m_XPlacement; //Field offset: 0x0
	[SerializeField]
	internal float m_YPlacement; //Field offset: 0x4
	[SerializeField]
	internal float m_XAdvance; //Field offset: 0x8
	[SerializeField]
	internal float m_YAdvance; //Field offset: 0xC

	public float xAdvance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float xPlacement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float yAdvance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float yPlacement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_xAdvance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_xPlacement() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yAdvance() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yPlacement() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_xAdvance(float value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_xPlacement(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_yAdvance(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_yPlacement(float value) { }

}

