namespace TMPro;

public struct TMP_LinkInfo
{
	public TMP_Text textComponent; //Field offset: 0x0
	public int hashCode; //Field offset: 0x8
	public int linkIdFirstCharacterIndex; //Field offset: 0xC
	public int linkIdLength; //Field offset: 0x10
	public int linkTextfirstCharacterIndex; //Field offset: 0x14
	public int linkTextLength; //Field offset: 0x18
	internal Char[] linkID; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "GetLinkID", ReturnType = typeof(string))]
	public string GetLink() { }

	[CalledBy(Type = "Scenes.Menu.AboutScreen", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.OptionBox", Member = "OnTapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection", Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "OnTappingHint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_LinkInfo), Member = "GetLink", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	public string GetLinkID() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetLinkText() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void SetLinkID(Char[] text, int startIndex, int length) { }

}

