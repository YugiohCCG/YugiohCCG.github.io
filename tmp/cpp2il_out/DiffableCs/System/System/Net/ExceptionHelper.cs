namespace System.Net;

internal static class ExceptionHelper
{

	internal static NotImplementedException MethodNotImplementedException
	{
		[CalledBy(Type = typeof(EndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
		[CalledBy(Type = typeof(EndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
		[CalledBy(Type = typeof(WebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[CalledBy(Type = typeof(WebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(WebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
		[CalledBy(Type = typeof(WebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(WebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(WebRequest), Member = "Abort", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 110
	}

	internal static NotImplementedException PropertyNotImplementedException
	{
		[CalledBy(Type = typeof(EndPoint), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[CalledBy(Type = typeof(WebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[CalledBy(Type = typeof(WebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
		[CalledBy(Type = typeof(WebResponse), Member = "get_ContentLength", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_Timeout", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(WebRequest), Member = "set_Proxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IWebProxy)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_Proxy", ReturnType = typeof(IWebProxy))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebRequest), Member = "set_Credentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICredentials)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "set_ContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_ContentLength", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_RequestUri", ReturnType = typeof(Uri))]
		[CalledBy(Type = typeof(WebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_Method", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_Credentials", ReturnType = typeof(ICredentials))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 110
	}

	internal static NotSupportedException PropertyNotSupportedException
	{
		[CalledBy(Type = typeof(FtpWebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 110
	}

	internal static WebException RequestAbortedException
	{
		[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CloseExState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
		internal get { } //Length: 134
	}

	internal static WebException TimeoutException
	{
		[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		internal get { } //Length: 101
	}

	[CalledBy(Type = typeof(EndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
	[CalledBy(Type = typeof(EndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
	[CalledBy(Type = typeof(WebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(WebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(WebRequest), Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(WebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(WebRequest), Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(WebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static NotImplementedException get_MethodNotImplementedException() { }

	[CalledBy(Type = typeof(EndPoint), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_Credentials", ReturnType = typeof(ICredentials))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_Method", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WebRequest), Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_RequestUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_ContentLength", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(WebRequest), Member = "set_ContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_Proxy", ReturnType = typeof(IWebProxy))]
	[CalledBy(Type = typeof(WebRequest), Member = "set_Proxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IWebProxy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_Timeout", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(WebResponse), Member = "get_ContentLength", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(WebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(WebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(WebRequest), Member = "set_Credentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICredentials)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CloseExState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FtpDataStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	internal static WebException get_RequestAbortedException() { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	internal static WebException get_TimeoutException() { }

}

