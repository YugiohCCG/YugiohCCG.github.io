namespace DuelBot.Game.AI.Decks;

public struct SelectYesNoStateData : ISerializable
{
	public int Description; //Field offset: 0x0

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public SelectYesNoStateData(int description) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

