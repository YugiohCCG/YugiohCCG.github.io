namespace DuelBot.Game.AI.Decks;

public struct SelectEffectYnData : ISerializable
{
	public DynamicCard EffectCard; //Field offset: 0x0
	public int Description; //Field offset: 0xB8

	[CalledBy(Type = typeof(AI_Custom), Member = "CustomSelectEffectYnRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicCard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public SelectEffectYnData(BotClientCard card, int desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

