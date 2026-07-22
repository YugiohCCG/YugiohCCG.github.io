namespace Newtonsoft.Json.Serialization;

[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
[NullableContext(1)]
public class JsonPropertyCollection : KeyedCollection<String, JsonProperty>
{
	private readonly Type _type; //Field offset: 0x30
	private readonly List<JsonProperty> _list; //Field offset: 0x38

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(JsonPropertyCollection)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDynamicContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDynamicContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberSerialization)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CalledBy(Type = typeof(JsonDynamicContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
	[CalledBy(Type = typeof(JsonObjectContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(Newtonsoft.Json.Serialization.ObjectConstructor`1<System.Object>), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader+CreatorPropertyContext>))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(KeyedCollection`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public JsonPropertyCollection(Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(JsonPropertyCollection)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberSerialization)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(KeyedCollection`2), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyedCollection`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TItem")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void AddProperty(JsonProperty property) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(JsonPropertyCollection)}, ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.JsonProperty>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JsonProperty))]
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual string GetKeyForItem(JsonProperty item) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetImmutableConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonPropertyCollection)}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "MatchProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonPropertyCollection), typeof(string), typeof(Type)}, ReturnType = typeof(JsonProperty))]
	[CalledBy(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonProperty))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader+CreatorPropertyContext>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool TryGetProperty(string key, out JsonProperty item) { }

}

