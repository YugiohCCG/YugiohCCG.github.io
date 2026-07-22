namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class TypeExtensions
{

	[CalledBy(Type = typeof(ImmutableCollectionsUtils), Member = "TryBuildImmutableForArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&), typeof(ObjectConstructor`1<Object>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ImmutableCollectionsUtils), Member = "TryBuildImmutableForDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type), typeof(Type&), typeof(ObjectConstructor`1<Object>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Assembly Assembly(Type type) { }

	[CalledBy(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(Type&)}, ReturnType = typeof(bool))]
	[Extension]
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(Expression[]), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinitionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Reflection.FieldInfo>))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Reflection.MemberInfo>), typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Reflection.PropertyInfo>), typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DataContractAttribute))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(DataMemberAttribute))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(MemberSerialization))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Type BaseType(Type type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool ContainsGenericParameters(Type type) { }

	[CalledBy(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static bool ImplementInterface(Type type, Type interfaceType) { }

	[CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = typeof(ConvertResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsAbstract(Type type) { }

	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsClass(Type type) { }

	[CalledBy(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Boolean&)}, ReturnType = typeof(PrimitiveTypeCode))]
	[CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = typeof(ConvertResult))]
	[CalledBy(Type = typeof(EnumUtils), Member = "ParseEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NamingStrategy), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsEnum(Type type) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ImmutableCollectionsUtils+<>c", Member = "<TryBuildImmutableForDictionaryContract>b__25_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ImmutableCollectionsUtils), Member = "TryBuildImmutableForArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&), typeof(ObjectConstructor`1<Object>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ImmutableCollectionsUtils), Member = "TryBuildImmutableForDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type), typeof(Type&), typeof(ObjectConstructor`1<Object>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinitionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsOverridenGenericMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsGenericType(Type type) { }

	[CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = typeof(ConvertResult))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetCollectionItemType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetDictionaryKeyValueTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type&), typeof(Type&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsGenericTypeDefinition(Type type) { }

	[CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = typeof(ConvertResult))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsInterface(Type type) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static bool IsPrimitive(Type type) { }

	[CalledBy(Type = typeof(JsonSchemaGenerator), Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonObjectContract)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsSealed(Type type) { }

	[CalledBy(Type = typeof(CollectionWrapper`1), Member = "IsCompatibleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c", Member = "<GetArgs>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "GetArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject[]), typeof(DynamicMetaObject)}, ReturnType = typeof(Expression[]))]
	[CalledBy(Type = typeof(LateBoundReflectionDelegateFactory), Member = "CreateDefaultConstructor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.Func`1<T>")]
	[CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsByRefLikeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsValueType(Type type) { }

	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicProxyMetaObject`1), Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), typeof(Expression[]), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsVisible(Type type) { }

	[CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), typeof(String[])}, ReturnType = typeof(ReflectionObject))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsOverridenGenericMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberInfo)}, ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(DataMemberAttribute))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static MethodInfo Method(Delegate d) { }

}

