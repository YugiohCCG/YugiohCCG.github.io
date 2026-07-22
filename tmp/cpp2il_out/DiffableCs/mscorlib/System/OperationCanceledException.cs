namespace System;

public class OperationCanceledException : SystemException
{
	private CancellationToken _cancellationToken; //Field offset: 0x90

	public private CancellationToken CancellationToken
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 21
	}

	[CalledBy(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebCompletionSource`1", Member = "TrySetCanceled", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "SetCanceled", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "Cancel", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public OperationCanceledException() { }

	[CalledBy(Type = typeof(TaskCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public OperationCanceledException(string message) { }

	[CalledBy(Type = typeof(CancellationToken), Member = "ThrowOperationCanceledException", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public OperationCanceledException(string message, CancellationToken token) { }

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected OperationCanceledException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public CancellationToken get_CancellationToken() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void set_CancellationToken(CancellationToken value) { }

}

