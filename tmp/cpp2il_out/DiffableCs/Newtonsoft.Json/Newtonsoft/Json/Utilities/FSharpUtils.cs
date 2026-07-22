namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class FSharpUtils
{
	[CompilerGenerated]
	private sealed class <>c__55
	{
		[Nullable(0)]
		public static readonly <>c__55<TKey, TValue> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<KeyValuePair`2<TKey, TValue>, Tuple`2<TKey, TValue>> <>9__55_1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__55`2() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__55`2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal Tuple<TKey, TValue> <BuildMapCreator>b__55_1(KeyValuePair<TKey, TValue> kv) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 2})]
		public MethodCall<Object, Object> call; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 1})]
		public MethodCall<Object, Object> invoke; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass52_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal object <CreateFSharpFuncCall>b__0(object target, Object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public ObjectConstructor<Object> ctorDelegate; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass55_0`2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 21)]
		[DeduplicatedMethod]
		internal object <BuildMapCreator>b__0(Object[] args) { }

	}

	private static readonly object Lock; //Field offset: 0x0
	public const string FSharpSetTypeName = "FSharpSet`1"; //Field offset: 0x0
	public const string FSharpListTypeName = "FSharpList`1"; //Field offset: 0x0
	public const string FSharpMapTypeName = "FSharpMap`2"; //Field offset: 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; //Field offset: 0x8
	private MethodInfo _ofSeq; //Field offset: 0x10
	private Type _mapType; //Field offset: 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall<Object, Object> <IsUnion>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall<Object, Object> <GetUnionCases>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall<Object, Object> <PreComputeUnionTagReader>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall<Object, Object> <PreComputeUnionReader>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private MethodCall<Object, Object> <PreComputeUnionConstructor>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Func<Object, Object> <GetUnionCaseInfoDeclaringType>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Func<Object, Object> <GetUnionCaseInfoName>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Func<Object, Object> <GetUnionCaseInfoTag>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	private MethodCall<Object, Object> <GetUnionCaseInfoFields>k__BackingField; //Field offset: 0x68

	public private Assembly FSharpCoreAssembly
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private Func<Object, Object> GetUnionCaseInfoDeclaringType
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 2})]
	public private MethodCall<Object, Object> GetUnionCaseInfoFields
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private Func<Object, Object> GetUnionCaseInfoName
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private Func<Object, Object> GetUnionCaseInfoTag
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall<Object, Object> GetUnionCases
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public static FSharpUtils Instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall<Object, Object> IsUnion
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall<Object, Object> PreComputeUnionConstructor
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall<Object, Object> PreComputeUnionReader
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	public private MethodCall<Object, Object> PreComputeUnionTagReader
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static FSharpUtils() { }

	[CalledBy(Type = typeof(FSharpUtils), Member = "EnsureInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private FSharpUtils(Assembly fsharpCoreAssembly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public ObjectConstructor<Object> BuildMapCreator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private static MethodCall<Object, Object> CreateFSharpFuncCall(Type type, string methodName) { }

	[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public ObjectConstructor<Object> CreateMap(Type keyType, Type valueType) { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = "StoreFSharpListCreatorIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public ObjectConstructor<Object> CreateSeq(Type t) { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = "StoreFSharpListCreatorIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FSharpUtils), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Assembly get_FSharpCoreAssembly() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<Object, Object> get_GetUnionCaseInfoDeclaringType() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_GetUnionCaseInfoFields() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<Object, Object> get_GetUnionCaseInfoName() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<Object, Object> get_GetUnionCaseInfoTag() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_GetUnionCases() { }

	[CallerCount(Count = 0)]
	public static FSharpUtils get_Instance() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_IsUnion() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_PreComputeUnionConstructor() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_PreComputeUnionReader() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodCall<Object, Object> get_PreComputeUnionTagReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetUnionCaseInfoDeclaringType(Func<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetUnionCaseInfoFields(MethodCall<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetUnionCaseInfoName(Func<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetUnionCaseInfoTag(Func<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetUnionCases(MethodCall<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsUnion(MethodCall<Object, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PreComputeUnionConstructor(MethodCall<Object, Object> value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PreComputeUnionReader(MethodCall<Object, Object> value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PreComputeUnionTagReader(MethodCall<Object, Object> value) { }

}

