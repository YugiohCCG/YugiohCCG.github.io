namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonConverter
{

	public override bool CanRead
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool CanWrite
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected JsonConverter() { }

	public abstract bool CanConvert(Type objectType) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_CanRead() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_CanWrite() { }

	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

