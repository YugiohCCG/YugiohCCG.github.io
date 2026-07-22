namespace System.Xml;

internal class Ucs4Encoding : Encoding
{
	internal Ucs4Decoder ucs4Decoder; //Field offset: 0x38

	public virtual int CodePage
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal static Encoding UCS4_2143
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 207
	}

	internal static Encoding UCS4_3412
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 207
	}

	internal static Encoding UCS4_Bigendian
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 207
	}

	internal static Encoding UCS4_Littleendian
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 207
	}

	public virtual string WebName
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	public Ucs4Encoding() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_CodePage() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Encoding get_UCS4_2143() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Encoding get_UCS4_3412() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Encoding get_UCS4_Bigendian() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static Encoding get_UCS4_Littleendian() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_WebName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Byte[] GetBytes(string s) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public virtual Decoder GetDecoder() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Encoder GetEncoder() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int GetMaxByteCount(int charCount) { }

	[CallerCount(Count = 0)]
	public virtual int GetMaxCharCount(int byteCount) { }

}

