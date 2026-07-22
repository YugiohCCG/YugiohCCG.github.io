namespace DuelBot.Game.AI.Decks;

public struct SelectCounterData : ISerializable
{
	public short RequiredType; //Field offset: 0x0
	public short RequiredQuantity; //Field offset: 0x2
	public DynamicCard[] SelectableCards; //Field offset: 0x8
	public Int16[] Counters; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int16>)}, ReturnType = typeof(Int16[]))]
	[CallsUnknownMethods(Count = 1)]
	public SelectCounterData(short type, short quantity, IList<BotClientCard> cards, IList<Int16> counters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

