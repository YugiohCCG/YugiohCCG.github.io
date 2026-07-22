namespace System.IO.Compression;

internal struct Zip64EndOfCentralDirectoryLocator
{
	public uint NumberOfDiskWithZip64EOCD; //Field offset: 0x0
	public ulong OffsetOfZip64EOCD; //Field offset: 0x8
	public uint TotalNumberOfDisks; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteBlock(Stream stream, long zip64EOCDRecordStart) { }

}

