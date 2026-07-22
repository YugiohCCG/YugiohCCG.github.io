namespace UnityEngine.TextCore.Text;

public class SpriteGlyph : Glyph
{
	public Sprite sprite; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SpriteGlyph() { }

}

