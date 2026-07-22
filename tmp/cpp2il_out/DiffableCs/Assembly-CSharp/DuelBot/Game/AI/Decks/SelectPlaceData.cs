namespace DuelBot.Game.AI.Decks;

public struct SelectPlaceData : ISerializable
{
	public int CardID; //Field offset: 0x0
	public byte Player; //Field offset: 0x4
	public short Location; //Field offset: 0x6
	public int Filter; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SelectPlaceData(int cardId, int player, CardLocation location, int available) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

