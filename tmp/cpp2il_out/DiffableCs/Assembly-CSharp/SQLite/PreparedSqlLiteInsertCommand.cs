namespace SQLite;

internal class PreparedSqlLiteInsertCommand : IDisposable
{
	private static readonly IntPtr NullStatement; //Field offset: 0x0
	private bool Initialized; //Field offset: 0x10
	private SQLiteConnection Connection; //Field offset: 0x18
	private string CommandText; //Field offset: 0x20
	private IntPtr Statement; //Field offset: 0x28

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateInsertCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string)}, ReturnType = typeof(PreparedSqlLiteInsertCommand))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PreparedSqlLiteInsertCommand(SQLiteConnection conn, string commandText) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "GetInsertCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string)}, ReturnType = typeof(PreparedSqlLiteInsertCommand))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLite3), Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[Calls(Type = typeof(SQLite3), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public int ExecuteNonQuery(Object[] source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

}

