namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class EntityKeyMemberConverter : JsonConverter
{
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember"; //Field offset: 0x0
	private const string KeyPropertyName = "Key"; //Field offset: 0x0
	private const string TypePropertyName = "Type"; //Field offset: 0x0
	private const string ValuePropertyName = "Value"; //Field offset: 0x0
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; //Field offset: 0x0

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EntityKeyMemberConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	public virtual bool CanConvert(Type objectType) { }

	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[CallsUnknownMethods(Count = 5)]
	private static void EnsureReflectionObject(Type objectType) { }

	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntityKeyMemberConverter), Member = "EnsureReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntityKeyMemberConverter), Member = "ReadAndAssertProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionObject), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EntityKeyMemberConverter), Member = "EnsureReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionObject), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetResolvedPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializerInternalWriter), Member = "TryConvertToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(String&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

