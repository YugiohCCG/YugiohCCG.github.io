namespace System.IO.Compression;

internal sealed class FastEncoderWindow
{
	private Byte[] _window; //Field offset: 0x10
	private int _bufPos; //Field offset: 0x18
	private int _bufEnd; //Field offset: 0x1C
	private UInt16[] _prev; //Field offset: 0x20
	private UInt16[] _lookup; //Field offset: 0x28

	public int BytesAvailable
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public int FreeWindowSpace
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public DeflateInput UnprocessedInput
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 122
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void CopyBytes(Byte[] inputBuffer, int startIndex, int count) { }

	[CalledBy(Type = typeof(FastEncoderWindow), Member = "GetNextSymbolOrMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Match)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void FlushWindow() { }

	[CallerCount(Count = 0)]
	public int get_BytesAvailable() { }

	[CallerCount(Count = 0)]
	public int get_FreeWindowSpace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DeflateInput get_UnprocessedInput() { }

	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastEncoder), Member = "GetCompressedOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OutputBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FastEncoderWindow), Member = "FindMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FastEncoderWindow), Member = "InsertStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal bool GetNextSymbolOrMatch(Match match) { }

	[CallerCount(Count = 0)]
	private uint HashValue(uint hash, byte b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private uint InsertString(ref uint hash) { }

	[CalledBy(Type = typeof(FastEncoderWindow), Member = "GetNextSymbolOrMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Match)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void InsertStrings(ref uint hash, int matchLen) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void MoveWindows() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ResetWindow() { }

}

