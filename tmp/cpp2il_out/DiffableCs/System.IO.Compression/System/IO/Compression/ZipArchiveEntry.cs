namespace System.IO.Compression;

public class ZipArchiveEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int64, Int64, UInt32, Stream, ZipArchiveEntry, EventHandler> <>9__69_0; //Field offset: 0x8
		public static EventHandler <>9__72_0; //Field offset: 0x10
		public static Action<ZipArchiveEntry> <>9__73_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void <GetDataCompressor>b__69_0(long initialPosition, long currentPosition, uint checkSum, Stream backing, ZipArchiveEntry thisRef, EventHandler closeHandler) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OpenInUpdateMode>b__73_0(ZipArchiveEntry thisRef) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		internal void <OpenInWriteMode>b__72_0(object o, EventArgs e) { }

	}

	[Flags]
	private enum BitFlagValues
	{
		DataDescriptor = 8,
		UnicodeFileName = 2048,
	}

	public enum CompressionMethodValues
	{
		Stored = 0,
		Deflate = 8,
		Deflate64 = 9,
		BZip2 = 12,
		LZMA = 14,
	}

	private sealed class DirectToArchiveWriterStream : Stream
	{
		private long _position; //Field offset: 0x28
		private CheckSumAndSizeWriteStream _crcSizeStream; //Field offset: 0x30
		private bool _everWritten; //Field offset: 0x38
		private bool _isDisposed; //Field offset: 0x39
		private ZipArchiveEntry _entry; //Field offset: 0x40
		private bool _usedZip64inLH; //Field offset: 0x48
		private bool _canWrite; //Field offset: 0x49

		public virtual bool CanRead
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public virtual long Length
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 85
		}

		public virtual long Position
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			 get { } //Length: 26
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 85
		}

		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInWriteMode", ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public DirectToArchiveWriterStream(CheckSumAndSizeWriteStream crcSizeStream, ZipArchiveEntry entry) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteCrcAndSizesInLocalHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual void Flush() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_CanRead() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_CanSeek() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual bool get_CanWrite() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual long get_Length() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		public virtual long get_Position() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual int Read(Byte[] buffer, int offset, int count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual long Seek(long offset, SeekOrigin origin) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual void set_Position(long value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public virtual void SetLength(long value) { }

		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "get_Length", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "get_Position", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Flush", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private void ThrowIfDisposed() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectToArchiveWriterStream), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 20)]
		public virtual void Write(Byte[] buffer, int offset, int count) { }

	}

	private static readonly bool s_allowLargeZipArchiveEntriesInUpdateMode; //Field offset: 0x0
	internal static readonly ZipVersionMadeByPlatform CurrentZipPlatform; //Field offset: 0x1
	private ZipArchive _archive; //Field offset: 0x10
	private readonly bool _originallyInArchive; //Field offset: 0x18
	private readonly int _diskNumberStart; //Field offset: 0x1C
	private readonly ZipVersionMadeByPlatform _versionMadeByPlatform; //Field offset: 0x20
	private ZipVersionNeededValues _versionMadeBySpecification; //Field offset: 0x22
	private ZipVersionNeededValues _versionToExtract; //Field offset: 0x24
	private BitFlagValues _generalPurposeBitFlag; //Field offset: 0x26
	private CompressionMethodValues _storedCompressionMethod; //Field offset: 0x28
	private DateTimeOffset _lastModified; //Field offset: 0x30
	private long _compressedSize; //Field offset: 0x40
	private long _uncompressedSize; //Field offset: 0x48
	private long _offsetOfLocalHeader; //Field offset: 0x50
	private Nullable<Int64> _storedOffsetOfCompressedData; //Field offset: 0x58
	private uint _crc32; //Field offset: 0x68
	private Byte[][] _compressedBytes; //Field offset: 0x70
	private MemoryStream _storedUncompressedData; //Field offset: 0x78
	private bool _currentlyOpenForWrite; //Field offset: 0x80
	private bool _everOpenedForWrite; //Field offset: 0x81
	private Stream _outstandingWriteStream; //Field offset: 0x88
	private uint _externalFileAttr; //Field offset: 0x90
	private string _storedEntryName; //Field offset: 0x98
	private Byte[] _storedEntryNameBytes; //Field offset: 0xA0
	private List<ZipGenericExtraField> _cdUnknownExtraFields; //Field offset: 0xA8
	private List<ZipGenericExtraField> _lhUnknownExtraFields; //Field offset: 0xB0
	private Byte[] _fileComment; //Field offset: 0xB8
	private Nullable<CompressionLevel> _compressionLevel; //Field offset: 0xC0

	private CompressionMethodValues CompressionMethod
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 0)]
		private set { } //Length: 72
	}

	internal bool EverOpenedForWrite
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public private string FullName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(ZipCentralDirectoryFileHeader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(ZipArchiveEntry), Member = "ParseFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ZipVersionMadeByPlatform)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private set { } //Length: 537
	}

	public DateTimeOffset LastWriteTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = typeof(ZipArchiveEntry))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 18)]
		 set { } //Length: 622
	}

	public long Length
	{
		[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 104
	}

	private long OffsetOfCompressedData
	{
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ZipLocalFileHeader), Member = "TrySkipBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private get { } //Length: 320
	}

	private MemoryStream UncompressedData
	{
		[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
		[Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private get { } //Length: 440
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static ZipArchiveEntry() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "DoCreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(CompressionLevel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "set_FullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteAndFinishLocalEntry", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	internal ZipArchiveEntry(ZipArchive archive, string entryName) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipHelper), Member = "DosTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "set_FullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal ZipArchiveEntry(ZipArchive archive, ZipCentralDirectoryFileHeader cd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ZipArchiveEntry(ZipArchive archive, string entryName, CompressionLevel compressionLevel) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CloseStreams() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string DecodeEntryName(Byte[] entryNameBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "UnloadStreams", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void Delete() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Byte[] EncodeEntryName(string entryName, out bool isUTF8) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private CompressionMethodValues get_CompressionMethod() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_EverOpenedForWrite() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_FullName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DateTimeOffset get_LastWriteTime() { }

	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public long get_Length() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ZipLocalFileHeader), Member = "TrySkipBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private long get_OffsetOfCompressedData() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private MemoryStream get_UncompressedData() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInWriteMode", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionLevel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private CheckSumAndSizeWriteStream GetDataCompressor(Stream backingStream, bool leaveBackingStreamOpen, EventHandler onClose) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeflateManagedStream), Member = "InitializeInflater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(IFileFormatReader), typeof(CompressionMethodValues)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private Stream GetDataDecompressor(Stream compressedStreamToRead) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetFileName_Unix(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string GetFileName_Windows(string path) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "ThrowIfNotOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ZipLocalFileHeader), Member = "TrySkipBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "get_OffsetOfCompressedData", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsOpenable(bool needToUncompress, bool needToLoadIntoMemory, out string message) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipLocalFileHeader), Member = "GetExtraFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "get_OffsetOfCompressedData", ReturnType = typeof(long))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal bool LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded() { }

	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = typeof(ZipArchiveEntry))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchiveEntry), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "OpenInWriteMode", ReturnType = typeof(Stream))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Stream Open() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Open", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "get_UncompressedData", ReturnType = typeof(MemoryStream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "get_OffsetOfCompressedData", ReturnType = typeof(long))]
	[Calls(Type = typeof(SubReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "GetDataDecompressor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private Stream OpenInReadMode(bool checkOpenable) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Open", ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "get_UncompressedData", ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(ZipArchiveEntry), typeof(System.Action`1<System.IO.Compression.ZipArchiveEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private Stream OpenInUpdateMode() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Open", ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "GetDataCompressor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(EventHandler)}, ReturnType = typeof(CheckSumAndSizeWriteStream))]
	[Calls(Type = typeof(DirectToArchiveWriterStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CheckSumAndSizeWriteStream), typeof(ZipArchiveEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WrappedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(ZipArchiveEntry), typeof(System.Action`1<System.IO.Compression.ZipArchiveEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private Stream OpenInWriteMode() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "set_FullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string ParseFileName(string path, ZipVersionMadeByPlatform madeByPlatform) { }

	[CallerCount(Count = 0)]
	private void set_CompressionMethod(CompressionMethodValues value) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(ZipCentralDirectoryFileHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "ParseFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ZipVersionMadeByPlatform)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void set_FullName(string value) { }

	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = typeof(ZipArchiveEntry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	public void set_LastWriteTime(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool SizesTooLarge() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfInvalidArchive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void ThrowIfNotOpenable(bool needToUncompress, bool needToLoadIntoMemory) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Delete", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UnloadStreams() { }

	[CallerCount(Count = 0)]
	private void VersionToExtractAtLeast(ZipVersionNeededValues value) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "AcquireArchiveStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchiveEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteAndFinishLocalEntry() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "TotalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ZipHelper), Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "WriteAllBlocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteCentralDirectoryFileHeader() { }

	[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteCrcAndSizesInLocalHeader(bool zip64HeaderUsed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteDataDescriptor() { }

	[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DirectToArchiveWriterStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "TotalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ZipHelper), Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "WriteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "WriteAllBlocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	private bool WriteLocalFileHeader(bool isEmptyFile) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteAndFinishLocalEntry", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "GetDataCompressor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(EventHandler)}, ReturnType = typeof(CheckSumAndSizeWriteStream))]
	[Calls(Type = typeof(DirectToArchiveWriterStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CheckSumAndSizeWriteStream), typeof(ZipArchiveEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void WriteLocalFileHeaderAndDataIfNeeded() { }

}

