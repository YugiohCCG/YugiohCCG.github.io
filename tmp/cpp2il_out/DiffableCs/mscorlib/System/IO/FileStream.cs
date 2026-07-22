namespace System.IO;

[ComVisible(True)]
public class FileStream : Stream
{
	private sealed class ReadDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ReadDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(Byte[] buffer, int offset, int count) { }

	}

	private sealed class WriteDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public WriteDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Byte[] buffer, int offset, int count) { }

	}

	private static Byte[] buf_recycle; //Field offset: 0x0
	private static readonly object buf_recycle_lock; //Field offset: 0x8
	private Byte[] buf; //Field offset: 0x28
	private string name; //Field offset: 0x30
	private SafeFileHandle safeHandle; //Field offset: 0x38
	private bool isExposed; //Field offset: 0x40
	private long append_startpos; //Field offset: 0x48
	private FileAccess access; //Field offset: 0x50
	private bool owner; //Field offset: 0x54
	private bool async; //Field offset: 0x55
	private bool canseek; //Field offset: 0x56
	private bool anonymous; //Field offset: 0x57
	private bool buf_dirty; //Field offset: 0x58
	private int buf_size; //Field offset: 0x5C
	private int buf_length; //Field offset: 0x60
	private int buf_offset; //Field offset: 0x64
	private long buf_start; //Field offset: 0x68

	public virtual bool CanRead
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public virtual bool CanSeek
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	public virtual bool CanWrite
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public virtual long Length
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoIO), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 413
	}

	public override string Name
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual long Position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
		 get { } //Length: 433
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 153
	}

	public override SafeFileHandle SafeFileHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(FileStream), Member = "InitBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		 get { } //Length: 62
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static FileStream() { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "ReadAllBytesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
	[CalledBy(Type = typeof(File), Member = "WriteAllTextAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(File), Member = "AsyncStreamWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool)}, ReturnType = typeof(StreamWriter))]
	[CalledBy(Type = typeof(File), Member = "AsyncStreamReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(StreamReader))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "InternalWriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "OpenWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = typeof(File), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = typeof(File), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = typeof(File), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = typeof(File), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[CalledBy(Type = "System.IO.File+<InternalWriteAllBytesAsync>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "InitBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "GetFileType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(MonoFileType))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 66)]
	[ContainsUnimplementedInstructions]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	[CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Encoding), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.PathInternal", Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	[CalledBy(Type = "System.Xml.XmlDownloadManager+<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.FileWebStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FileWebRequest", typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FileWebResponse", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FileWebRequest", "System.Uri", typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Compression.ZipArchiveMode", typeof(Encoding)}, ReturnType = "System.IO.Compression.ZipArchive")]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = "System.IO.Compression.ZipArchiveEntry")]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchiveEntry", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Obsolete("Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead")]
	public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) { }

	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Pack>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.PackedBinaryData+<LZ4Unpack>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextWriter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FileWebRequest", Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FileWebStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FileWebRequest", typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.SkeletonBinary", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Spine.SkeletonData")]
	[CalledBy(Type = "Spine.SkeletonJson", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Spine.SkeletonData")]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "AppendBytesToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserHelpers", Member = "AppendFileToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public FileStream(string path, FileMode mode, FileAccess access) { }

	[CalledBy(Type = typeof(Console), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(int)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", "System.Net.ICredentials", "System.Net.IWebProxy", "System.Net.Cache.RequestCachePolicy"}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Xml.XmlUrlResolver", Member = "GetEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stream), Member = "BeginReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "BeginWriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 34)]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 11)]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "InitBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	private void ExposeHandle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "RefillBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "ExposeHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_SafeFileHandle", ReturnType = typeof(SafeFileHandle))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(MonoIO), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void FlushBuffer() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void FlushBufferIfDirty() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_CanRead() { }

	[CallerCount(Count = 0)]
	public virtual bool get_CanSeek() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public virtual long get_Length() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override string get_Name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public virtual long get_Position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "InitBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public override SafeFileHandle get_SafeFileHandle() { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetSecureFileName(string filename) { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetSecureFileName(string filename, bool full) { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoIO), Member = "GetFileType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(MonoFileType))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "InitBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_SafeFileHandle", ReturnType = typeof(SafeFileHandle))]
	[CalledBy(Type = typeof(FileStream), Member = "ExposeHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void InitBuffer(int size, bool isZeroSize) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "ReadSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 32)]
	public virtual int Read(out Byte[] array, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Stream), Member = "BeginEndReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "RefillBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public virtual int ReadByte() { }

	[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "RefillBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MonoIO), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private int ReadData(SafeHandle safeHandle, Byte[] buf, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = "ReadSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	private int ReadInternal(Byte[] dest, int offset, int count) { }

	[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	private int ReadSegment(Byte[] dest, int dest_offset, int count) { }

	[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	private void RefillBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void set_Position(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public virtual void SetLength(long value) { }

	[CalledBy(Type = "System.Net.FileWebStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Stream), Member = "BeginEndWriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Task))]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public virtual void WriteByte(byte value) { }

	[CalledBy(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoIO), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(long), typeof(SeekOrigin), typeof(MonoIOError&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(MonoIO), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileStream), Member = "GetSecureFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void WriteInternal(Byte[] src, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private int WriteSegment(Byte[] src, int src_offset, int count) { }

}

