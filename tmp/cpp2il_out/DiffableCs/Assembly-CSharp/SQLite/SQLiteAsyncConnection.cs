namespace SQLite;

public class SQLiteAsyncConnection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SQLiteConnectionWithLock, Object> <>9__12_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "EnableWriteAheadLogging", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal object <EnableWriteAheadLoggingAsync>b__12_0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__43
	{
		public static readonly <>c__43<T> <>9; //Field offset: 0x0
		public static Func<SQLiteConnectionWithLock, Int32> <>9__43_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__43`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__43`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <DropTableAsync>b__43_0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__62
	{
		public static readonly <>c__62<T> <>9; //Field offset: 0x0
		public static Func<SQLiteConnectionWithLock, Int32> <>9__62_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__62`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__62`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <DeleteAllAsync>b__62_0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TimeSpan value; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass11_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "set_BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal object <SetBusyTimeoutAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public SQLiteAsyncConnection <>4__this; //Field offset: 0x0
		public Func<SQLiteConnectionWithLock, T> read; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass32_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[Calls(Type = typeof(SQLiteConnectionWithLock), Member = "Lock", ReturnType = typeof(IDisposable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal T <ReadAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public SQLiteAsyncConnection <>4__this; //Field offset: 0x0
		public Func<SQLiteConnectionWithLock, T> write; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass33_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[Calls(Type = typeof(SQLiteConnectionWithLock), Member = "Lock", ReturnType = typeof(IDisposable))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal T <WriteAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public SQLiteAsyncConnection <>4__this; //Field offset: 0x0
		public Func<SQLiteConnectionWithLock, T> transact; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass34_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnectionAndTransactionLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(SQLiteConnectionWithLock))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLiteConnectionWithLock), Member = "Lock", ReturnType = typeof(IDisposable))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		internal T <TransactAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public bool enabled; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass35_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "EnableLoadExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal object <EnableLoadExtensionAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public CreateFlags createFlags; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass36_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal CreateTableResult <CreateTableAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public Type ty; //Field offset: 0x10
		public CreateFlags createFlags; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass37_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
		[CallsUnknownMethods(Count = 1)]
		internal CreateTableResult <CreateTableAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public CreateFlags createFlags; //Field offset: 0x10
		public Type[] types; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass42_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
		[CallsUnknownMethods(Count = 1)]
		internal CreateTablesResult <CreateTablesAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public TableMapping map; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass44_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "DropTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <DropTableAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public string tableName; //Field offset: 0x10
		public string columnName; //Field offset: 0x18
		public bool unique; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass45_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <CreateIndexAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public string indexName; //Field offset: 0x10
		public string tableName; //Field offset: 0x18
		public string columnName; //Field offset: 0x20
		public bool unique; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass46_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <CreateIndexAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string tableName; //Field offset: 0x10
		public String[] columnNames; //Field offset: 0x18
		public bool unique; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass47_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <CreateIndexAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public string indexName; //Field offset: 0x10
		public string tableName; //Field offset: 0x18
		public String[] columnNames; //Field offset: 0x20
		public bool unique; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass48_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <CreateIndexAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Expression<Func`2<T, Object>> property; //Field offset: 0x0
		public bool unique; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass49_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <CreateIndexAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public object obj; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass50_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public object obj; //Field offset: 0x10
		public Type objType; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass51_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public object obj; //Field offset: 0x10
		public string extra; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass52_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public object obj; //Field offset: 0x10
		public string extra; //Field offset: 0x18
		public Type objType; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass53_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public object obj; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass54_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "InsertOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertOrReplaceAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public object obj; //Field offset: 0x10
		public Type objType; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass55_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "InsertOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertOrReplaceAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public object obj; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass56_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <UpdateAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public object obj; //Field offset: 0x10
		public Type objType; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass57_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <UpdateAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public bool runInTransaction; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass58_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "UpdateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <UpdateAllAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public object objectToDelete; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass59_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <DeleteAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public object primaryKey; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass60_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <DeleteAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public object primaryKey; //Field offset: 0x10
		public TableMapping map; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass61_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <DeleteAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public TableMapping map; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass63_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <DeleteAllAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public string destinationDatabasePath; //Field offset: 0x10
		public string databaseName; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass64_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Backup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal int <BackupAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public object pk; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass65_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <GetAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public object pk; //Field offset: 0x10
		public TableMapping map; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass66_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal object <GetAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public Expression<Func`2<T, Boolean>> predicate; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass67_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <GetAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public object pk; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass68_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <FindAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public object pk; //Field offset: 0x10
		public TableMapping map; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass69_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal object <FindAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public Expression<Func`2<T, Boolean>> predicate; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass70_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <FindAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public string query; //Field offset: 0x0
		public Object[] args; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass71_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <FindWithQueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public TableMapping map; //Field offset: 0x10
		public string query; //Field offset: 0x18
		public Object[] args; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass72_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "FindWithQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal object <FindWithQueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public Type type; //Field offset: 0x10
		public CreateFlags createFlags; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass73_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
		[CallsUnknownMethods(Count = 1)]
		internal TableMapping <GetMappingAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public CreateFlags createFlags; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass74_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TableMapping <GetMappingAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public string tableName; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass75_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "GetTableInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>))]
		[CallsUnknownMethods(Count = 1)]
		internal List<ColumnInfo> <GetTableInfoAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public string query; //Field offset: 0x10
		public Object[] args; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <ExecuteAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public bool runInTransaction; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass77_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAllAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public string extra; //Field offset: 0x18
		public bool runInTransaction; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass78_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAllAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public Type objType; //Field offset: 0x18
		public bool runInTransaction; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass79_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <InsertAllAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public Action<SQLiteConnection> action; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass80_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "BeginTransaction", ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLiteConnection), Member = "Commit", ReturnType = typeof(void))]
		[Calls(Type = typeof(SQLiteConnection), Member = "Rollback", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal object <RunInTransactionAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public string query; //Field offset: 0x0
		public Object[] args; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass82_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <ExecuteScalarAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public string query; //Field offset: 0x0
		public Object[] args; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass83_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal List<T> <QueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0
	{
		public string query; //Field offset: 0x0
		public Object[] args; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass84_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal List<T> <QueryScalarsAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public TableMapping map; //Field offset: 0x10
		public string query; //Field offset: 0x18
		public Object[] args; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass85_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Query", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[CallsUnknownMethods(Count = 1)]
		internal List<Object> <QueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public string query; //Field offset: 0x0
		public Object[] args; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass86_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal IEnumerable<T> <DeferredQueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public TableMapping map; //Field offset: 0x10
		public string query; //Field offset: 0x18
		public Object[] args; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass87_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "DeferredQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[CallsUnknownMethods(Count = 1)]
		internal IEnumerable<Object> <DeferredQueryAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	private readonly SQLiteConnectionString _connectionString; //Field offset: 0x10

	public string DatabasePath
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public string DateTimeStringFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public int LibVersionNumber
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public bool StoreDateTimeAsTicks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public bool StoreTimeSpanAsTicks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public IEnumerable<TableMapping> TableMappings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[Calls(Type = typeof(SQLiteConnection), Member = "get_TableMappings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SQLite.TableMapping>))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 35
	}

	public bool TimeExecution
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 35
	}

	public bool Trace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 35
	}

	public Action<String> Tracer
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 47
	}

	[CalledBy(Type = "Card.Manager+<DBHasRuleCode>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<SQLiteReaderExecution>d__34`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SQLiteAsyncConnection(string databasePath, bool storeDateTimeAsTicks = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SQLiteAsyncConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true) { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public SQLiteAsyncConnection(SQLiteConnectionString connectionString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionPool), Member = "CloseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <CloseAsync>b__31_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task BackupAsync(string destinationDatabasePath, string databaseName = "main") { }

	[CalledBy(Type = "Card.Manager+<DBHasRuleCode>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<LoadMainDatabase>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<SQLiteReaderExecution>d__34`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Task CloseAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Task<Int32> CreateIndexAsync(Expression<Func`2<T, Object>> property, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> CreateIndexAsync(string tableName, string columnName, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Task<Int32> CreateIndexAsync(string indexName, string tableName, String[] columnNames, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Task<Int32> CreateIndexAsync(string indexName, string tableName, string columnName, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> CreateIndexAsync(string tableName, String[] columnNames, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<SQLite.SQLiteConnectionWithLock, System.Int32Enum>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32Enum>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<CreateTableResult> CreateTableAsync(Type ty, CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<SQLite.SQLiteConnectionWithLock, System.Int32Enum>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32Enum>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Task<CreateTableResult> CreateTableAsync(CreateFlags createFlags = 0) { }

	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3", "T4", "T5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = 0, Type[] types) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "CreateTablesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<SQLite.CreateTablesResult>))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public Task<CreateTablesResult> CreateTablesAsync(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Task<IEnumerable`1<T>> DeferredQueryAsync(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public Task<IEnumerable`1<Object>> DeferredQueryAsync(TableMapping map, string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> DeleteAllAsync(TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public Task<Int32> DeleteAllAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> DeleteAsync(object objectToDelete) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Task<Int32> DeleteAsync(object primaryKey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> DeleteAsync(object primaryKey, TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public Task<Int32> DropTableAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> DropTableAsync(TableMapping map) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Task EnableLoadExtensionAsync(bool enabled) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task EnableWriteAheadLoggingAsync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> ExecuteAsync(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Task<T> ExecuteScalarAsync(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> FindAsync(object pk) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Object> FindAsync(object pk, TableMapping map) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> FindAsync(Expression<Func`2<T, Boolean>> predicate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public Task<Object> FindWithQueryAsync(TableMapping map, string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Task<T> FindWithQueryAsync(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public string get_DatabasePath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public string get_DateTimeStringFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public int get_LibVersionNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_StoreDateTimeAsTicks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_StoreTimeSpanAsTicks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[Calls(Type = typeof(SQLiteConnection), Member = "get_TableMappings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SQLite.TableMapping>))]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerable<TableMapping> get_TableMappings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_TimeExecution() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_Trace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public Action<String> get_Tracer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> GetAsync(object pk) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> GetAsync(Expression<Func`2<T, Boolean>> predicate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Object> GetAsync(object pk, TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public TimeSpan GetBusyTimeout() { }

	[CalledBy(Type = typeof(<>c__DisplayClass32_0`1), Member = "<ReadAsync>b__0", ReturnType = "T")]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "Table", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "SQLite.AsyncTableQuery`1<T>")]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_TableMappings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SQLite.TableMapping>))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "set_TimeExecution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_TimeExecution", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "set_Tracer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_Tracer", ReturnType = typeof(System.Action`1<System.String>))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_Trace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "set_Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_StoreDateTimeAsTicks", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "GetBusyTimeout", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_DateTimeStringFormat", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_LibVersionNumber", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_DatabasePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(<>c__DisplayClass33_0`1), Member = "<WriteAsync>b__0", ReturnType = "T")]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_StoreTimeSpanAsTicks", ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SQLiteConnectionPool), Member = "GetConnectionAndTransactionLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString), typeof(Object&)}, ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public SQLiteConnectionWithLock GetConnection() { }

	[CalledBy(Type = typeof(<>c__DisplayClass34_0`1), Member = "<TransactAsync>b__0", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnectionPool), Member = "GetConnectionAndTransactionLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString), typeof(Object&)}, ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	private SQLiteConnectionWithLock GetConnectionAndTransactionLock(out object transactionLock) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Task<TableMapping> GetMappingAsync(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Task<TableMapping> GetMappingAsync(Type type, CreateFlags createFlags = 0) { }

	[CalledBy(Type = "Card.Manager+<DBHasRuleCode>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Task<List`1<ColumnInfo>> GetTableInfoAsync(string tableName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> InsertAllAsync(IEnumerable objects, string extra, bool runInTransaction = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> InsertAllAsync(IEnumerable objects, Type objType, bool runInTransaction = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> InsertAllAsync(IEnumerable objects, bool runInTransaction = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> InsertAsync(object obj, Type objType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Task<Int32> InsertAsync(object obj, string extra, Type objType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> InsertAsync(object obj, string extra) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> InsertAsync(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> InsertOrReplaceAsync(object obj, Type objType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> InsertOrReplaceAsync(object obj) { }

	[CalledBy(Type = "Card.Manager+<SQLiteReaderExecution>d__34`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public Task<List`1<T>> QueryAsync(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public Task<List`1<Object>> QueryAsync(TableMapping map, string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Task<List`1<T>> QueryScalarsAsync(string query, Object[] args) { }

	[CallerCount(Count = 13)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task<T> ReadAsync(Func<SQLiteConnectionWithLock, T> read) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionPool), Member = "Reset", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetPool() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Task RunInTransactionAsync(Action<SQLiteConnection> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public void set_TimeExecution(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Trace(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsUnknownMethods(Count = 2)]
	public void set_Tracer(Action<String> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Task SetBusyTimeoutAsync(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "GetConnection", ReturnType = typeof(SQLiteConnectionWithLock))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> Table() { }

	[CallerCount(Count = 13)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task<T> TransactAsync(Func<SQLiteConnectionWithLock, T> transact) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> UpdateAllAsync(IEnumerable objects, bool runInTransaction = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Int32> UpdateAsync(object obj, Type objType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteAsyncConnection), Member = "WriteAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<SQLiteConnectionWithLock, T>"}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Int32> UpdateAsync(object obj) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<TResult>", typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task<T> WriteAsync(Func<SQLiteConnectionWithLock, T> write) { }

}

