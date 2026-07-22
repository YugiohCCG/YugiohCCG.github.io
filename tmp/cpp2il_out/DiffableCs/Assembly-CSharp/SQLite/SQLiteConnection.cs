namespace SQLite;

[Preserve(AllMembers = True)]
public class SQLiteConnection : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String> <>9__51_0; //Field offset: 0x8
		public static Func<Byte, String> <>9__55_0; //Field offset: 0x10
		public static Func<IndexedColumn, Int32> <>9__70_1; //Field offset: 0x18
		public static Func<IndexedColumn, String> <>9__70_2; //Field offset: 0x20
		public static Func<Column, String> <>9__125_0; //Field offset: 0x28
		public static Func<Column, String> <>9__125_1; //Field offset: 0x30
		public static Func<Column, String> <>9__127_3; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__51_0(string line) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal string <CreateInsertCommand>b__125_0(Column c) { }

		[CallerCount(Count = 0)]
		internal string <CreateInsertCommand>b__125_1(Column c) { }

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal int <CreateTable>b__70_1(IndexedColumn i) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal string <CreateTable>b__70_2(IndexedColumn i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		internal string <SetKey>b__55_0(byte x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal string <Update>b__127_3(Column c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public int c; //Field offset: 0x18
		public SQLiteConnection <>4__this; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass114_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal void <InsertAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public int c; //Field offset: 0x18
		public SQLiteConnection <>4__this; //Field offset: 0x20
		public string extra; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass115_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal void <InsertAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass116_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public int c; //Field offset: 0x18
		public SQLiteConnection <>4__this; //Field offset: 0x20
		public Type objType; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass116_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal void <InsertAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass127_0
	{
		public Column pk; //Field offset: 0x10
		public object obj; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass127_0() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <Update>b__0(Column p) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal object <Update>b__1(Column c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal object <Update>b__2(Column c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass128_0
	{
		public IEnumerable objects; //Field offset: 0x10
		public int c; //Field offset: 0x18
		public SQLiteConnection <>4__this; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass128_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal void <UpdateAll>b__0() { }

	}

	[Preserve(AllMembers = True)]
	internal class ColumnInfo
	{
		[CompilerGenerated]
		private string <Name>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <notnull>k__BackingField; //Field offset: 0x18

		[Column("name")]
		public string Name
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

		public int notnull
		{
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ColumnInfo() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_notnull() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Name(string value) { }

		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_notnull(int value) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public virtual string ToString() { }

	}

	private struct IndexedColumn
	{
		public int Order; //Field offset: 0x0
		public string ColumnName; //Field offset: 0x8

	}

	private struct IndexInfo
	{
		public string IndexName; //Field offset: 0x0
		public string TableName; //Field offset: 0x8
		public bool Unique; //Field offset: 0x10
		public List<IndexedColumn> Columns; //Field offset: 0x18

	}

	private static readonly Dictionary<String, TableMapping> _mappings; //Field offset: 0x0
	private static readonly IntPtr NullHandle; //Field offset: 0x8
	private static readonly IntPtr NullBackupHandle; //Field offset: 0x10
	private bool _open; //Field offset: 0x10
	private TimeSpan _busyTimeout; //Field offset: 0x18
	private Stopwatch _sw; //Field offset: 0x20
	private long _elapsedMilliseconds; //Field offset: 0x28
	private int _transactionDepth; //Field offset: 0x30
	private Random _rand; //Field offset: 0x38
	[CompilerGenerated]
	private IntPtr <Handle>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <DatabasePath>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <LibVersionNumber>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <TimeExecution>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <Trace>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private Action<String> <Tracer>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <StoreDateTimeAsTicks>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <StoreTimeSpanAsTicks>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	private string <DateTimeStringFormat>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private DateTimeStyles <DateTimeStyle>k__BackingField; //Field offset: 0x70
	private readonly Dictionary<Tuple`2<String, String>, PreparedSqlLiteInsertCommand> _insertCommandMap; //Field offset: 0x78
	[CompilerGenerated]
	private EventHandler<NotifyTableChangedEventArgs> TableChanged; //Field offset: 0x80

	public event EventHandler<NotifyTableChangedEventArgs> TableChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public TimeSpan BusyTimeout
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass11_0", Member = "<SetBusyTimeoutAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[Calls(Type = typeof(SQLite3), Member = "BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Result))]
		 set { } //Length: 170
	}

	public private string DatabasePath
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string DateTimeStringFormat
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal DateTimeStyles DateTimeStyle
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private IntPtr Handle
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public bool IsInTransaction
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public private int LibVersionNumber
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private bool StoreDateTimeAsTicks
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

	public private bool StoreTimeSpanAsTicks
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

	public IEnumerable<TableMapping> TableMappings
	{
		[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_TableMappings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SQLite.TableMapping>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 361
	}

	public bool TimeExecution
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool Trace
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Action<String> Tracer
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SQLiteConnection() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnectionPool+Entry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnectionPool), Member = "GetConnectionAndTransactionLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString), typeof(Object&)}, ReturnType = typeof(SQLiteConnectionWithLock))]
	[CalledBy(Type = typeof(SQLiteConnectionWithLock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "SetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(SQLite3), Member = "BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(SQLite3), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(IntPtr&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(SQLite3), Member = "LibVersionNumber", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 24)]
	public SQLiteConnection(SQLiteConnectionString connectionString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Orm), Member = "SqlDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CompilerGenerated]
	private string <CreateTable>b__70_0(Column p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void add_TableChanged(EventHandler<NotifyTableChangedEventArgs> value) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass64_0", Member = "<BackupAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLite3), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr&)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "BackupInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(SQLite3), Member = "BackupStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "BackupFinish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[Calls(Type = typeof(SQLite3), Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void Backup(string destinationDatabasePath, string databaseName = "main") { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass80_0", Member = "<RunInTransactionAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RollbackTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void BeginTransaction() { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Close() { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass80_0", Member = "<RunInTransactionAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Commit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SQLiteCommand), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public SQLiteCommand CreateCommand(string cmdText, Dictionary<String, Object> args) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass82_0`1", Member = "<ExecuteScalarAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TableQuery`1), Member = "GenerateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SQLiteCommand))]
	[CalledBy(Type = typeof(TableQuery`1), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, Boolean>>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "FindWithQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Query", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeferredQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "QueryScalars", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeferredQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string), typeof(Object[])}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SQLiteCommand), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SQLiteCommand CreateCommand(string cmdText, Object[] ps) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass47_0", Member = "<CreateIndexAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	public int CreateIndex(string tableName, String[] columnNames, bool unique = false) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass48_0", Member = "<CreateIndexAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public int CreateIndex(string indexName, string tableName, String[] columnNames, bool unique = false) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass46_0", Member = "<CreateIndexAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, Object>>", typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass45_0", Member = "<CreateIndexAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public int CreateIndex(string tableName, string columnName, bool unique = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableMapping), Member = "FindColumnWithPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Column))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public int CreateIndex(Expression<Func`2<T, Object>> property, bool unique = false) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "GetInsertCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string)}, ReturnType = typeof(PreparedSqlLiteInsertCommand))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnection), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private PreparedSqlLiteInsertCommand CreateInsertCommand(TableMapping map, string extra) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public CreateTableResult CreateTable(CreateFlags createFlags = 0) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass37_0", Member = "<CreateTableAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(CreateTableResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, SQLite.SQLiteConnection+IndexInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IndexInfo))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+KeyCollection+Enumerator<System.Object, SQLite.SQLiteConnection+IndexInfo>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, SQLite.SQLiteConnection+IndexInfo>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IndexInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, SQLite.SQLiteConnection+IndexInfo>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IndexInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "MigrateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	public CreateTableResult CreateTable(Type ty, CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	public CreateTablesResult CreateTables(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public CreateTablesResult CreateTables(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	public CreateTablesResult CreateTables(CreateFlags createFlags = 0) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(CreateTablesResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(CreateTablesResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3", "T4"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(CreateTablesResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2", "T3", "T4", "T5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(CreateTablesResult))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass42_0", Member = "<CreateTablesAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(CreateTablesResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CreateTablesResult), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public CreateTablesResult CreateTables(CreateFlags createFlags = 0, Type[] types) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags), typeof(Type[])}, ReturnType = typeof(CreateTablesResult))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public CreateTablesResult CreateTables(CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public IEnumerable<T> DeferredQuery(string query, Object[] args) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass87_0", Member = "<DeferredQueryAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteDeferredQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerable<Object> DeferredQuery(TableMapping map, string query, Object[] args) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass61_0", Member = "<DeleteAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "OnTableChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(NotifyTableChangedAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public int Delete(object primaryKey, TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int Delete(object primaryKey) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass59_0", Member = "<DeleteAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "OnTableChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(NotifyTableChangedAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public int Delete(object objectToDelete) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass63_0", Member = "<DeleteAllAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "OnTableChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(NotifyTableChangedAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int DeleteAll(TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int DeleteAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLite3), Member = "Close2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLite3), Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "RollbackTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Thread), Member = "VolatileWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void DoSavePointExecute(string savepoint, string cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(SQLiteConnection), Member = "DropTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int DropTable() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "DropTable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass44_0", Member = "<DropTableAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int DropTable(TableMapping map) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass35_0", Member = "<EnableLoadExtensionAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLite3), Member = "EnableLoadExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(SQLite3), Member = "GetErrmsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string)}, ReturnType = typeof(SQLiteException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableLoadExtension(bool enabled) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c", Member = "<EnableWriteAheadLoggingAsync>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableWriteAheadLogging() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass76_0", Member = "<ExecuteAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DoSavePointExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "RollbackTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "SaveTransactionPoint", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "MigrateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "BeginTransaction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "SetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "SetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DropTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteNonQuery", ReturnType = typeof(int))]
	[Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int Execute(string query, Object[] args) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "EnableWriteAheadLogging", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public T ExecuteScalar(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public T Find(object pk) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass69_0", Member = "<FindAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	public object Find(object pk, TableMapping map) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T Find(Expression<Func`2<T, Boolean>> predicate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T FindWithQuery(string query, Object[] args) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass72_0", Member = "<FindWithQueryAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public object FindWithQuery(TableMapping map, string query, Object[] args) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass66_0", Member = "<GetAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsUnknownMethods(Count = 6)]
	public object Get(object pk, TableMapping map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public T Get(object pk) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T Get(Expression<Func`2<T, Boolean>> predicate) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public TimeSpan get_BusyTimeout() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_DatabasePath() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_DateTimeStringFormat() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DateTimeStyles get_DateTimeStyle() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntPtr get_Handle() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsInTransaction() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LibVersionNumber() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_StoreDateTimeAsTicks() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_StoreTimeSpanAsTicks() { }

	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = "get_TableMappings", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SQLite.TableMapping>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerable<TableMapping> get_TableMappings() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_TimeExecution() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Trace() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<String> get_Tracer() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`2<System.Object, System.Object>))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateInsertCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string)}, ReturnType = typeof(PreparedSqlLiteInsertCommand))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private PreparedSqlLiteInsertCommand GetInsertCommand(TableMapping map, string extra) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TableMapping GetMapping(CreateFlags createFlags = 0) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass73_0", Member = "<GetMappingAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(TableMapping))]
	[CalledBy(Type = typeof(TableQuery`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteCommand), Member = "ExecuteDeferredQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Find", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DropTable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TableMapping GetMapping(Type type, CreateFlags createFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static Byte[] GetNullTerminatedUtf8(string s) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass75_0", Member = "<GetTableInfoAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Query", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	public List<ColumnInfo> GetTableInfo(string tableName) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass51_0", Member = "<InsertAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	public int Insert(object obj, Type objType) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass50_0", Member = "<InsertAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	public int Insert(object obj) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass52_0", Member = "<InsertAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	public int Insert(object obj, string extra) { }

	[CalledBy(Type = typeof(<>c__DisplayClass114_0), Member = "<InsertAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass53_0", Member = "<InsertAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertOrReplace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<>c__DisplayClass116_0), Member = "<InsertAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass115_0), Member = "<InsertAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result), typeof(string), typeof(TableMapping), typeof(object)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[Calls(Type = typeof(SQLiteConnection), Member = "OnTableChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(NotifyTableChangedAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLite3), Member = "ExtendedErrCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(ExtendedResult))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLite3), Member = "LastInsertRowid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetInsertCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(string)}, ReturnType = typeof(PreparedSqlLiteInsertCommand))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Column), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(PreparedSqlLiteInsertCommand), Member = "ExecuteNonQuery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public int Insert(object obj, string extra, Type objType) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass77_0", Member = "<InsertAllAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public int InsertAll(IEnumerable objects, bool runInTransaction = true) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass78_0", Member = "<InsertAllAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public int InsertAll(IEnumerable objects, string extra, bool runInTransaction = true) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass79_0", Member = "<InsertAllAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public int InsertAll(IEnumerable objects, Type objType, bool runInTransaction = true) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass55_0", Member = "<InsertOrReplaceAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	public int InsertOrReplace(object obj, Type objType) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass54_0", Member = "<InsertOrReplaceAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	public int InsertOrReplace(object obj) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Orm), Member = "SqlDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void MigrateTable(TableMapping map, List<ColumnInfo> existingCols) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override SQLiteCommand NewCommand() { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TableMapping)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "DeleteAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTableChanged(TableMapping table, NotifyTableChangedAction action) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "CreateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(CreateTableResult))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "GetTableInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<SQLite.SQLiteConnection+ColumnInfo>))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass83_0`1", Member = "<QueryAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public List<T> Query(string query, Object[] args) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass85_0", Member = "<QueryAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[Calls(Type = typeof(SQLiteCommand), Member = "ExecuteQuery", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	public List<Object> Query(TableMapping map, string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnection), Member = "CreateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(SQLiteCommand))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public List<T> QueryScalars(string query, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string Quote(string unsafeString) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLiteConnection), Member = "DoSavePointExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Release(string savepoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void remove_TableChanged(EventHandler<NotifyTableChangedEventArgs> value) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass80_0", Member = "<RunInTransactionAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SQLiteConnection), Member = "RollbackTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public void Rollback() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void RollbackTo(string savepoint) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "BeginTransaction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "SaveTransactionPoint", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "Rollback", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SQLiteConnection), Member = "DoSavePointExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RollbackTo(string savepoint, bool noThrow) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "InsertAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "UpdateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SQLiteConnection), Member = "SaveTransactionPoint", ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Rollback", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RunInTransaction(Action action) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RollbackTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public string SaveTransactionPoint() { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass11_0", Member = "<SetBusyTimeoutAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(SQLite3), Member = "BusyTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Result))]
	public void set_BusyTimeout(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_DatabasePath(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_DateTimeStringFormat(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_DateTimeStyle(DateTimeStyles value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Handle(IntPtr value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LibVersionNumber(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StoreDateTimeAsTicks(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_StoreTimeSpanAsTicks(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TimeExecution(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Trace(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Tracer(Action<String> value) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void SetKey(Byte[] key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void SetKey(string key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TableQuery<T> Table() { }

	[CalledBy(Type = typeof(<>c__DisplayClass128_0), Member = "<UpdateAll>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = "UpdateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass57_0", Member = "<UpdateAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotNullConstraintViolationException), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteException), typeof(TableMapping), typeof(object)}, ReturnType = typeof(NotNullConstraintViolationException))]
	[Calls(Type = typeof(SQLite3), Member = "ExtendedErrCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(ExtendedResult))]
	[Calls(Type = typeof(SQLiteConnection), Member = "OnTableChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TableMapping), typeof(NotifyTableChangedAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(SQLiteConnection), Member = "GetMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(CreateFlags)}, ReturnType = typeof(TableMapping))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	public int Update(object obj, Type objType) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass56_0", Member = "<UpdateAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[ContainsInvalidInstructions]
	public int Update(object obj) { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass58_0", Member = "<UpdateAllAsync>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionWithLock)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Orm), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SQLiteConnection), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLiteConnection), Member = "RunInTransaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public int UpdateAll(IEnumerable objects, bool runInTransaction = true) { }

}

