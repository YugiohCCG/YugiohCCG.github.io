namespace System.Net;

public sealed class HttpListenerContext
{
	private HttpListenerRequest request; //Field offset: 0x10
	private HttpListenerResponse response; //Field offset: 0x18
	private IPrincipal user; //Field offset: 0x20
	private HttpConnection cnc; //Field offset: 0x28
	private string error; //Field offset: 0x30
	private int err_status; //Field offset: 0x38
	internal HttpListener Listener; //Field offset: 0x40

	internal HttpConnection Connection
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string ErrorMessage
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int ErrorStatus
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool HaveError
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	public HttpListenerRequest Request
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public HttpListenerResponse Response
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal HttpListenerContext(HttpConnection cnc) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal HttpConnection get_Connection() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal string get_ErrorMessage() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_ErrorStatus() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HaveError() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public HttpListenerRequest get_Request() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public HttpListenerResponse get_Response() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HttpListenerContext), Member = "ParseBasicAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPrincipal))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void ParseAuthentication(AuthenticationSchemes expectedSchemes) { }

	[CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(HttpListenerContext))]
	[CalledBy(Type = typeof(HttpListenerContext), Member = "ParseAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthenticationSchemes)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GenericIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GenericPrincipal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal IPrincipal ParseBasicAuthentication(string authData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ErrorMessage(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ErrorStatus(int value) { }

}

