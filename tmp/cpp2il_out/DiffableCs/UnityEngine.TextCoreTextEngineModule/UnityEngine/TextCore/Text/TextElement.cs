namespace UnityEngine.TextCore.Text;

public abstract class TextElement
{
	[SerializeField]
	protected TextElementType m_ElementType; //Field offset: 0x10
	[SerializeField]
	internal uint m_Unicode; //Field offset: 0x14
	internal TextAsset m_TextAsset; //Field offset: 0x18
	internal Glyph m_Glyph; //Field offset: 0x20
	[SerializeField]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[SerializeField]
	internal float m_Scale; //Field offset: 0x2C

	public TextElementType elementType
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		 get { } //Length: 7
	}

	public Glyph glyph
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public uint glyphIndex
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float scale
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public TextAsset textAsset
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public uint unicode
	{
		[CallerCount(Count = 88)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected TextElement() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	public TextElementType get_elementType() { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public Glyph get_glyph() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public uint get_glyphIndex() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public float get_scale() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public TextAsset get_textAsset() { }

	[CallerCount(Count = 88)]
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
	public void set_textAsset(TextAsset value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_unicode(uint value) { }

}

