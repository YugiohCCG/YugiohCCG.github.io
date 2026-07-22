namespace System.IO.Compression;

internal struct ZipCentralDirectoryFileHeader
{
	public byte VersionMadeByCompatibility; //Field offset: 0x0
	public byte VersionMadeBySpecification; //Field offset: 0x1
	public ushort VersionNeededToExtract; //Field offset: 0x2
	public ushort GeneralPurposeBitFlag; //Field offset: 0x4
	public ushort CompressionMethod; //Field offset: 0x6
	public uint LastModified; //Field offset: 0x8
	public uint Crc32; //Field offset: 0xC
	public long CompressedSize; //Field offset: 0x10
	public long UncompressedSize; //Field offset: 0x18
	public ushort FilenameLength; //Field offset: 0x20
	public ushort ExtraFieldLength; //Field offset: 0x22
	public ushort FileCommentLength; //Field offset: 0x24
	public int DiskNumberStart; //Field offset: 0x28
	public ushort InternalFileAttributes; //Field offset: 0x2C
	public uint ExternalFileAttributes; //Field offset: 0x30
	public long RelativeOffsetOfLocalHeader; //Field offset: 0x38
	public Byte[] Filename; //Field offset: 0x40
	public Byte[] FileComment; //Field offset: 0x48
	public List<ZipGenericExtraField> ExtraFields; //Field offset: 0x50

	[CalledBy(Type = typeof(ZipArchive), Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SubReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "GetJustZip64Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Zip64ExtraField))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "ParseExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "GetAndRemoveZip64Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Zip64ExtraField))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public static bool TryReadBlock(BinaryReader reader, bool saveExtraFieldsAndComments, out ZipCentralDirectoryFileHeader header) { }

}

