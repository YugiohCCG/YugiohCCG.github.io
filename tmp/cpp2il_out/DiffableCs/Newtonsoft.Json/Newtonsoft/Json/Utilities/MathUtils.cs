namespace Newtonsoft.Json.Utilities;

internal static class MathUtils
{

	[CalledBy(Type = typeof(JValue), Member = "CompareFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ApproxEquals(double d1, double d2) { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int IntLength(ulong i) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public static char IntToHex(int n) { }

	[CalledBy(Type = typeof(JsonSchemaModel), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Nullable<Int32> Max(Nullable<Int32> val1, Nullable<Int32> val2) { }

	[CalledBy(Type = typeof(JsonSchemaModel), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static Nullable<Double> Max(Nullable<Double> val1, Nullable<Double> val2) { }

	[CalledBy(Type = typeof(JsonSchemaModel), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Nullable<Int32> Min(Nullable<Int32> val1, Nullable<Int32> val2) { }

}

