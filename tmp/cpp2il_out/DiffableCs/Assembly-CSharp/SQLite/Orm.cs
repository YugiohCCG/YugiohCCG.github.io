namespace SQLite;

public static class Orm
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CustomAttributeData, Boolean> <>9__6_0; //Field offset: 0x8
		public static Func<CustomAttributeData, Boolean> <>9__8_0; //Field offset: 0x10
		public static Func<CustomAttributeData, Boolean> <>9__14_0; //Field offset: 0x18

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
		internal bool <IsAutoInc>b__8_0(CustomAttributeData x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <IsMarkedNotNull>b__14_0(CustomAttributeData x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <IsPK>b__6_0(CustomAttributeData x) { }

	}

	public const int DefaultMaxStringLength = 140; //Field offset: 0x0
	public const string ImplicitPkName = "Id"; //Field offset: 0x0
	public const string ImplicitIndexSuffix = "Id"; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	public static string Collation(MemberInfo p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static FieldInfo GetField(TypeInfo t, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static PropertyInfo GetProperty(TypeInfo t, string name) { }

	[CalledBy(Type = "SQLite.SQLiteConnection+<>c__DisplayClass114_0", Member = "<InsertAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "UpdateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteConnection+<>c__DisplayClass128_0", Member = "<UpdateAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnection+<>c__DisplayClass115_0", Member = "<InsertAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Type GetType(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static object InflateAttribute(CustomAttributeData x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsAutoInc(MemberInfo p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsMarkedNotNull(MemberInfo p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPK(MemberInfo p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Nullable<Int32> MaxStringLength(PropertyInfo p) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "MigrateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "<CreateTable>b__70_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Orm), Member = "SqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public static string SqlDecl(Column p, bool storeDateTimeAsTicks, bool storeTimeSpanAsTicks) { }

	[CalledBy(Type = typeof(Orm), Member = "SqlDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(IntrospectionExtensions), Member = "GetTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInfo))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 8)]
	public static string SqlType(Column p, bool storeDateTimeAsTicks, bool storeTimeSpanAsTicks) { }

}

