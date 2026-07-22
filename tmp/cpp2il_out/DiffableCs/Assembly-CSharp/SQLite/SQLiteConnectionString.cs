namespace SQLite;

public class SQLiteConnectionString
{
	private const string DateTimeSqliteDefaultFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <UniqueKey>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <DatabasePath>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <StoreDateTimeAsTicks>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <StoreTimeSpanAsTicks>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private readonly string <DateTimeStringFormat>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly DateTimeStyles <DateTimeStyle>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly object <Key>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly SQLiteOpenFlags <OpenFlags>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Action<SQLiteConnection> <PreKeyAction>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly Action<SQLiteConnection> <PostKeyAction>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly string <VfsName>k__BackingField; //Field offset: 0x58

	public string DatabasePath
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string DateTimeStringFormat
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public DateTimeStyles DateTimeStyle
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public object Key
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public SQLiteOpenFlags OpenFlags
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Action<SQLiteConnection> PostKeyAction
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Action<SQLiteConnection> PreKeyAction
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public bool StoreDateTimeAsTicks
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool StoreTimeSpanAsTicks
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string UniqueKey
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string VfsName
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks, object key = null, Action<SQLiteConnection> preKeyAction = null, Action<SQLiteConnection> postKeyAction = null, string vfsName = null) { }

	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteConnectionString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(object), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(System.Action`1<SQLite.SQLiteConnection>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SQLiteAsyncConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SQLiteOpenFlags), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public SQLiteConnectionString(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks, object key = null, Action<SQLiteConnection> preKeyAction = null, Action<SQLiteConnection> postKeyAction = null, string vfsName = null, string dateTimeStringFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", bool storeTimeSpanAsTicks = true) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_DatabasePath() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_DateTimeStringFormat() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DateTimeStyles get_DateTimeStyle() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_Key() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public SQLiteOpenFlags get_OpenFlags() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<SQLiteConnection> get_PostKeyAction() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<SQLiteConnection> get_PreKeyAction() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_StoreDateTimeAsTicks() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_StoreTimeSpanAsTicks() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_UniqueKey() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_VfsName() { }

}

