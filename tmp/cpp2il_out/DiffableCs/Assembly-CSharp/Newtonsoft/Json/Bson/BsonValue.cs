namespace Newtonsoft.Json.Bson;

internal class BsonValue : BsonToken
{
	private readonly object _value; //Field offset: 0x20
	private readonly BsonType _type; //Field offset: 0x28

	public virtual BsonType Type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public object Value
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonValue(object value, BsonType type) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual BsonType get_Type() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public object get_Value() { }

}

