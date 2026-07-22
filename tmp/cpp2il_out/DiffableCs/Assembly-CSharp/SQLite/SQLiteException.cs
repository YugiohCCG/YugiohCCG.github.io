namespace SQLite;

public class SQLiteException : Exception
{
	[CompilerGenerated]
	private Result <Result>k__BackingField; //Field offset: 0x90

	public private Result Result
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected SQLiteException(Result r, string message) { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Result get_Result() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "EnableLoadExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>)}, ReturnType = typeof(SQLiteCommand))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "ExecuteNonQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLite3), Member = "Prepare2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static SQLiteException New(Result r, string message) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Result(Result value) { }

}

