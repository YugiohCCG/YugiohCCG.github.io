namespace SQLite;

public class TableMapping
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Column, Boolean> <>9__31_0; //Field offset: 0x8

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
		[ContainsUnimplementedInstructions]
		internal bool <.ctor>b__31_0(Column c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public HashSet<String> propNames; //Field offset: 0x10
		public Func<PropertyInfo, Boolean> <>9__1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass31_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <.ctor>b__1(PropertyInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public string propertyName; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass41_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <FindColumnWithPropertyName>b__0(Column c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public string columnName; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass42_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <FindColumn>b__0(Column c) { }

	}

	internal class Column
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<CustomAttributeData, Boolean> <>9__45_0; //Field offset: 0x8
			public static Func<CustomAttributeData, Boolean> <>9__45_1; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <.ctor>b__45_0(CustomAttributeData x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <.ctor>b__45_1(CustomAttributeData x) { }

		}

		private PropertyInfo _prop; //Field offset: 0x10
		[CompilerGenerated]
		private string <Name>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Type <ColumnType>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <Collation>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private bool <IsAutoInc>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private bool <IsAutoGuid>k__BackingField; //Field offset: 0x31
		[CompilerGenerated]
		private bool <IsPK>k__BackingField; //Field offset: 0x32
		[CompilerGenerated]
		private IEnumerable<IndexedAttribute> <Indices>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private bool <IsNullable>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private Nullable<Int32> <MaxStringLength>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		private bool <StoreAsText>k__BackingField; //Field offset: 0x4C

		public private string Collation
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

		public private Type ColumnType
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

		public IEnumerable<IndexedAttribute> Indices
		{
			[CallerCount(Count = 38)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public private bool IsAutoGuid
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private bool IsAutoInc
		{
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private bool IsNullable
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private bool IsPK
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private Nullable<Int32> MaxStringLength
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private string Name
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public PropertyInfo PropertyInfo
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string PropertyName
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 39
		}

		public private bool StoreAsText
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CalledBy(Type = typeof(TableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
		[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
		[CallsDeduplicatedMethods(Count = 19)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		public Column(PropertyInfo prop, CreateFlags createFlags = 0) { }

		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_Collation() { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Type get_ColumnType() { }

		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public IEnumerable<IndexedAttribute> get_Indices() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_IsAutoGuid() { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_IsAutoInc() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_IsNullable() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_IsPK() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Nullable<Int32> get_MaxStringLength() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public PropertyInfo get_PropertyInfo() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public string get_PropertyName() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_StoreAsText() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public object GetValue(object obj) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Collation(string value) { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_ColumnType(Type value) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Indices(IEnumerable<IndexedAttribute> value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_IsAutoGuid(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_IsAutoInc(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_IsNullable(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_IsPK(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private void set_MaxStringLength(Nullable<Int32> value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Name(string value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_StoreAsText(bool value) { }

		[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TableMapping), Member = "SetAutoIncPK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
		[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(PropertyInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void SetValue(object obj, object val) { }

	}

	[CompilerGenerated]
	private Type <MappedType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <TableName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <WithoutRowId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Column[] <Columns>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Column <PK>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <GetByPrimaryKeySql>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private CreateFlags <CreateFlags>k__BackingField; //Field offset: 0x40
	private readonly Column _autoPk; //Field offset: 0x48
	private readonly Column[] _insertColumns; //Field offset: 0x50
	private readonly Column[] _insertOrReplaceColumns; //Field offset: 0x58
	[CompilerGenerated]
	private bool <HasAutoIncPK>k__BackingField; //Field offset: 0x60

	public private Column[] Columns
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

	public private CreateFlags CreateFlags
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private string GetByPrimaryKeySql
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

	public private bool HasAutoIncPK
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public Column[] InsertColumns
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Column[] InsertOrReplaceColumns
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private Type MappedType
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private Column PK
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

	public private string TableName
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private bool WithoutRowId
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Column), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(CreateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	public TableMapping(Type type, CreateFlags createFlags = 0) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Column FindColumn(string columnName) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, Object>>", typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TableQuery`1), Member = "AddOrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, U>>", typeof(bool)}, ReturnType = "SQLite.TableQuery`1<T>")]
	[CalledBy(Type = typeof(TableQuery`1), Member = "CompileExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<System.Object>)}, ReturnType = "SQLite.TableQuery`1<T>+CompileResult<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Column FindColumnWithPropertyName(string propertyName) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Column[] get_Columns() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CreateFlags get_CreateFlags() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_GetByPrimaryKeySql() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_HasAutoIncPK() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Column[] get_InsertColumns() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Column[] get_InsertOrReplaceColumns() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_MappedType() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Column get_PK() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_TableName() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_WithoutRowId() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Columns(Column[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CreateFlags(CreateFlags value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_GetByPrimaryKeySql(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_HasAutoIncPK(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_MappedType(Type value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PK(Column value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_TableName(string value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_WithoutRowId(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Column), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetAutoIncPK(object obj, long id) { }

}

