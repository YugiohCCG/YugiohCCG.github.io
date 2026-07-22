namespace Newtonsoft.Json.Utilities;

internal static class JsonTokenUtils
{

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "IsWriteTokenIncomplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonWriter), Member = "CalculateWriteTokenFinalDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static bool IsEndToken(JsonToken token) { }

	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool IsPrimitiveToken(JsonToken token) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonReader+<SkipAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonReader), Member = "get_Depth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "IsWriteTokenIncomplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonWriter), Member = "CalculateWriteTokenInitialDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal static bool IsStartToken(JsonToken token) { }

}

