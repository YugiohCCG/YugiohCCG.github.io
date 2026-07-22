namespace SQLite;

public class AsyncTableQuery
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Expression<Func`2<T, Boolean>> predExpr; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass14_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <CountAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public int index; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass15_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <ElementAtAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Expression<Func`2<T, Boolean>> predExpr; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass18_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <FirstAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Expression<Func`2<T, Boolean>> predExpr; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass19_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal T <FirstOrDefaultAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Func<SQLiteConnectionWithLock, U> read; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnectionWithLock), Member = "Lock", ReturnType = typeof(IDisposable))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		internal U <ReadAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Expression<Func`2<T, Boolean>> predExpr; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass20_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <DeleteAsync>b__0(SQLiteConnectionWithLock conn) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AsyncTableQuery<T> <>4__this; //Field offset: 0x0
		public Func<SQLiteConnectionWithLock, U> write; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SQLiteConnectionWithLock), Member = "Lock", ReturnType = typeof(IDisposable))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		internal U <WriteAsync>b__0() { }

	}

	private TableQuery<T> _innerQuery; //Field offset: 0x0

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AsyncTableQuery`1(TableQuery<T> innerQuery) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int <CountAsync>b__13_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int <DeleteAsync>b__21_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private T <FirstAsync>b__16_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private T <FirstOrDefaultAsync>b__17_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private T[] <ToArrayAsync>b__12_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private List<T> <ToListAsync>b__11_0(SQLiteConnectionWithLock conn) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Task<Int32> CountAsync(Expression<Func`2<T, Boolean>> predExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public Task<Int32> CountAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public Task<Int32> DeleteAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Task<Int32> DeleteAsync(Expression<Func`2<T, Boolean>> predExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Task<T> ElementAtAsync(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<T> FirstAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> FirstAsync(Expression<Func`2<T, Boolean>> predExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<T> FirstOrDefaultAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public Task<T> FirstOrDefaultAsync(Expression<Func`2<T, Boolean>> predExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> OrderBy(Expression<Func`2<T, U>> orderExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> OrderByDescending(Expression<Func`2<T, U>> orderExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task<U> ReadAsync(Func<SQLiteConnectionWithLock, U> read) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> Skip(int n) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> Take(int n) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> ThenBy(Expression<Func`2<T, U>> orderExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> ThenByDescending(Expression<Func`2<T, U>> orderExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<T[]> ToArrayAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Task<List`1<T>> ToListAsync() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AsyncTableQuery<T> Where(Expression<Func`2<T, Boolean>> predExpr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task<U> WriteAsync(Func<SQLiteConnectionWithLock, U> write) { }

}

