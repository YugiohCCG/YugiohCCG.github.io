namespace System;

[ComVisible(True)]
public static class Buffer
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int _ByteLength(Array array) { }

	[CallerCount(Count = 262)]
	[Calls(Type = typeof(Buffer), Member = "ByteLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CalledBy(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static int ByteLength(Array array) { }

	[CalledBy(Type = typeof(ByteEqualityComparer), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal static int IndexOfByte(Byte* src, byte value, int index, int count) { }

	[CallerCount(Count = 45)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void InternalMemcpy(Byte* dest, Byte* src, int count) { }

	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal static void Memcpy(Byte* pDest, int destIndex, Byte[] src, int srcIndex, int len) { }

	[CalledBy(Type = typeof(string), Member = "memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "WriteInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString), typeof(SecureStringAllocator)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Marshal), Member = "ReadInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "ReadInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "ClearBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]&), typeof(int), typeof(PaddingMode), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Marshal), Member = "ClearUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Interlocked), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	internal static void Memcpy(Byte* dest, Byte* src, int len) { }

	[CallerCount(Count = 0)]
	private static void memcpy1(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	internal static void memcpy2(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	internal static void memcpy4(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeImports), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(Span`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Span`1), Member = "ToArray", ReturnType = "T[]")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeImports), Member = "Memmove_wbarrier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static void Memmove(ref T destination, ref T source, ulong elementCount) { }

	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4ChainDecoder", Member = "Inject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Collections.SortedList+ValueList", Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4EncoderBase", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4EncoderBase", Member = "Topup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4ChainDecoder", Member = "CopyDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4ChainDecoder", Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4ChainDecoder", Member = "Drain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = "WriteSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4ChainDecoder", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4BlockDecoder", Member = "Inject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL64", Member = "LZ4HC_encodeSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte**", "System.Byte**", "System.Byte**", typeof(int), "System.Byte*", "K4os.Compression.LZ4.Engine.LL+limitedOutput_directive", "System.Byte*"}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL64", Member = "LZ4_decompress_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", "System.Byte*", typeof(int), typeof(int), typeof(bool), typeof(bool), "K4os.Compression.LZ4.Engine.LL+dict_directive", "System.Byte*", "System.Byte*", typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL32", Member = "LZ4_decompress_generic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", "System.Byte*", typeof(int), typeof(int), typeof(bool), typeof(bool), "K4os.Compression.LZ4.Engine.LL+dict_directive", "System.Byte*", "System.Byte*", typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL", Member = "LZ4_saveDict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LZ4_stream_t*", "System.Byte*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Engine.LL", Member = "LZ4_saveDictHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LZ4_streamHC_t*", "System.Byte*", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "K4os.Compression.LZ4.Internal.Mem", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", "System.Byte*", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ValidationUtils", Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.Encoders.LZ4BlockDecoder", Member = "Drain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeImports), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public static void MemoryCopy(Void* source, Void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static void ZeroMemory(Byte* src, long len) { }

}

