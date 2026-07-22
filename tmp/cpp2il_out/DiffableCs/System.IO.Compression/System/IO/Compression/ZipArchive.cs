namespace System.IO.Compression;

public class ZipArchive : IDisposable
{
	private Stream _archiveStream; //Field offset: 0x10
	private ZipArchiveEntry _archiveStreamOwner; //Field offset: 0x18
	private BinaryReader _archiveReader; //Field offset: 0x20
	private ZipArchiveMode _mode; //Field offset: 0x28
	private List<ZipArchiveEntry> _entries; //Field offset: 0x30
	private ReadOnlyCollection<ZipArchiveEntry> _entriesCollection; //Field offset: 0x38
	private Dictionary<String, ZipArchiveEntry> _entriesDictionary; //Field offset: 0x40
	private bool _readEntries; //Field offset: 0x48
	private bool _leaveOpen; //Field offset: 0x49
	private long _centralDirectoryStart; //Field offset: 0x50
	private bool _isDisposed; //Field offset: 0x58
	private uint _numberOfThisDisk; //Field offset: 0x5C
	private long _expectedNumberOfEntries; //Field offset: 0x60
	private Stream _backingStream; //Field offset: 0x68
	private Byte[] _archiveComment; //Field offset: 0x70
	private Encoding _entryNameEncoding; //Field offset: 0x78

	internal BinaryReader ArchiveReader
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Stream ArchiveStream
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public ReadOnlyCollection<ZipArchiveEntry> Entries
	{
		[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 124
	}

	internal Encoding EntryNameEncoding
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private set { } //Length: 205
	}

	public ZipArchiveMode Mode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal uint NumberOfThisDisk
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ZipArchiveMode), typeof(Encoding)}, ReturnType = typeof(ZipArchive))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ZipArchive), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteAndFinishLocalEntry", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal void AcquireArchiveStream(ZipArchiveEntry entry) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "DoCreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	[CalledBy(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void AddEntry(ZipArchiveEntry entry) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void CloseStreams() { }

	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "DoCreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>", typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = typeof(ZipArchiveEntry))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ZipArchive), Member = "DoCreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	public ZipArchiveEntry CreateEntry(string entryName) { }

	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = typeof(ZipArchiveEntry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipArchive), Member = "DoCreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	[CallsDeduplicatedMethods(Count = 1)]
	public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "CreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ZipArchiveEntry))]
	[CalledBy(Type = typeof(ZipArchive), Member = "CreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompressionLevel)}, ReturnType = typeof(ZipArchiveEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "AddEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchiveEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private ZipArchiveEntry DoCreateEntry(string entryName, Nullable<CompressionLevel> compressionLevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	private void EnsureCentralDirectoryRead() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal BinaryReader get_ArchiveReader() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal Stream get_ArchiveStream() { }

	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public ReadOnlyCollection<ZipArchiveEntry> get_Entries() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal Encoding get_EntryNameEncoding() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ZipArchiveMode get_Mode() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal uint get_NumberOfThisDisk() { }

	[CalledBy(Type = typeof(ZipArchive), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "ReadEndOfCentralDirectory", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 44)]
	private void Init(Stream stream, ZipArchiveMode mode, bool leaveOpen) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "get_Entries", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.IO.Compression.ZipArchiveEntry>))]
	[CalledBy(Type = typeof(ZipArchive), Member = "EnsureCentralDirectoryRead", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchive), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ZipCentralDirectoryFileHeader), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(ZipCentralDirectoryFileHeader&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchive), typeof(ZipCentralDirectoryFileHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "AddEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipArchiveEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void ReadCentralDirectory() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ZipArchiveMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZipHelper), Member = "SeekBackwardsToSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 56)]
	private void ReadEndOfCentralDirectory() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ReleaseArchiveStream(ZipArchiveEntry entry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void RemoveEntry(ZipArchiveEntry entry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void set_EntryNameEncoding(Encoding value) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "get_Entries", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.IO.Compression.ZipArchiveEntry>))]
	[CalledBy(Type = typeof(ZipArchive), Member = "DoCreateEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<System.IO.Compression.CompressionLevel>)}, ReturnType = typeof(ZipArchiveEntry))]
	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "set_LastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "Open", ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "ThrowIfInvalidArchive", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void ThrowIfDisposed() { }

	[CalledBy(Type = typeof(ZipArchive), Member = "WriteFile", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory) { }

	[CalledBy(Type = typeof(ZipArchive), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchive), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "UnloadStreams", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeaderAndDataIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchiveEntry), Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipArchive), Member = "WriteArchiveEpilogue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 25)]
	private void WriteFile() { }

}

