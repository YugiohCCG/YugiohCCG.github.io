namespace System.ComponentModel;

public class Win32Exception : ExternalException, ISerializable
{
	private readonly int nativeErrorCode; //Field offset: 0x90

	public int NativeErrorCode
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public Win32Exception() { }

	[CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Socket), Member = "CompleteAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1<Socket>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(NetworkInformationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkInformationException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public Win32Exception(int error) { }

	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public Win32Exception(int error, string message) { }

	[CalledBy(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkInformationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public int get_NativeErrorCode() { }

	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	internal static string GetErrorMessage(int error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

