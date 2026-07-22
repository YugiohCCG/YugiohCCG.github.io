namespace System.Net;

public class HttpListenerException : Win32Exception
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public HttpListenerException() { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public HttpListenerException(int errorCode, string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

