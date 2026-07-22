namespace System.Runtime.CompilerServices;

internal static class AsyncTaskCache
{
	internal static readonly Task<Boolean> TrueTask; //Field offset: 0x0
	internal static readonly Task<Boolean> FalseTask; //Field offset: 0x8
	internal static readonly Task<Int32>[] Int32Tasks; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskCache), Member = "CreateCacheableTask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(AsyncTaskCache), Member = "CreateCacheableTask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsUnknownMethods(Count = 9)]
	private static AsyncTaskCache() { }

	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "TResult", typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Task<TResult> CreateCacheableTask(TResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskCache), Member = "CreateCacheableTask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsUnknownMethods(Count = 6)]
	private static Task<Int32>[] CreateInt32Tasks() { }

}

