namespace System.IO.Compression;

internal sealed class InputBuffer
{
	private Byte[] _buffer; //Field offset: 0x10
	private int _start; //Field offset: 0x18
	private int _end; //Field offset: 0x1C
	private uint _bitBuffer; //Field offset: 0x20
	private int _bitsInBuffer; //Field offset: 0x24

	public int AvailableBits
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int AvailableBytes
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public int CopyTo(Byte[] output, int offset, int length) { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeUncompressedBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputBuffer), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool EnsureBitsAvailable(int count) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_AvailableBits() { }

	[CallerCount(Count = 0)]
	public int get_AvailableBytes() { }

	[CallerCount(Count = 0)]
	private uint GetBitMask(int count) { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputBuffer), Member = "EnsureBitsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public int GetBits(int count) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool NeedsInput() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetInput(Byte[] buffer, int offset, int length) { }

	[CallerCount(Count = 0)]
	public void SkipBits(int n) { }

	[CallerCount(Count = 0)]
	public void SkipToByteBoundary() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public uint TryLoad16Bits() { }

}

