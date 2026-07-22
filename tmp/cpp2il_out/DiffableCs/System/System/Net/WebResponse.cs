namespace System.Net;

public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	private bool m_IsFromCache; //Field offset: 0x18

	public override long ContentLength
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override WebHeaderCollection Headers
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override bool IsFromCache
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Uri ResponseUri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected WebResponse() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(HttpWebResponse), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override long get_ContentLength() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override WebHeaderCollection get_Headers() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsFromCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override Uri get_ResponseUri() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override Stream GetResponseStream() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

