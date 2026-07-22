namespace DuelBot.Game.AI.Decks;

public struct SelectSumData : ISerializable
{
	public DynamicCard[] SelectableCards; //Field offset: 0x0
	public int Sum; //Field offset: 0x8
	public int Minimum; //Field offset: 0xC
	public int Maximum; //Field offset: 0x10
	public int SelectionHint; //Field offset: 0x14
	public bool MustBeExactValue; //Field offset: 0x18
	public DynamicCard[] MandatoryCards; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	public SelectSumData(IList<BotClientCard> cards, int sum, int min, int max, int hint, bool mode, IList<BotClientCard> mandatoryCards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

