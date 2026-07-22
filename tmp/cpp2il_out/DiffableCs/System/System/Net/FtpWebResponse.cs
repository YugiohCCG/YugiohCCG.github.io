namespace System.Net;

public class FtpWebResponse : WebResponse, IDisposable
{
	public sealed class EmptyStream : MemoryStream
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal EmptyStream() { }

	}

	internal Stream _responseStream; //Field offset: 0x20
	private long _contentLength; //Field offset: 0x28
	private Uri _responseUri; //Field offset: 0x30
	private FtpStatusCode _statusCode; //Field offset: 0x38
	private string _statusLine; //Field offset: 0x40
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x48
	private DateTime _lastModified; //Field offset: 0x50
	private string _bannerMessage; //Field offset: 0x58
	private string _welcomeMessage; //Field offset: 0x60
	private string _exitMessage; //Field offset: 0x68

	public virtual long ContentLength
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual WebHeaderCollection Headers
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 238
	}

	public virtual Uri ResponseUri
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public FtpStatusCode StatusCode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual long get_ContentLength() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual WebHeaderCollection get_Headers() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public virtual Uri get_ResponseUri() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public FtpStatusCode get_StatusCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Stream GetResponseStream() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetResponseStream(Stream stream) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

}

