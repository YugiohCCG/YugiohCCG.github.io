namespace Unity.Properties.Internal;

internal class ReflectedPropertyBagProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MethodInfo, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<MemberInfo, Int32> <>9__22_0; //Field offset: 0x10

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
		internal bool <.ctor>b__10_0(MethodInfo x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MemberInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Type type; //Field offset: 0x28
		public Type <>3__type; //Field offset: 0x30
		private IOrderedEnumerable<MemberInfo> <members>5__1; //Field offset: 0x38
		private IEnumerator<MemberInfo> <>s__2; //Field offset: 0x40
		private MemberInfo <member>5__3; //Field offset: 0x48
		private bool <hasDontCreatePropertyAttribute>5__4; //Field offset: 0x50
		private bool <hasCreatePropertyAttribute>5__5; //Field offset: 0x51
		private bool <hasNonSerializedAttribute>5__6; //Field offset: 0x52
		private bool <hasSerializedFieldAttribute>5__7; //Field offset: 0x53
		private bool <hasSerializeReferenceAttribute>5__8; //Field offset: 0x54
		private FieldInfo <field>5__9; //Field offset: 0x58

		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetPropertyMembers>d__22(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
		[Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 29)]
		[ContainsUnimplementedInstructions]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = "UnityEngine.Rigidbody", Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly MethodInfo m_CreatePropertyMethod; //Field offset: 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; //Field offset: 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; //Field offset: 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; //Field offset: 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; //Field offset: 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; //Field offset: 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; //Field offset: 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; //Field offset: 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; //Field offset: 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; //Field offset: 0x58

	[CalledBy(Type = typeof(PropertiesInitialization), Member = "InitializeProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBagStore), Member = "get_ReflectedPropertyBagProvider", ReturnType = typeof(ReflectedPropertyBagProvider))]
	[CalledBy(Type = typeof(PropertyBagStore), Member = "CreatePropertyBagProvider", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public ReflectedPropertyBagProvider() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<Dictionary`2<TKey, TValue>> CreateDictionaryPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<HashSet`1<TElement>> CreateHashSetPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<KeyValuePair`2<TKey, TValue>> CreateKeyValuePairPropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<List`1<TElement>> CreateListPropertyBag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Preserve]
	private void CreateProperty(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public IPropertyBag CreatePropertyBag(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = "GetPropertyMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Reflection.MemberInfo>))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 47)]
	[CallsUnknownMethods(Count = 128)]
	[DeduplicatedMethod]
	public IPropertyBag<TContainer> CreatePropertyBag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Preserve]
	private IPropertyBag<TSet> CreateSetPropertyBag() { }

	[CalledBy(Type = typeof(ReflectedPropertyBagProvider), Member = "CreatePropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = "Unity.Properties.IPropertyBag`1<TContainer>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<GetPropertyMembers>d__22))]
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	[CalledBy(Type = typeof(<GetPropertyMembers>d__22), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = "IsValidPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static bool IsValidMember(MemberInfo memberInfo) { }

	[CalledBy(Type = typeof(ReflectedPropertyBagProvider), Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "All", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsValidPropertyType(Type type) { }

}

