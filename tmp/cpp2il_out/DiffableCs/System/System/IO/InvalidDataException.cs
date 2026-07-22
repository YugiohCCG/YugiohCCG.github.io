namespace System.IO;

public sealed class InvalidDataException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvalidDataException() { }

	[CalledBy(Type = "K4os.Compression.LZ4.LZ4Pickler", Member = "CorruptedPickle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.IO.Compression.Zip64ExtraField", Member = "TryGetZip64BlockFromGenericExtraField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipGenericExtraField", typeof(bool), typeof(bool), typeof(bool), typeof(bool), "System.IO.Compression.Zip64ExtraField&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "OpenInUpdateMode", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "OpenInReadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "ThrowIfNotOpenable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "get_OffsetOfCompressedData", ReturnType = typeof(long))]
	[CalledBy(Type = "System.IO.Compression.ZipArchive", Member = "ReadEndOfCentralDirectory", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchive", Member = "ReadCentralDirectory", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchive", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.IO.Compression.ZipArchiveMode", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.InflaterManaged", Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Compression.InflaterManaged", Member = "Decode", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Compression.HuffmanTree", Member = "GetNextSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.InputBuffer"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.HuffmanTree", Member = "CreateTable", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream+<ReadAsyncCore>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "UnknownFrameVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InvalidDataException))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "MagicNumberExpected", ReturnType = typeof(InvalidDataException))]
	[CalledBy(Type = "K4os.Compression.LZ4.Streams.LZ4DecoderStream", Member = "InvalidHeaderChecksum", ReturnType = typeof(InvalidDataException))]
	[CalledBy(Type = "System.IO.Compression.InflaterManaged", Member = "DecodeUncompressedBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidDataException(string message) { }

	[CalledBy(Type = "System.IO.Compression.ZipArchive", Member = "ReadEndOfCentralDirectory", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public InvalidDataException(string message, Exception innerException) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private InvalidDataException(SerializationInfo info, StreamingContext context) { }

}

