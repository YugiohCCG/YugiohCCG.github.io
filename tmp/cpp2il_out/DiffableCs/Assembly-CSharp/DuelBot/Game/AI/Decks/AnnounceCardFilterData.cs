namespace DuelBot.Game.AI.Decks;

public struct AnnounceCardFilterData : ISerializable
{
	public byte FilterCount; //Field offset: 0x0
	public Int32[] AppliableFilters; //Field offset: 0x8

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AnnounceCardFilterData(byte count, Int32[] filters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

