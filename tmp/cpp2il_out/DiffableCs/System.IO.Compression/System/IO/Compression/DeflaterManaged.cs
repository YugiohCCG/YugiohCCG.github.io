namespace System.IO.Compression;

internal sealed class DeflaterManaged
{
	private enum DeflaterState
	{
		NotStarted = 0,
		SlowDownForIncompressible1 = 1,
		SlowDownForIncompressible2 = 2,
		StartingSmallData = 3,
		CompressThenCheck = 4,
		CheckingForIncompressible = 5,
		HandlingSmallData = 6,
	}

	private readonly FastEncoder _deflateEncoder; //Field offset: 0x10
	private readonly CopyEncoder _copyEncoder; //Field offset: 0x18
	private readonly DeflateInput _input; //Field offset: 0x20
	private readonly OutputBuffer _output; //Field offset: 0x28
	private DeflaterState _processingState; //Field offset: 0x30
	private DeflateInput _inputFromHistory; //Field offset: 0x38

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = typeof(DeflateManagedStream), Member = "PurgeBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeflateManagedStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OutputBuffer), Member = "WriteBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CopyEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal bool Finish(Byte[] outputBuffer, out int bytesRead) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastEncoder), Member = "FlushInput", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FlushInputWindows() { }

	[CalledBy(Type = typeof(DeflateManagedStream), Member = "WriteDeflaterOutput", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal int GetDeflateOutput(Byte[] outputBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool NeedsInput() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetInput(Byte[] inputBuffer, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseCompressed(double ratio) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEncoder), Member = "GetBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeflateInput), typeof(OutputBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteFinal() { }

}

