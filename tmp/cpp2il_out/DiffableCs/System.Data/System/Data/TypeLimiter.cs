namespace System.Data;

internal sealed class TypeLimiter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DataColumn, Type> <>9__10_0; //Field offset: 0x8
		public static Func<DataTable, IEnumerable`1<Type>> <>9__11_0; //Field offset: 0x10

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
		internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeLimiter), Member = "GetPreviouslyDeclaredDataTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
		internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

	}

	private sealed class Scope : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Type, Boolean> <>9__3_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Index), Member = "RemoveRef", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal bool <.ctor>b__3_0(Type type) { }

		}

		private static readonly HashSet<Type> s_allowedTypes; //Field offset: 0x0
		private HashSet<Type> m_allowedTypes; //Field offset: 0x10
		[Nullable(2)]
		private readonly Scope m_previousScope; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 44)]
		[CallsUnknownMethods(Count = 2)]
		private static Scope() { }

		[CalledBy(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(IDisposable))]
		[CalledBy(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(IDisposable))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal Scope(Scope previousScope, IEnumerable<Type> allowedTypes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public override void Dispose() { }

		[CalledBy(Type = typeof(TypeLimiter), Member = "EnsureTypeIsAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeLimiter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(AppDomain), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		public bool IsAllowedType(Type type) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		private static bool IsTypeUnconditionallyAllowed(Type type) { }

	}

	[Nullable(2)]
	[ThreadStatic]
	private static Scope s_activeScope; //Field offset: 0x80000000
	private Scope m_instanceScope; //Field offset: 0x10

	private static bool IsTypeLimitingDisabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		private get { } //Length: 98
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private TypeLimiter(Scope scope) { }

	[CalledBy(Type = typeof(FunctionNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public static TypeLimiter Capture() { }

	[CalledBy(Type = typeof(DataColumn), Member = "UpdateColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StorageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionNode), Member = "GetDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionNode)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(ObjectStorage), Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Scope), Member = "IsAllowedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TypeNotAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter = null) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CalledBy(Type = typeof(DataSet), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Scope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scope), typeof(System.Collections.Generic.IEnumerable`1<System.Type>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	[CalledBy(Type = typeof(DataTable), Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlReadMode), typeof(bool)}, ReturnType = typeof(XmlReadMode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeLimiter), Member = "GetPreviouslyDeclaredDataTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[Calls(Type = typeof(Scope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scope), typeof(System.Collections.Generic.IEnumerable`1<System.Type>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalAppContext), Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	private static bool get_IsTypeLimitingDisabled() { }

	[CalledBy(Type = typeof(<>c), Member = "<GetPreviouslyDeclaredDataTypes>b__11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[CalledBy(Type = typeof(TypeLimiter), Member = "EnterRestrictedScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(IDisposable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }

}

