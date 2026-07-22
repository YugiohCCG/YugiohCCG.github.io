namespace Scenes.Battle.DuelLogging;

public struct CardDataLog
{
	public int ID; //Field offset: 0x0
	public Texture2D Art; //Field offset: 0x8
	public Card Data; //Field offset: 0x10

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallsUnknownMethods(Count = 5)]
	public CardDataLog(ClientCard c) { }

	[CalledBy(Type = typeof(LogManager), Member = "OnCardHintCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardRevealed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnDeclareCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnDeclareCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardMoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Reason), typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(byte), typeof(CardLocation), typeof(byte), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardDataLog), Member = "LoadArt", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public CardDataLog(int cid) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void DefineArtTexture(Texture2D art, object o) { }

	[CalledBy(Type = typeof(CardDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LoadArt() { }

}

