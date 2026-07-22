namespace DuelBot.Game.AI.Decks;

public struct IdleCmdStateData : ISerializable
{
	public DynamicCard[] SummonableCards; //Field offset: 0x0
	public DynamicCard[] SpecialSummonableCards; //Field offset: 0x8
	public DynamicCard[] ReposableCards; //Field offset: 0x10
	public DynamicCard[] MonsterSetableCards; //Field offset: 0x18
	public DynamicCard[] SpellSetableCards; //Field offset: 0x20
	public DynamicCard[] ActivableCards; //Field offset: 0x28
	public Int32[] ActivableDescriptions; //Field offset: 0x30
	public bool CanBattlePhase; //Field offset: 0x38
	public bool CanEndPhase; //Field offset: 0x39
	public bool CanShuffleHand; //Field offset: 0x3A

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "WriteBotDynamicCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(DynamicCard[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public IdleCmdStateData(BotMainPhase main) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

