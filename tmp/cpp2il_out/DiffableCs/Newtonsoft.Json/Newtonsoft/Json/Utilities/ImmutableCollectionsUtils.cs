namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class ImmutableCollectionsUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__24_1; //Field offset: 0x8
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__25_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass24_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass25_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[Nullable(0)]
	public class ImmutableCollectionTypeInfo
	{
		[CompilerGenerated]
		private string <ContractTypeName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <CreatedTypeName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <BuilderTypeName>k__BackingField; //Field offset: 0x20

		public string BuilderTypeName
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string ContractTypeName
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string CreatedTypeName
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName) { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_BuilderTypeName() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_ContractTypeName() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_CreatedTypeName() { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_BuilderTypeName(string value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_ContractTypeName(string value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_CreatedTypeName(string value) { }

	}

	private const string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1"; //Field offset: 0x0
	private const string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary"; //Field offset: 0x0
	private const string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2"; //Field offset: 0x0
	private const string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary"; //Field offset: 0x0
	private const string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2"; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; //Field offset: 0x0
	private const string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1"; //Field offset: 0x0
	private const string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet"; //Field offset: 0x0
	private const string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1"; //Field offset: 0x0
	private const string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet"; //Field offset: 0x0
	private const string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2"; //Field offset: 0x0
	private const string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1"; //Field offset: 0x0
	private const string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1"; //Field offset: 0x0
	private const string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue"; //Field offset: 0x0
	private const string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1"; //Field offset: 0x0
	private const string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList"; //Field offset: 0x0
	private const string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1"; //Field offset: 0x0
	private const string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray"; //Field offset: 0x0
	private const string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1"; //Field offset: 0x0
	private const string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1"; //Field offset: 0x0
	private const string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1"; //Field offset: 0x0
	private const string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack"; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 56)]
	private static ImmutableCollectionsUtils() { }

	[CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(TypeExtensions), Member = "Assembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(Type), Member = "GetMethods", ReturnType = typeof(MethodInfo[]))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 16)]
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

	[CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(TypeExtensions), Member = "Assembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(Type), Member = "GetMethods", ReturnType = typeof(MethodInfo[]))]
	[Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 24)]
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

}

