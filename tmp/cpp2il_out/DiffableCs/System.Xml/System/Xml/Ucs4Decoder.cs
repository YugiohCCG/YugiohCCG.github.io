namespace System.Xml;

internal abstract class Ucs4Decoder : Decoder
{
	internal Byte[] lastBytes; //Field offset: 0x20
	internal int lastBytesCount; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Ucs4Decoder() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CallerCount(Count = 0)]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void Ucs4ToUTF16(uint code, Char[] chars, int charIndex) { }

}

