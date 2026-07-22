namespace Newtonsoft.Json.Converters;

public abstract class DateTimeConverterBase : JsonConverter
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DateTimeConverterBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[NullableContext(1)]
	public virtual bool CanConvert(Type objectType) { }

}

