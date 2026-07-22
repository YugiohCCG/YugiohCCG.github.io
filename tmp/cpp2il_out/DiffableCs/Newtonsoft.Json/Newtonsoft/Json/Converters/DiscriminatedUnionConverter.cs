namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class DiscriminatedUnionConverter : JsonConverter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int tag; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass8_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal bool <WriteJson>b__0(UnionCase c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public string caseName; //Field offset: 0x10
		[Nullable(0)]
		public Func<UnionCase, Boolean> <>9__0; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass9_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal bool <ReadJson>b__0(UnionCase c) { }

	}

	[Nullable(0)]
	public class Union
	{
		public readonly FSharpFunction TagReader; //Field offset: 0x10
		public readonly List<UnionCase> Cases; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public Union(FSharpFunction tagReader, List<UnionCase> cases) { }

	}

	[Nullable(0)]
	public class UnionCase
	{
		public readonly int Tag; //Field offset: 0x10
		public readonly string Name; //Field offset: 0x18
		public readonly PropertyInfo[] Fields; //Field offset: 0x20
		public readonly FSharpFunction FieldReader; //Field offset: 0x28
		public readonly FSharpFunction Constructor; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

	}

	private const string CasePropertyName = "Case"; //Field offset: 0x0
	private const string FieldsPropertyName = "Fields"; //Field offset: 0x0
	private static readonly ThreadSafeStore<Type, Union> UnionCache; //Field offset: 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static DiscriminatedUnionConverter() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DiscriminatedUnionConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "Assembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(FSharpUtils), Member = "EnsureInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public virtual bool CanConvert(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 37)]
	private static Union CreateUnion(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static Type CreateUnionTypeLookup(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FSharpFunction), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 46)]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FSharpFunction), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "Single", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetResolvedPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 15)]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

