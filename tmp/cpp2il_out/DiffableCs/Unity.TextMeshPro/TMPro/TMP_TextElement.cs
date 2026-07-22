namespace TMPro;

public class TMP_TextElement
{
	[SerializeField]
	internal TextElementType m_ElementType; //Field offset: 0x10
	[SerializeField]
	internal uint m_Unicode; //Field offset: 0x14
	internal TMP_Asset m_TextAsset; //Field offset: 0x18
	internal Glyph m_Glyph; //Field offset: 0x20
	[SerializeField]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[SerializeField]
	internal float m_Scale; //Field offset: 0x2C

	public TextElementType elementType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Glyph glyph
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public uint glyphIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float scale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public TMP_Asset textAsset
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public uint unicode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TMP_TextElement() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextElementType get_elementType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Glyph get_glyph() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public uint get_glyphIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_scale() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public TMP_Asset get_textAsset() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint get_unicode() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_glyph(Glyph value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_glyphIndex(uint value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_scale(float value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_textAsset(TMP_Asset value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_unicode(uint value) { }

}

