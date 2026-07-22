namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class DefaultContractResolver : IContractResolver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__40_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__40_1; //Field offset: 0x10
		[Nullable(0)]
		public static Func<Type, IEnumerable`1<MemberInfo>> <>9__44_0; //Field offset: 0x18
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__44_1; //Field offset: 0x20
		[Nullable(0)]
		public static Func<ConstructorInfo, Boolean> <>9__47_0; //Field offset: 0x28
		[Nullable(0)]
		public static Func<JsonProperty, Int32> <>9__75_0; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(0)]
		internal int <CreateProperties>b__75_0(JsonProperty p) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(0)]
		internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(0)]
		internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 26)]
		[NullableContext(0)]
		internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionUtils), Member = "IsIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[NullableContext(0)]
		internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(0)]
		internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass42_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <CreateObjectContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public Func<Object, Object> getExtensionDataDictionary; //Field offset: 0x10
		[Nullable(0)]
		public MemberInfo member; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass45_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_1
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public Action<Object, Object> setExtensionDataDictionary; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func<Object> createExtensionDataDictionary; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public MethodCall<Object, Object> setExtensionDataDictionaryValue; //Field offset: 0x20
		[Nullable(0)]
		public <>c__DisplayClass45_0 CS$<>8__locals1; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass45_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 20)]
		internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_2
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public ObjectConstructor<Object> createEnumerableWrapper; //Field offset: 0x10
		[Nullable(0)]
		public <>c__DisplayClass45_0 CS$<>8__locals2; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass45_2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		internal IEnumerable<KeyValuePair`2<Object, Object>> <SetExtensionDataDelegates>b__1(object o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass62_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <CreateDictionaryContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass67_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <CreateDynamicContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public MethodCall<Object, Object> shouldSerializeCall; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass80_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal bool <CreateShouldSerializeTest>b__0(object o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Func<Object, Object> specifiedPropertyGet; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass81_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool <SetIsSpecifiedActions>b__0(object o) { }

	}

	[NullableContext(0)]
	public class EnumerableDictionaryWrapper : IEnumerable<KeyValuePair`2<Object, Object>>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__2 : IEnumerator<KeyValuePair`2<Object, Object>>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
			private KeyValuePair<Object, Object> <>2__current; //Field offset: 0x0
			public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this; //Field offset: 0x0
			[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 1})]
			private IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1; //Field offset: 0x0

			private override KeyValuePair<Object, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 69
			}

			[CallerCount(Count = 36)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetEnumerator>d__2(int <>1__state) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private void <>m__Finally1() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 20)]
			[DeduplicatedMethod]
			private override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override KeyValuePair<Object, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1})]
		private readonly IEnumerable<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> _e; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public EnumerableDictionaryWrapper`2(IEnumerable<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> e) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IteratorStateMachine(typeof(<GetEnumerator>d__2))]
		public override IEnumerator<KeyValuePair`2<Object, Object>> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private static readonly IContractResolver _instance; //Field offset: 0x0
	private static readonly String[] BlacklistedTypeNames; //Field offset: 0x8
	private static readonly JsonConverter[] BuiltInConverters; //Field offset: 0x10
	private readonly DefaultJsonNameTable _nameTable; //Field offset: 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; //Field offset: 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(2)]
	private NamingStrategy <NamingStrategy>k__BackingField; //Field offset: 0x30

	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool DynamicCodeGeneration
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTypeReflector), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
		 get { } //Length: 64
	}

	public bool IgnoreIsSpecifiedMembers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IgnoreSerializableAttribute
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IgnoreSerializableInterface
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IgnoreShouldSerializeMembers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal static IContractResolver Instance
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	[Nullable(2)]
	public NamingStrategy NamingStrategy
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public bool SerializeCompilerGeneratedMembers
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 48)]
	private static DefaultContractResolver() { }

	[CalledBy(Type = typeof(CamelCasePropertyNamesContractResolver), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DefaultJsonNameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public DefaultContractResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "CanTypeDescriptorConvertString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeConverter&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool CanConvertToString(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	protected override JsonArrayContract CreateArrayContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonProperty))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	protected override IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "EnsureNotByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(ReflectionUtils), Member = "EnsureNotNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CollectionUtils), Member = "IsDictionaryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "CanTypeDescriptorConvertString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeConverter&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "IsSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 1)]
	protected override JsonContract CreateContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetContainerNamingStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerAttribute)}, ReturnType = typeof(NamingStrategy))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 24)]
	protected override JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetContainerNamingStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerAttribute)}, ReturnType = typeof(NamingStrategy))]
	[Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	protected override JsonDynamicContract CreateDynamicContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	protected override JsonISerializableContract CreateISerializableContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	protected override JsonLinqContract CreateLinqContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionValueProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(void))]
	protected override IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback>))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(MemberInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Type>))]
	[Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetImmutableConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonPropertyCollection)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetContainerNamingStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerAttribute)}, ReturnType = typeof(NamingStrategy))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(MemberSerialization))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 9)]
	protected override JsonObjectContract CreateObjectContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected override JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultJsonNameTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionAttributeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "CreateShouldSerializeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Predicate`1<System.Object>))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionAttributeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(object), typeof(string), typeof(Type), typeof(MemberSerialization), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	protected override JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberSerialization)}, ReturnType = typeof(JsonProperty))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private Predicate<Object> CreateShouldSerializeTest(MemberInfo member) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonStringContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	protected override JsonStringContract CreateStringContract(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsByRefLikeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool FilterMembers(MemberInfo member) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
	public bool get_DynamicCodeGeneration() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IgnoreSerializableAttribute() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IgnoreSerializableInterface() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IgnoreShouldSerializeMembers() { }

	[CallerCount(Count = 0)]
	internal static IContractResolver get_Instance() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public NamingStrategy get_NamingStrategy() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDictionaryContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonArrayContract))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Type>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "IsConcurrentOrObservableCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(Type), typeof(MethodInfo), typeof(Type&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(SerializationCallback))]
	[Calls(Type = typeof(JsonContract), Member = "CreateSerializationErrorCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(SerializationErrorCallback))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 28)]
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback>& onSerializing, out List<SerializationCallback>& onSerialized, out List<SerializationCallback>& onDeserializing, out List<SerializationCallback>& onDeserialized, out List<SerializationErrorCallback>& onError) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetExtensionDataMemberForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private List<Type> GetClassHierarchyForType(Type type) { }

	[CalledBy(Type = typeof(<>c), Member = "<GetExtensionDataMemberForType>b__44_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(Type), typeof(MethodInfo), typeof(Type&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetClrTypeFullName(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Func<Object> GetDefaultCreator(Type createdType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Type>))]
	[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetConstructors", ReturnType = typeof(ConstructorInfo[]))]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JsonProperty))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal override DefaultJsonNameTable GetNameTable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	[CalledBy(Type = typeof(DataSetConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Regex), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetResolvedPropertyName(string propertyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(MemberSerialization))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetFieldsAndProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MemberInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DataContractAttribute))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 30)]
	protected override List<MemberInfo> GetSerializableMembers(Type objectType) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDictionaryContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonArrayContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePrimitiveContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonPrimitiveContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateLinqContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonLinqContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateISerializableContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonISerializableContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDynamicContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonDynamicContract))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateStringContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonStringContract))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>), typeof(Type)}, ReturnType = typeof(JsonConverter))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DataContractAttribute))]
	[Calls(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void InitializeContract(JsonContract contract) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ShouldSkipDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "ShouldSkipSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsIConvertible(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[ContainsUnimplementedInstructions]
	internal static bool IsJsonPrimitiveType(Type t) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 68)]
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonPropertyCollection), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JsonProperty))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationCallback>&), typeof(List`1<SerializationErrorCallback>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationCallback>))]
	[Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Serialization.SerializationErrorCallback>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Object, System.Object>), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override JsonContract ResolveContract(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JsonConverter))]
	protected override JsonConverter ResolveContractConverter(Type objectType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override string ResolveDictionaryKey(string dictionaryKey) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override string ResolveExtensionDataName(string extensionDataName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override string ResolvePropertyName(string propertyName) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IgnoreIsSpecifiedMembers(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IgnoreSerializableInterface(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IgnoreShouldSerializeMembers(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public void set_NamingStrategy(NamingStrategy value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SerializeCompilerGeneratedMembers(bool value) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonObjectContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsGenericDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Func`2<T, Object>")]
	[Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Action`2<T, Object>")]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetConstructors", ReturnType = typeof(ConstructorInfo[]))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberSerialization)}, ReturnType = typeof(JsonProperty))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Func`2<T, Object>")]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateSet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Action`2<T, Object>")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(ParameterInfo)}, ReturnType = typeof(JsonProperty))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberSerialization)}, ReturnType = typeof(JsonProperty))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DataContractAttribute))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(DataMemberAttribute))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetContainerNamingStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerAttribute)}, ReturnType = typeof(NamingStrategy))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "CreateNamingStrategyInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(NamingStrategy))]
	[Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "CreateJsonConverterInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(JsonConverter))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "IsNonSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JsonConverter))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "IsConcurrentOrObservableCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldSkipDeserialized(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultContractResolver), Member = "IsConcurrentOrObservableCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldSkipSerializing(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

}

