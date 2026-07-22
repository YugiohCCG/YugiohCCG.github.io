namespace System.Net.Sockets;

internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	private const int SOCKET_CLOSED = 10004; //Field offset: 0x0
	private const int ABORT_RETRIES = 10; //Field offset: 0x0
	private static bool THROW_ON_ABORT_RETRIES; //Field offset: 0x0
	private List<Thread> blocking_threads; //Field offset: 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; //Field offset: 0x28
	private bool in_cleanup; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static SafeSocketHandle() { }

	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Int32&), typeof(bool)}, ReturnType = typeof(SafeSocketHandle))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	internal SafeSocketHandle() { }

	[CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Int32&), typeof(bool)}, ReturnType = typeof(SafeSocketHandle))]
	[CalledBy(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterForBlockingSyscall() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	protected virtual bool ReleaseHandle() { }

	[CalledBy(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Int32&), typeof(bool)}, ReturnType = typeof(SafeSocketHandle))]
	[CalledBy(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UnRegisterForBlockingSyscall() { }

}

