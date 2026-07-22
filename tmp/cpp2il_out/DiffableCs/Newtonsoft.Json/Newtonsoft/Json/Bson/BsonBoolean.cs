namespace Newtonsoft.Json.Bson;

internal class BsonBoolean : BsonValue
{
	public static readonly BsonBoolean False; //Field offset: 0x0
	public static readonly BsonBoolean True; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static BsonBoolean() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private BsonBoolean(bool value) { }

}

