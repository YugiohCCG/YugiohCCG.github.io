namespace System.IO.Compression;

internal sealed class OutputWindow
{
	private readonly Byte[] _window; //Field offset: 0x10
	private int _end; //Field offset: 0x18
	private int _bytesUsed; //Field offset: 0x1C

	public int AvailableBytes
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int FreeBytes
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public OutputWindow() { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeUncompressedBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public int CopyFrom(InputBuffer input, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public int CopyTo(Byte[] output, int offset, int length) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_AvailableBytes() { }

	[CallerCount(Count = 0)]
	public int get_FreeBytes() { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Write(byte b) { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void WriteLengthDistance(int length, int distance) { }

}

