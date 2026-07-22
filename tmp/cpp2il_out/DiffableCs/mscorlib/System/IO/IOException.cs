namespace System.IO;

public class IOException : SystemException
{

	[CalledBy(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsyncInner>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public IOException() { }

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public IOException(string message) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public IOException(string message, int hresult) { }

	[CalledBy(Type = typeof(BinaryReader), Member = "ReadDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketError", typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketError"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteAsyncInner>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "GetIOException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public IOException(string message, Exception innerException) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IOException(SerializationInfo info, StreamingContext context) { }

}

