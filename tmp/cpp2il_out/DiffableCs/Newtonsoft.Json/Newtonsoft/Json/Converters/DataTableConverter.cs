namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class DataTableConverter : JsonConverter
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DataTableConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool CanConvert(Type valueType) { }

	[CalledBy(Type = typeof(DataTableConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRowCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableConverter), Member = "GetColumnDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "NewRow", ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	[CalledBy(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static Type GetColumnDataType(JsonReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataTable), Member = "set_TableName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetResolvedPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 24)]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

