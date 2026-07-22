namespace SQLite;

public static class SQLite3
{
	internal enum ColType
	{
		Integer = 1,
		Float = 2,
		Text = 3,
		Blob = 4,
		Null = 5,
	}

	internal enum ConfigOption
	{
		SingleThread = 1,
		MultiThread = 2,
		Serialized = 3,
	}

	internal enum ExtendedResult
	{
		IOErrorRead = 266,
		IOErrorShortRead = 522,
		IOErrorWrite = 778,
		IOErrorFsync = 1034,
		IOErrorDirFSync = 1290,
		IOErrorTruncate = 1546,
		IOErrorFStat = 1802,
		IOErrorUnlock = 2058,
		IOErrorRdlock = 2314,
		IOErrorDelete = 2570,
		IOErrorBlocked = 2826,
		IOErrorNoMem = 3082,
		IOErrorAccess = 3338,
		IOErrorCheckReservedLock = 3594,
		IOErrorLock = 3850,
		IOErrorClose = 4106,
		IOErrorDirClose = 4362,
		IOErrorSHMOpen = 4618,
		IOErrorSHMSize = 4874,
		IOErrorSHMLock = 5130,
		IOErrorSHMMap = 5386,
		IOErrorSeek = 5642,
		IOErrorDeleteNoEnt = 5898,
		IOErrorMMap = 6154,
		LockedSharedcache = 262,
		BusyRecovery = 261,
		CannottOpenNoTempDir = 270,
		CannotOpenIsDir = 526,
		CannotOpenFullPath = 782,
		CorruptVTab = 267,
		ReadonlyRecovery = 264,
		ReadonlyCannotLock = 520,
		ReadonlyRollback = 776,
		AbortRollback = 516,
		ConstraintCheck = 275,
		ConstraintCommitHook = 531,
		ConstraintForeignKey = 787,
		ConstraintFunction = 1043,
		ConstraintNotNull = 1299,
		ConstraintPrimaryKey = 1555,
		ConstraintTrigger = 1811,
		ConstraintUnique = 2067,
		ConstraintVTab = 2323,
		NoticeRecoverWAL = 283,
		NoticeRecoverRollback = 539,
	}

	internal enum Result
	{
		OK = 0,
		Error = 1,
		Internal = 2,
		Perm = 3,
		Abort = 4,
		Busy = 5,
		Locked = 6,
		NoMem = 7,
		ReadOnly = 8,
		Interrupt = 9,
		IOError = 10,
		Corrupt = 11,
		NotFound = 12,
		Full = 13,
		CannotOpen = 14,
		LockErr = 15,
		Empty = 16,
		SchemaChngd = 17,
		TooBig = 18,
		Constraint = 19,
		Mismatch = 20,
		Misuse = 21,
		NotImplementedLFS = 22,
		AccessDenied = 23,
		Format = 24,
		Range = 25,
		NonDBFile = 26,
		Notice = 27,
		Warning = 28,
		Row = 100,
		Done = 101,
	}

	private const string LibraryPath = "__Internal"; //Field offset: 0x0

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Result BackupFinish(IntPtr backup) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static IntPtr BackupInit(IntPtr destDb, string destName, IntPtr sourceDb, string sourceName) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Result BackupStep(IntPtr backup, int numPages) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindBlob(IntPtr stmt, int index, Byte[] val, int n, IntPtr free) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindDouble(IntPtr stmt, int index, double val) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindInt(IntPtr stmt, int index, int val) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindInt64(IntPtr stmt, int index, long val) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindNull(IntPtr stmt, int index) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int BindParameterIndex(IntPtr stmt, string name) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int BindText(IntPtr stmt, int index, string val, int n, IntPtr free) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "set_BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static Result BusyTimeout(IntPtr db, int milliseconds) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int Changes(IntPtr db) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Close(IntPtr db) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Close2(IntPtr db) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr ColumnBlob(IntPtr stmt, int index) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(ColType), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_17", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] ColumnByteArray(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int ColumnBytes(IntPtr stmt, int index) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteQueryScalars>d__14`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int ColumnCount(IntPtr stmt) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(ColType), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static double ColumnDouble(IntPtr stmt, int index) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(ColType), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	public static int ColumnInt(IntPtr stmt, int index) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(ColType), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public static long ColumnInt64(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr ColumnName(IntPtr stmt, int index) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string ColumnName16(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr ColumnName16Internal(IntPtr stmt, int index) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(ColType), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_18", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_19", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_20", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_21", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(UriBuilder))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__DisplayClass0_0`1", Member = "<GetFastSetter>b__8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string ColumnString(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr ColumnText(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr ColumnText16(IntPtr stmt, int index) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteQueryScalars>d__14`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__DisplayClass1_0`2", Member = "<CreateNullableTypedSetterDelegate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__DisplayClass2_0`2", Member = "<CreateTypedSetterDelegate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static ColType ColumnType(IntPtr stmt, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Config(ConfigOption option) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "EnableLoadExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Result EnableLoadExtension(IntPtr db, int onoff) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr Errmsg(IntPtr db) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static ExtendedResult ExtendedErrCode(IntPtr db) { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "<>m__Finally1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "Finalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Finalize(IntPtr stmt) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "EnableLoadExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "ExecuteNonQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLite3), Member = "Prepare2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetErrmsg(IntPtr db) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Result GetResult(IntPtr db) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Initialize() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static long LastInsertRowid(IntPtr db) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int LibVersionNumber() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Result Open(Byte[] filename, out IntPtr db, int flags, string zvfs) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Result Open(string filename, out IntPtr db) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public static Result Open(string filename, out IntPtr db, int flags, string zvfs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Open16(string filename, out IntPtr db) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail) { }

	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "Prepare", ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(SQLite3), Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static IntPtr Prepare2(IntPtr db, string query) { }

	[CalledBy(Type = typeof(PreparedSqlLiteInsertCommand), Member = "ExecuteNonQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Reset(IntPtr stmt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Shutdown() { }

	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteDeferredQuery>d__12`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "SQLite.SQLiteCommand+<ExecuteQueryScalars>d__14`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static Result Step(IntPtr stmt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int Threadsafe() { }

}

