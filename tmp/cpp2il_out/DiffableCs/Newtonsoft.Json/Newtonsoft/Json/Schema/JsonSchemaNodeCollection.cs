namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNodeCollection : KeyedCollection<String, JsonSchemaNode>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyedCollection`2), Member = ".ctor", ReturnType = typeof(void))]
	public JsonSchemaNodeCollection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual string GetKeyForItem(JsonSchemaNode item) { }

}

