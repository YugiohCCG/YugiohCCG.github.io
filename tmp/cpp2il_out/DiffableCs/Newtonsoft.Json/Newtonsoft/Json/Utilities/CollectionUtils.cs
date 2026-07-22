namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class CollectionUtils
{
	[NullableContext(0)]
	private static class EmptyArrayContainer
	{
		[Nullable(1)]
		public static readonly T[] Empty; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		private static EmptyArrayContainer`1() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionUtils), Member = "ContainsValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static bool AddDistinct(IList<T> list, T value, IEqualityComparer<T> comparer) { }

	[CalledBy(Type = typeof(JsonSchemaModel), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionUtils), Member = "ContainsValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Extension]
	public static bool AddDistinct(IList<T> list, T value) { }

	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(Expression[]), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Reflection.MemberInfo>), typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver+<>c", Member = "<GetExtensionDataMemberForType>b__44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Reflection.MemberInfo>))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDynamicContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDynamicContract))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static void AddRange(IList<T> initial, IEnumerable<T> collection) { }

	[CalledBy(Type = typeof(JsonSchemaModel), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionUtils), Member = "ContainsValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static bool AddRangeDistinct(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer) { }

	[CallerCount(Count = 97)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static T[] ArrayEmpty() { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Contains(List<T> list, T value, IEqualityComparer comparer) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CollectionUtils), Member = "AddDistinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CollectionUtils), Member = "AddDistinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "T", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CollectionUtils), Member = "AddRangeDistinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsValue(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	[CalledBy(Type = typeof(CollectionUtils), Member = "CopyFromJaggedToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Array), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CollectionUtils), Member = "ToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionUtils), Member = "JaggedArrayGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Int32[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CollectionUtils), Member = "CopyFromJaggedToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Array), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, Int32[] indices) { }

	[CalledBy(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static void FastReverse(List<T> list) { }

	[CalledBy(Type = typeof(CollectionUtils), Member = "ToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private static IList<Int32> GetDimensions(IList values, int dimensionsCount) { }

	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Reflection.PropertyInfo>), typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(IEnumerable<T> collection, Func<T, Boolean> predicate) { }

	[CalledBy(Type = typeof(JArray), Member = "IndexOfItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JConstructor), Member = "IndexOfItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JObject), Member = "IndexOfItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "IndexOfReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfReference(List<T> list, T item) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsDictionaryType(Type type) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsNullOrEmpty(ICollection<T> collection) { }

	[CalledBy(Type = typeof(CollectionUtils), Member = "CopyFromJaggedToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Array), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static object JaggedArrayGetValue(IList values, Int32[] indices) { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionUtils), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32[])}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CollectionUtils), Member = "CopyFromJaggedToMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(Array), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

