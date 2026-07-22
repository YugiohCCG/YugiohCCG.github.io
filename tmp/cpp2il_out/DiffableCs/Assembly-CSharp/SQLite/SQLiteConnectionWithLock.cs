namespace SQLite;

public class SQLiteConnectionWithLock : SQLiteConnection
{
	private class FakeLockWrapper : IDisposable
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public FakeLockWrapper() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

	}

	private class LockWrapper : IDisposable
	{
		private object _lockPoint; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public LockWrapper(object lockPoint) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		public override void Dispose() { }

	}

	private readonly object _lockPoint; //Field offset: 0x88
	[CompilerGenerated]
	private bool <SkipLock>k__BackingField; //Field offset: 0x90

	public bool SkipLock
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLiteConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SQLiteConnectionString)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SQLiteConnectionWithLock(SQLiteConnectionString connectionString) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_SkipLock() { }

	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass32_0`1", Member = "<ReadAsync>b__0", ReturnType = "T")]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass33_0`1", Member = "<WriteAsync>b__0", ReturnType = "T")]
	[CalledBy(Type = "SQLite.SQLiteAsyncConnection+<>c__DisplayClass34_0`1", Member = "<TransactAsync>b__0", ReturnType = "T")]
	[CalledBy(Type = "SQLite.AsyncTableQuery`1+<>c__DisplayClass2_0`1", Member = "<ReadAsync>b__0", ReturnType = "U")]
	[CalledBy(Type = "SQLite.AsyncTableQuery`1+<>c__DisplayClass3_0`1", Member = "<WriteAsync>b__0", ReturnType = "U")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IDisposable Lock() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SkipLock(bool value) { }

}

