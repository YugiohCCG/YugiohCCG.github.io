namespace System.Net;

public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	private Uri uri; //Field offset: 0x20
	private WebHeaderCollection webHeaders; //Field offset: 0x28
	private CookieCollection cookieCollection; //Field offset: 0x30
	private string method; //Field offset: 0x38
	private Version version; //Field offset: 0x40
	private HttpStatusCode statusCode; //Field offset: 0x48
	private string statusDescription; //Field offset: 0x50
	private long contentLength; //Field offset: 0x58
	private string contentType; //Field offset: 0x60
	private CookieContainer cookie_container; //Field offset: 0x68
	private bool disposed; //Field offset: 0x70
	private Stream stream; //Field offset: 0x78

	public virtual long ContentLength
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual WebHeaderCollection Headers
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Uri ResponseUri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public override HttpStatusCode StatusCode
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override string StatusDescription
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HttpWebResponse() { }

	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	[CalledBy(Type = "System.Net.HttpWebRequest+<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
	[Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[Obsolete("Serialization is obsoleted for this type", False)]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CalledBy(Type = typeof(HttpWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "get_StatusDescription", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void CheckDisposed() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebResponse), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void FillCookies() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual long get_ContentLength() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual WebHeaderCollection get_Headers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	public virtual Uri get_ResponseUri() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public override HttpStatusCode get_StatusCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	public override string get_StatusDescription() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	public virtual Stream GetResponseStream() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.IDisposable.Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

