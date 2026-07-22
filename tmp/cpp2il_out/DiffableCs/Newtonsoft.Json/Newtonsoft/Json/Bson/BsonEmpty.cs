namespace Newtonsoft.Json.Bson;

internal class BsonEmpty : BsonToken
{
	public static readonly BsonToken Null; //Field offset: 0x0
	public static readonly BsonToken Undefined; //Field offset: 0x8
	[CompilerGenerated]
	private readonly BsonType <Type>k__BackingField; //Field offset: 0x20

	public virtual BsonType Type
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static BsonEmpty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private BsonEmpty(BsonType type) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual BsonType get_Type() { }

}

