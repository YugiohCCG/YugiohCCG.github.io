namespace System.IO.Compression;

internal sealed class FastEncoder
{
	private readonly FastEncoderWindow _inputWindow; //Field offset: 0x10
	private readonly Match _currentMatch; //Field offset: 0x18
	private double _lastCompressionRatio; //Field offset: 0x20

	internal int BytesInHistory
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 29
	}

	internal double LastCompressionRatio
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal DeflateInput UnprocessedInput
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 128
	}

	[CalledBy(Type = typeof(DeflaterManaged), Member = "FlushInputWindows", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void FlushInput() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_BytesInHistory() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal double get_LastCompressionRatio() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DeflateInput get_UnprocessedInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastEncoder), Member = "WriteDeflatePreamble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void GetBlockFooter(OutputBuffer output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastEncoder), Member = "WriteDeflatePreamble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	internal void GetBlockHeader(OutputBuffer output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	internal void GetCompressedData(DeflateInput input, OutputBuffer output) { }

	[CalledBy(Type = typeof(FastEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FastEncoderWindow), Member = "GetNextSymbolOrMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Match)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FastEncoder), Member = "WriteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FastEncoder), Member = "WriteMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastEncoderWindow), Member = "GetNextSymbolOrMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Match)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FastEncoder), Member = "WriteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FastEncoder), Member = "WriteMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void GetCompressedOutput(OutputBuffer output) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool InputAvailable(DeflateInput input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool SafeToWriteTo(OutputBuffer output) { }

	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void WriteChar(byte b, OutputBuffer output) { }

	[CalledBy(Type = typeof(FastEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetBlockHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void WriteDeflatePreamble(OutputBuffer output) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void WriteEndOfBlock(OutputBuffer output) { }

	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output) { }

}

