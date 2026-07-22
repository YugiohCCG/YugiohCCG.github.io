namespace SQLite;

public class NotNullConstraintViolationException : SQLiteException
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public object obj; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <.ctor>b__0(Column c) { }

	}

	[CompilerGenerated]
	private IEnumerable<Column> <Columns>k__BackingField; //Field offset: 0x98

	public IEnumerable<Column> Columns
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(void))]
	protected NotNullConstraintViolationException(Result r, string message) { }

	[CalledBy(Type = typeof(NotNullConstraintViolationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[CalledBy(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[CalledBy(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteException), typeof(TableMapping), typeof(object)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected NotNullConstraintViolationException(Result r, string message, TableMapping mapping, object obj) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IEnumerable<Column> get_Columns() { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "ExecuteNonQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(void))]
	public static NotNullConstraintViolationException New(Result r, string message) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(void))]
	public static NotNullConstraintViolationException New(Result r, string message, TableMapping mapping, object obj) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_Columns(IEnumerable<Column> value) { }

}

