namespace System.IO.Compression;

[IsReadOnly]
internal struct ZipLocalFileHeader
{

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SubReadStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "ParseExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "RemoveZip64Blocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	public static List<ZipGenericExtraField> GetExtraFields(BinaryReader reader) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "get_OffsetOfCompressedData", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "IsOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	public static bool TrySkipBlock(BinaryReader reader) { }

}

