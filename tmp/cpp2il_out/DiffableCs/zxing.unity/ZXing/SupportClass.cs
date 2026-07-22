namespace ZXing;

public static class SupportClass
{

	[CalledBy(Type = typeof(Detector), Member = "extractParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Detector), Member = "getRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public static int bitCount(int n) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(DefaultPlacement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "lookAheadTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HighLevelEncoder), Member = "findMinimums", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(Int32[]), typeof(int), typeof(Byte[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Fill(T[] array, T value) { }

	[CalledBy(Type = typeof(Decoder), Member = "correctBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[])}, ReturnType = typeof(Boolean[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Fill(T[] array, int startIndex, int endIndex, T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public static void GetCharsFromString(string sourceString, int sourceStart, int sourceEnd, Char[] destinationArray, int destinationStart) { }

	[CalledBy(Type = typeof(CodaBarReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T GetValue(IDictionary<DecodeHintType, Object> hints, DecodeHintType hintType, T default) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public static string Join(string separator, IEnumerable<T> values) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public static void SetCapacity(IList<T> vector, int newCapacity) { }

	[CalledBy(Type = typeof(SimpleToken), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static string ToBinaryString(int x) { }

	[CalledBy(Type = typeof(AddressBookAUResultParser), Member = "matchMultipleValuePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(BizcardResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(BizcardResultParser), Member = "buildPhoneNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ResultParser), Member = "matchPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(SMSMMSResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(VCardResultParser), Member = "toPrimaryValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.ICollection`1<System.Collections.Generic.List`1<System.String>>)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(VCardResultParser), Member = "toTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.ICollection`1<System.Collections.Generic.List`1<System.String>>)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static String[] toStringArray(ICollection<String> strings) { }

}

