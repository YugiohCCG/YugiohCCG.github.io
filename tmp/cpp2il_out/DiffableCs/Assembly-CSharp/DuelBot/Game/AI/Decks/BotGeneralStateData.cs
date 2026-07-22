namespace DuelBot.Game.AI.Decks;

public struct BotGeneralStateData : ISerializable
{
	public bool IsReady; //Field offset: 0x0

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public BotGeneralStateData(bool ready) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

