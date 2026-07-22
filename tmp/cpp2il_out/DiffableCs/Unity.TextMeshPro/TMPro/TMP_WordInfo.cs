namespace TMPro;

public struct TMP_WordInfo
{
	public TMP_Text textComponent; //Field offset: 0x0
	public int firstCharacterIndex; //Field offset: 0x8
	public int lastCharacterIndex; //Field offset: 0xC
	public int characterCount; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetWord() { }

}

