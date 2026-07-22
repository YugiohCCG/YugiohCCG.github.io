namespace TMPro;

public class TMP_Sprite : TMP_TextElement_Legacy
{
	public string name; //Field offset: 0x38
	public int hashCode; //Field offset: 0x40
	public int unicode; //Field offset: 0x44
	public Vector2 pivot; //Field offset: 0x48
	public Sprite sprite; //Field offset: 0x50

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TMP_Sprite() { }

}

