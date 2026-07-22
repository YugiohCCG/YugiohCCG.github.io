namespace TMPro;

public class KerningPair
{
	internal static KerningPair empty; //Field offset: 0x0
	[FormerlySerializedAs("AscII_Left")]
	[SerializeField]
	private uint m_FirstGlyph; //Field offset: 0x10
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; //Field offset: 0x14
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	private uint m_SecondGlyph; //Field offset: 0x24
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; //Field offset: 0x28
	[FormerlySerializedAs("XadvanceOffset")]
	public float xOffset; //Field offset: 0x38
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments; //Field offset: 0x3C

	public uint firstGlyph
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GlyphValueRecord_Legacy firstGlyphAdjustments
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public bool ignoreSpacingAdjustments
	{
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public uint secondGlyph
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GlyphValueRecord_Legacy secondGlyphAdjustments
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static KerningPair() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public KerningPair() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public KerningPair(uint left, uint right, float offset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	[CallerCount(Count = 0)]
	internal void ConvertLegacyKerningData() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public uint get_firstGlyph() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public bool get_ignoreSpacingAdjustments() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public uint get_secondGlyph() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_firstGlyph(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_secondGlyph(uint value) { }

}

