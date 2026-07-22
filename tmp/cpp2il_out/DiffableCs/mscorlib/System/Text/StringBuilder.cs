namespace System.Text;

[DefaultMember("Chars")]
public sealed class StringBuilder : ISerializable
{
	internal Char[] m_ChunkChars; //Field offset: 0x10
	internal StringBuilder m_ChunkPrevious; //Field offset: 0x18
	internal int m_ChunkLength; //Field offset: 0x20
	internal int m_ChunkOffset; //Field offset: 0x24
	internal int m_MaxCapacity; //Field offset: 0x28

	public int Capacity
	{
		[CalledBy(Type = "ZXing.Datamatrix.Encoder.ErrorCorrection", Member = "encodeECC200", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "ZXing.Datamatrix.Encoder.SymbolInfo"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Linq.XDeclaration", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Linq.XElement", Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public char Chars
	{
		[CallerCount(Count = 74)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 200
		[CalledBy(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "FilterSwearListForCompleteWordsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<String>"}, ReturnType = "System.Collections.Generic.List`1<String>")]
		[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorStringByProfanityList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.Generic.List`1<String>", typeof(StringBuilder), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "ZXing.OneD.CodaBarReader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
		[CalledBy(Type = "ZXing.Datamatrix.Encoder.ErrorCorrection", Member = "encodeECC200", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "ZXing.Datamatrix.Encoder.SymbolInfo"}, ReturnType = typeof(string))]
		[CalledBy(Type = "ZXing.Datamatrix.Encoder.Base256Encoder", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDuration", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDuration+DurationType"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RegistryKey), Member = "FixupPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		 set { } //Length: 278
	}

	public int Length
	{
		[CallerCount(Count = 283)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 81)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 670
	}

	public int MaxCapacity
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private Span<Char> RemainingCurrentChunk
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 161
	}

	[CallerCount(Count = 251)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StringBuilder() { }

	[CallerCount(Count = 143)]
	[ContainsInvalidInstructions]
	public StringBuilder(int capacity) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public StringBuilder(string value) { }

	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public StringBuilder(string value, int capacity) { }

	[CalledBy(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureData), Member = "UnescapeNlsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public StringBuilder(string value, int startIndex, int length, int capacity) { }

	[CalledBy(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public StringBuilder(int capacity, int maxCapacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private StringBuilder(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private StringBuilder(StringBuilder from) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock) { }

	[CallerCount(Count = 708)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	public StringBuilder Append(char value) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "FormatAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest"}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Append(byte value) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Append(int value) { }

	[CalledBy(Type = "BigIntegerLibrary.Base10BigInteger", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Append(long value) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "ReplacementImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "System.Text.RegularExpressions.Match"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	public StringBuilder Append(ReadOnlySpan<Char> value) { }

	[CalledBy(Type = typeof(Tuple`2), Member = "System.ITupleInternal.ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Utilities.Async.CoroutineWrapper`1", Member = "GenerateObjectTraceMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Type>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+ParseError", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser+TagTypeInfo", Member = "PrintMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.SupportClass", Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.QrCode.Internal.QRCode", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Xml.XmlDocument", "System.Xml.XmlElement", typeof(bool)}, ReturnType = "System.Xml.XmlElement")]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyValuePair), Member = "PairToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Tuple`4), Member = "System.ITupleInternal.ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Tuple`3), Member = "System.ITupleInternal.ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlList`1", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	public StringBuilder Append(object value) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "WriteTimeFullPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.PDF417.Internal.DecodedBitStreamParser", Member = "byteCompaction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Int32[]", typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	public StringBuilder Append(Char[] value) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Append(StringBuilder value) { }

	[CalledBy(Type = typeof(string), Member = "JoinCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "AppendHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[CLSCompliant(False)]
	public StringBuilder Append(Char* value, int valueCount) { }

	[CalledBy(Type = "ZXing.Client.Result.GeoParsedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.GeoParsedResult", Member = "getGeoURI", ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Client.Result.GeoParsedResult", Member = "getGoogleMapsURI", ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Append(double value) { }

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public StringBuilder Append(string value, int startIndex, int count) { }

	[CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt16[]", typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CLSCompliant(False)]
	public StringBuilder Append(uint value) { }

	[CallerCount(Count = 1083)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public StringBuilder Append(string value) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	public StringBuilder Append(Char[] value, int startIndex, int charCount) { }

	[CalledBy(Type = typeof(ArraySpec), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(ArraySpec), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PointerSpec), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(PointerSpec), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.PasteArguments", Member = "AppendArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public StringBuilder Append(char value, int repeatCount) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	[CalledBy(Type = "ZXing.Client.Result.GeoParsedResult", Member = "getDisplayResult", ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.PDF417.Internal.DetectionResult", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.PDF417.Internal.DetectionResultColumn", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.PDF417.Internal.PDF417ScanningDecoder", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.PDF417.Internal.BarcodeValue[][]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Rendering.SvgRenderer+SvgImage", Member = "AddRec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.ResultPoint", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, Object[] args) { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	[CalledBy(Type = typeof(AggregateException), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger", Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferResource", Member = "LogCreation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferResource", Member = "LogRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureResource", Member = "LogCreation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureResource", Member = "LogRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RTHandleResourcePool", Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public StringBuilder AppendFormat(string format, Object[] args) { }

	[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "NetscapeCertType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequest", "System.Net.ICredentials"}, ReturnType = "System.Net.Authorization")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+CommandBuilder", Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "Unity.Burst.BurstCompiler+CommandBuilder")]
	[CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder AppendFormat(string format, object arg0) { }

	[CalledBy(Type = typeof(ASN1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ToXml", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RTHandleResourcePool", Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "FormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParamsArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "FormatError", ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private void AppendHelper(string value) { }

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder AppendLine() { }

	[CallerCount(Count = 136)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	public StringBuilder AppendLine(string value) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private StringBuilder AppendSpanFormattable(T value) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ClearLog", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ClearChat", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphLogger", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "BeginRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler+CommandBuilder", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Unity.Burst.BurstCompiler+CommandBuilder")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "BeginCompilerCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Unity.Burst.BurstCompiler+CommandBuilder")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "SendCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+<>c", Member = "<.cctor>b__11_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public StringBuilder Clear() { }

	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(System.Span`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	public void CopyTo(int sourceIndex, Span<Char> destination, int count) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void ExpandByABlock(int minBlockCharCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private StringBuilder FindChunkForIndex(int index) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void FormatError() { }

	[CalledBy(Type = "ZXing.Datamatrix.Encoder.ErrorCorrection", Member = "encodeECC200", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "ZXing.Datamatrix.Encoder.SymbolInfo"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XDeclaration", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XElement", Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public int get_Capacity() { }

	[CallerCount(Count = 74)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public char get_Chars(int index) { }

	[CallerCount(Count = 283)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_MaxCapacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private Span<Char> get_RemainingCurrentChunk() { }

	[CalledBy(Type = "ZXing.Datamatrix.Encoder.Base256Encoder", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.OneD.EAN13Reader", Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitArray", "System.Int32[]", typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = "ZXing.OneD.EAN13Reader", Member = "determineFirstDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.OneD.UPCEReader", Member = "decodeMiddle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitArray", "System.Int32[]", typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = "ZXing.OneD.UPCEReader", Member = "determineNumSysAndCheckDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.QrCode.Internal.DecodedBitStreamParser", Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitSource", typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public StringBuilder Insert(int index, Char[] value) { }

	[CalledBy(Type = typeof(HebrewNumber), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Bootstring), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Xml.XmlDocument", "System.Xml.XmlElement", typeof(bool)}, ReturnType = "System.Xml.XmlElement")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	public StringBuilder Insert(int index, char value) { }

	[CalledBy(Type = typeof(Enum), Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "FinishFacetCompile", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "InternalFlagsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.EnumInfo", typeof(ulong)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Datamatrix.Internal.DecodedBitStreamParser", Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "ZXing.Common.DecoderResult")]
	[CalledBy(Type = "ZXing.Datamatrix.Internal.DecodedBitStreamParser", Member = "decodeAsciiSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitSource", typeof(StringBuilder), typeof(StringBuilder), "Mode&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Maxicode.Internal.DecodedBitStreamParser", Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = "ZXing.Common.DecoderResult")]
	[CalledBy(Type = "DG.Tweening.Plugins.StringPlugin", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public StringBuilder Insert(int index, string value) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 34)]
	private void Insert(int index, Char* value, int valueCount) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 26)]
	public StringBuilder Insert(int index, Char[] value, int startIndex, int charCount) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private StringBuilder Next(StringBuilder chunk) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(System.Span`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

	[CalledBy(Type = "Manager.Localization", Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "DG.Tweening.Plugins.StringPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.StringOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<String>", "DG.Tweening.Core.DOSetter`1<String>", typeof(float), typeof(string), typeof(string), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.QrCode.Internal.DecodedBitStreamParser", Member = "decodeAlphanumericSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Common.BitSource", typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.OneD.Code93Reader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "ZXing.OneD.Code128Reader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "ZXing.OneD.CodaBarReader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.EdifactEncoder", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.C40Encoder", Member = "backtrackOneCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext", typeof(StringBuilder), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.C40Encoder", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.C40Encoder", Member = "writeNextTriplet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext", typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "Card.Template", Member = "BuildCardDescription", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Deck", Member = "get_Tags", ReturnType = typeof(string))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "MergeArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]", typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ClientAPI.WebServer", Member = "GetB64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]", typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(System.Span`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public StringBuilder Remove(int startIndex, int length) { }

	[CalledBy(Type = typeof(SecurityElement), Member = "Unescape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorStringByProfanityList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.Generic.List`1<String>", typeof(StringBuilder), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "FilterSwearListForCompleteWordsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<String>"}, ReturnType = "System.Collections.Generic.List`1<String>")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	public StringBuilder Replace(string oldValue, string newValue) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "MakeRoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(StringBuilder&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ReplaceInPlaceAtChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(Int32&), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(StringBuilder&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ReplaceAllInChunk(Int32[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "ReplaceAllInChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, Char* value, int count) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "FixupName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Normalization), Member = "ReorderCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringBuilder&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "FixupPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Normalization), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Normalization), Member = "CombineHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "ToStringClass", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Normalization), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.Base256Encoder", Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Datamatrix.Encoder.EncoderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Datamatrix.Encoder.ErrorCorrection", Member = "encodeECC200", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "ZXing.Datamatrix.Encoder.SymbolInfo"}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.OneD.CodaBarReader", Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ZXing.Common.BitArray", "System.Collections.Generic.IDictionary`2<DecodeHintType, Object>"}, ReturnType = "ZXing.Result")]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorStringByProfanityList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.Generic.List`1<String>", typeof(StringBuilder), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "FilterSwearListForCompleteWordsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<String>"}, ReturnType = "System.Collections.Generic.List`1<String>")]
	[CalledBy(Type = "System.Xml.Schema.XsdDuration", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDuration+DurationType"}, ReturnType = typeof(string))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void set_Chars(int index, char value) { }

	[CallerCount(Count = 81)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void ThreadSafeCopy(Char* sourcePtr, Char[] destination, int destinationIndex, int count) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(StringBuilder&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private static void ThreadSafeCopy(Char[] source, int sourceIndex, Span<Char> destination, int destinationIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(StringBuilder), Member = "AppendCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	public string ToString(int startIndex, int length) { }

}

