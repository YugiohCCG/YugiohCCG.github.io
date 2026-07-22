namespace UnityEngine.TextCore.Text;

public class Character : TextElement
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Character() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public Character(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	internal Character(uint unicode, uint glyphIndex) { }

}

