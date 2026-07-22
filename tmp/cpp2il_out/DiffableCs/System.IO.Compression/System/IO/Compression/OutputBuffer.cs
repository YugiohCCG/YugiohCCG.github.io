namespace System.IO.Compression;

internal sealed class OutputBuffer
{
	[IsReadOnly]
	public struct BufferState
	{
		internal readonly int _pos; //Field offset: 0x0
		internal readonly uint _bitBuf; //Field offset: 0x4
		internal readonly int _bitCount; //Field offset: 0x8

		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "K4os.Compression.LZ4.Streams.Internal.Stash", Member = "AsSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Span`1<Byte>")]
		[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = "K4os.Hash.xxHash.XXH32", Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(uint))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal BufferState(int pos, uint bitBuf, int bitCount) { }

	}

	private Byte[] _byteBuffer; //Field offset: 0x10
	private int _pos; //Field offset: 0x18
	private uint _bitBuf; //Field offset: 0x1C
	private int _bitCount; //Field offset: 0x20

	internal int BitsInBuffer
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 15
	}

	internal int BytesWritten
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int FreeBytes
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 29
	}

	[CallerCount(Count = 0)]
	internal BufferState DumpState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void FlushBits() { }

	[CallerCount(Count = 0)]
	internal int get_BitsInBuffer() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_BytesWritten() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_FreeBytes() { }

	[CallerCount(Count = 0)]
	internal void RestoreState(BufferState state) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateBuffer(Byte[] output) { }

	[CalledBy(Type = typeof(CopyEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeflaterManaged), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetBlockFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "WriteEndOfBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "WriteMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "WriteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "WriteDeflatePreamble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OutputBuffer), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OutputBuffer), Member = "WriteBytesUnaligned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OutputBuffer), Member = "WriteByteUnaligned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteBits(int n, uint bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteBytes(Byte[] byteArray, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void WriteBytesUnaligned(Byte[] byteArray, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	private void WriteByteUnaligned(byte b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteUInt16(ushort value) { }

}

