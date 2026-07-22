namespace System.Diagnostics;

public class Stopwatch
{
	public static readonly long Frequency; //Field offset: 0x0
	public static readonly bool IsHighResolution; //Field offset: 0x8
	private long elapsed; //Field offset: 0x10
	private long started; //Field offset: 0x18
	private bool is_running; //Field offset: 0x20

	public TimeSpan Elapsed
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 408
	}

	public long ElapsedMilliseconds
	{
		[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "SQLite.SQLiteConnection", Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 748
	}

	public long ElapsedTicks
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static Stopwatch() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Stopwatch() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public TimeSpan get_Elapsed() { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public long get_ElapsedMilliseconds() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public long get_ElapsedTicks() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static long GetTimestamp() { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	public void Reset() { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Start() { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "ExecuteScalar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Stop() { }

}

