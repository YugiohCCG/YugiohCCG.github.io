namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }

	}

	internal enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4,
	}

	public enum UnityWebRequestError
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40,
	}

	public enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	public CertificateHandler certificateHandler
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public bool disposeCertificateHandlerOnDispose
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool disposeDownloadHandlerOnDispose
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool disposeUploadHandlerOnDispose
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ulong downloadedBytes
	{
		[CalledBy(Type = "Manager.Updater+<>c__DisplayClass32_0", Member = "<DownloadAssetBundle>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public DownloadHandler downloadHandler
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 13)]
		 set { } //Length: 357
	}

	public float downloadProgress
	{
		[CalledBy(Type = "Manager.Updater+<>c__DisplayClass32_0", Member = "<DownloadAssetBundle>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 228
	}

	public string error
	{
		[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetHTTPStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 396
	}

	public bool isDone
	{
		[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 86
	}

	public bool isModifiable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("IsModifiable")]
		 get { } //Length: 81
	}

	public string method
	{
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
		[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 14)]
		 set { } //Length: 595
	}

	public long responseCode
	{
		[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public Result result
	{
		[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetResult")]
		 get { } //Length: 81
	}

	public UploadHandler uploadHandler
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 13)]
		 set { } //Length: 357
	}

	public Uri uri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 242
	}

	public string url
	{
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CalledBy(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(WebRequestUtils), Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 132
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestAssetBundle", Member = "GetAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestMultimedia", Member = "GetAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestTexture", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestTexture", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UnityWebRequest(string url, string method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True)]
	public void Abort() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Abort_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static IntPtr Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "DisposeHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisposeHandlers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "DisposeHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalDestroy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static UnityWebRequest Get(string uri) { }

	[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static UnityWebRequest Get(Uri uri) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CertificateHandler get_certificateHandler() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_disposeUploadHandlerOnDispose() { }

	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass32_0", Member = "<DownloadAssetBundle>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ulong get_downloadedBytes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ulong get_downloadedBytes_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public DownloadHandler get_downloadHandler() { }

	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass32_0", Member = "<DownloadAssetBundle>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public float get_downloadProgress() { }

	[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetHTTPStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	public string get_error() { }

	[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_isDone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("IsModifiable")]
	public bool get_isModifiable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public long get_responseCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetResult")]
	public Result get_result() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Result get_result_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public UploadHandler get_uploadHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private float GetDownloadProgress() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetDownloadProgress_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private UnityWebRequestError GetError() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetWebErrorString_Injected(UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void InternalDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal void InternalSetCustomMethod(string customMethodName) { }

	[CallerCount(Count = 0)]
	private void InternalSetDefaults() { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("SetRequestHeader")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError InternalSetRequestHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, ref ManagedSpanWrapper value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_uri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private void InternalSetUrl(string url) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool IsExecuting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsExecuting_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static UnityWebRequest PostWwwForm(string uri, string form) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Release_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Helper+<DoGetString>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<DoPostRequest>d__140`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public void set_downloadHandler(DownloadHandler value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestMethod)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public void set_method(string value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public void set_uploadHandler(UploadHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void set_uri(Uri value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WebRequestUtils), Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_url(string value) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetCustomMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequestMethod methodType) { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "DefineRequestHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "InternalSetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequestError))]
	[Calls(Type = typeof(UnityWebRequest), Member = "GetWebErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequestError)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	public void SetRequestHeader(string name, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static void SetupPostWwwForm(UnityWebRequest request, string postData) { }

	[CalledBy(Type = typeof(UnityWebRequest), Member = "InternalSetUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private UnityWebRequestError SetUrl(string url) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

}

