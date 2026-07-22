namespace System.Threading;

public static class Timeout
{
	public static readonly TimeSpan InfiniteTimeSpan; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private static Timeout() { }

}

