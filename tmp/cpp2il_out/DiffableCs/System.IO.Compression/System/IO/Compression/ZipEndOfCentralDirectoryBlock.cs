namespace System.IO.Compression;

internal struct ZipEndOfCentralDirectoryBlock
{
	public uint Signature; //Field offset: 0x0
	public ushort NumberOfThisDisk; //Field offset: 0x4
	public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory; //Field offset: 0x6
	public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk; //Field offset: 0x8
	public ushort NumberOfEntriesInTheCentralDirectory; //Field offset: 0xA
	public uint SizeOfCentralDirectory; //Field offset: 0xC
	public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber; //Field offset: 0x10
	public Byte[] ArchiveComment; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory, Byte[] archiveComment) { }

}

