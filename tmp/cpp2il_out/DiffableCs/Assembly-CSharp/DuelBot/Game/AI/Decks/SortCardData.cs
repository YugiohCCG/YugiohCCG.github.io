namespace DuelBot.Game.AI.Decks;

public struct SortCardData : ISerializable
{
	public DynamicCard[] SelectableCards; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	public SortCardData(IList<BotClientCard> cards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

