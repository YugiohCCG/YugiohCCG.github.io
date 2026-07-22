namespace System.IO.Compression;

internal struct ZipGenericExtraField
{
	private ushort _tag; //Field offset: 0x0
	private ushort _size; //Field offset: 0x2
	private Byte[] _data; //Field offset: 0x8

	public Byte[] Data
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ushort Size
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ushort Tag
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Byte[] get_Data() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ushort get_Size() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ushort get_Tag() { }

	[CalledBy(Type = typeof(ZipLocalFileHeader), Member = "GetExtraFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[CalledBy(Type = typeof(ZipCentralDirectoryFileHeader), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(ZipCentralDirectoryFileHeader&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long), typeof(ZipGenericExtraField&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static List<ZipGenericExtraField> ParseExtraField(Stream extraFieldData) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int TotalSize(List<ZipGenericExtraField> fields) { }

	[CalledBy(Type = typeof(ZipGenericExtraField), Member = "ParseExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[CalledBy(Type = typeof(Zip64ExtraField), Member = "GetJustZip64Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Zip64ExtraField))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field) { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static void WriteAllBlocks(List<ZipGenericExtraField> fields, Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void WriteBlock(Stream stream) { }

}

