namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaModelBuilder
{
	private JsonSchemaNodeCollection _nodes; //Field offset: 0x10
	private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels; //Field offset: 0x18
	private JsonSchemaNode _node; //Field offset: 0x20

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeyedCollection`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public JsonSchemaModelBuilder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallsUnknownMethods(Count = 2)]
	public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallsUnknownMethods(Count = 2)]
	public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void AddProperties(IDictionary<String, JsonSchema> source, IDictionary<String, JsonSchemaNode> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddProperty(IDictionary<String, JsonSchemaNode> target, string propertyName, JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaModel))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>), typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchemaNode>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchemaNode>), typeof(string), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(int), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddAdditionalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "AddAdditionalItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(KeyedCollection`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TItem")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>), typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchemaNode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaNode), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSchemaNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyedCollection`2), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchemaNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeyedCollection`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode), typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaNode))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "BuildNodeModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode)}, ReturnType = typeof(JsonSchemaModel))]
	[CallsUnknownMethods(Count = 3)]
	public JsonSchemaModel Build(JsonSchema schema) { }

	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaModel))]
	[CalledBy(Type = typeof(JsonSchemaModelBuilder), Member = "BuildNodeModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode)}, ReturnType = typeof(JsonSchemaModel))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchemaModel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchema>)}, ReturnType = typeof(JsonSchemaModel))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "BuildNodeModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaNode)}, ReturnType = typeof(JsonSchemaModel))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 21)]
	private JsonSchemaModel BuildNodeModel(JsonSchemaNode node) { }

}

