namespace DuelBot.Game.AI.Decks;

public struct SelectTributeData : ISerializable
{
	public DynamicCard[] SelectableCards; //Field offset: 0x0
	public int Minimum; //Field offset: 0x8
	public int Maximum; //Field offset: 0xC
	public int SelectionHint; //Field offset: 0x10
	public bool Cancelable; //Field offset: 0x14
	public byte SelectableCount; //Field offset: 0x15

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SelectTributeData(IList<BotClientCard> cards, int min, int max, int hint, bool cancelable, byte count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

