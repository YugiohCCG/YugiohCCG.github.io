namespace TMPro;

public class TMP_SpriteGlyph : Glyph
{
	public Sprite sprite; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TMP_SpriteGlyph() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "set_metrics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphMetrics)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "set_metrics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphMetrics)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }

}

