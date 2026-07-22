namespace Newtonsoft.Json.Schema;

[Extension]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public static class Extensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public bool valid; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass0_0() { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public IList<String> errors; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(JToken source, JsonSchema schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(JToken source, JsonSchema schema, out IList<String>& errorMessages) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(JToken source, JsonSchema schema) { }

	[CalledBy(Type = typeof(Extensions), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Extensions), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(IList`1<String>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
	[Calls(Type = typeof(JsonValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "set_Schema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "add_ValidationEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler) { }

}

