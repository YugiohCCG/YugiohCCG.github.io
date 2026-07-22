namespace System.Net;

public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	private bool m_closed; //Field offset: 0x20
	private long m_contentLength; //Field offset: 0x28
	private FileAccess m_fileAccess; //Field offset: 0x30
	private WebHeaderCollection m_headers; //Field offset: 0x38
	private Stream m_stream; //Field offset: 0x40
	private Uri m_uri; //Field offset: 0x48

	public virtual long ContentLength
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual WebHeaderCollection Headers
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public virtual Uri ResponseUri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	[CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(WebExceptionStatus), typeof(WebResponse)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CalledBy(Type = typeof(FileWebResponse), Member = "get_ContentLength", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileWebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(FileWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(FileWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void CheckDisposed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	public virtual long get_ContentLength() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	public virtual WebHeaderCollection get_Headers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	public virtual Uri get_ResponseUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Stream GetResponseStream() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

