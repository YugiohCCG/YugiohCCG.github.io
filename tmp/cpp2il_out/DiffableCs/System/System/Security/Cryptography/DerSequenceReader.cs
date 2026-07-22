namespace System.Security.Cryptography;

internal class DerSequenceReader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Encoding> <>9__45_0; //Field offset: 0x8
		public static Func<Encoding> <>9__45_1; //Field offset: 0x10
		public static Func<DateTimeFormatInfo> <>9__51_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		internal Encoding <ReadT61String>b__45_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
		internal Encoding <ReadT61String>b__45_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal DateTimeFormatInfo <ReadTime>b__51_0() { }

	}

	public enum DerTag
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30,
	}

	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; //Field offset: 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; //Field offset: 0x8
	private static Encoding s_latin1Encoding; //Field offset: 0x10
	private readonly Byte[] _data; //Field offset: 0x10
	private readonly int _end; //Field offset: 0x18
	private int _position; //Field offset: 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; //Field offset: 0x20

	private int ContentLength
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	internal bool HasData
	{
		[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 10
	}

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal DerSequenceReader(Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal DerSequenceReader(Byte[] data, int offset, int length) { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private DerSequenceReader(DerTag tagToEat, Byte[] data, int offset, int length) { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	private int EatLength() { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void EatTag(DerTag expected) { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasData() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal byte PeekTag() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal Byte[] ReadBitString() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ReadBMPString() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal bool ReadBoolean() { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private Byte[] ReadContentAsBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	internal DateTime ReadGeneralizedTime() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ReadIA5String() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	internal int ReadInteger() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	internal Byte[] ReadIntegerBytes() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal Byte[] ReadNextEncodedValue() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	internal Byte[] ReadOctetString() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal string ReadOidAsString() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ReadPrintableString() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	internal DerSequenceReader ReadSequence() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	internal DerSequenceReader ReadSet() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal string ReadT61String() { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtcTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadGeneralizedTime", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	internal DateTime ReadUtcTime() { }

	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal string ReadUtf8String() { }

	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal DateTime ReadX509Date() { }

	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "EatLength", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	private static int ScanContentLength(Byte[] data, int offset, int end, out int bytesConsumed) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ContentLength(int value) { }

	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	internal void SkipValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	private static string TrimTrailingNulls(string value) { }

}

