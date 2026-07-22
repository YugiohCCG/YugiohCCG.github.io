namespace System.IO.Compression;

internal struct Zip64ExtraField
{
	private ushort _size; //Field offset: 0x0
	private Nullable<Int64> _uncompressedSize; //Field offset: 0x8
	private Nullable<Int64> _compressedSize; //Field offset: 0x18
	private Nullable<Int64> _localHeaderOffset; //Field offset: 0x28
	private Nullable<Int32> _startDiskNumber; //Field offset: 0x38

	public Nullable<Int64> CompressedSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 104
	}

	public Nullable<Int64> LocalHeaderOffset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 104
	}

	public Nullable<Int32> StartDiskNumber
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ushort TotalSize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public Nullable<Int64> UncompressedSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		 set { } //Length: 104
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Nullable<Int64> get_CompressedSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Nullable<Int64> get_LocalHeaderOffset() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public Nullable<Int32> get_StartDiskNumber() { }

	[CallerCount(Count = 0)]
	public ushort get_TotalSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Nullable<Int64> get_UncompressedSize() { }

	[CalledBy(Type = typeof(ZipCentralDirectoryFileHeader), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(ZipCentralDirectoryFileHeader&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "TryGetZip64BlockFromGenericExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipGenericExtraField), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Zip64ExtraField&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipGenericExtraField)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static Zip64ExtraField GetAndRemoveZip64Block(List<ZipGenericExtraField> extraFields, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	[CalledBy(Type = typeof(ZipCentralDirectoryFileHeader), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(ZipCentralDirectoryFileHeader&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipGenericExtraField), Member = "TryReadBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long), typeof(ZipGenericExtraField&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Zip64ExtraField), Member = "TryGetZip64BlockFromGenericExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipGenericExtraField), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Zip64ExtraField&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	[CalledBy(Type = typeof(ZipLocalFileHeader), Member = "GetExtraFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ZipGenericExtraField)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static void RemoveZip64Blocks(List<ZipGenericExtraField> extraFields) { }

	[CallerCount(Count = 0)]
	public void set_CompressedSize(Nullable<Int64> value) { }

	[CallerCount(Count = 0)]
	public void set_LocalHeaderOffset(Nullable<Int64> value) { }

	[CallerCount(Count = 0)]
	public void set_UncompressedSize(Nullable<Int64> value) { }

	[CalledBy(Type = typeof(Zip64ExtraField), Member = "GetJustZip64Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Zip64ExtraField))]
	[CalledBy(Type = typeof(Zip64ExtraField), Member = "GetAndRemoveZip64Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Zip64ExtraField))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 25)]
	private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block) { }

	[CallerCount(Count = 0)]
	private void UpdateSize() { }

	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZipArchiveEntry), Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void WriteBlock(Stream stream) { }

}

