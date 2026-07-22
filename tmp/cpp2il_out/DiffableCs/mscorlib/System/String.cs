namespace System;

[DefaultMember("Chars")]
public sealed class string : IComparable, IEnumerable, IEnumerable<Char>, IComparable<String>, IEquatable<String>, IConvertible, ICloneable
{
	private struct ProbabilisticMap
	{

	}

	private enum TrimType
	{
		Head = 0,
		Tail = 1,
		Both = 2,
	}

	private const int StackallocIntBufferSizeLimit = 128; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3; //Field offset: 0x0
	private const int PROBABILISTICMAP_SIZE = 8; //Field offset: 0x0
	public static readonly string Empty; //Field offset: 0x0
	private int _stringLength; //Field offset: 0x10
	private char _firstChar; //Field offset: 0x14

	public char Chars
	{
		[CallerCount(Count = 2105)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[Intrinsic]
		 get { } //Length: 66
	}

	public int Length
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public String(ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public String(Char[] value, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public String(Char* value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public String(char c, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public String(Char* value, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public String(SByte* value, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public String(SByte* value, int startIndex, int length, Encoding enc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public String(Char[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ArrayContains(char searchChar, Char[] anyOf) { }

	[CallerCount(Count = 0)]
	internal static void bzero(Byte* dest, int len) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static void bzero_aligned_1(Byte* dest, int len) { }

	[CallerCount(Count = 0)]
	internal static void bzero_aligned_2(Byte* dest, int len) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static void bzero_aligned_4(Byte* dest, int len) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static void bzero_aligned_8(Byte* dest, int len) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	internal static void CheckStringComparison(StringComparison comparisonType) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override object Clone() { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap", Member = "FindActionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	[CallerCount(Count = 101)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	[CalledBy(Type = "System.Net.HttpListener", Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.HttpListenerContext")]
	[CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.AuthenticationSchemes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize", typeof(Int32&), "System.Net.ReadState&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int Compare(string strA, string strB) { }

	[CalledBy(Type = "MS.Internal.Xml.XPath.StringFunctions", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XPath.XPathNodeIterator"}, ReturnType = typeof(object))]
	[CalledBy(Type = "MS.Internal.Xml.XPath.StringFunctions", Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XPath.XPathNodeIterator"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexBoyerMoore", Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1+XHashtableState", Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "System.Xml.Linq.XNamespace")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal static int CompareOrdinal(ReadOnlySpan<Char> strA, ReadOnlySpan<Char> strB) { }

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	public static int CompareOrdinal(string strA, string strB) { }

	[CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override int CompareTo(string strB) { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static string Concat(Object[] args) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static string Concat(object arg0, object arg1, object arg2) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public static string Concat(IEnumerable<String> values) { }

	[CallerCount(Count = 1399)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static string Concat(string str0, string str1) { }

	[CallerCount(Count = 801)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsInvalidInstructions]
	public static string Concat(string str0, string str1, string str2) { }

	[CallerCount(Count = 149)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public static string Concat(string str0, string str1, string str2, string str3) { }

	[CallerCount(Count = 187)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public static string Concat(String[] values) { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string Concat(object arg0, object arg1) { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	public bool Contains(string value) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public bool Contains(char value) { }

	[CalledBy(Type = "Manager.Sound+<>c__DisplayClass43_0", Member = "<EnumerateBGM>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Layouts.InputDeviceDescription"}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "MatchSinglePropertyContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public bool Contains(string value, StringComparison comparisonType) { }

	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CADMethodCallMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static string Copy(string str) { }

	[CalledBy(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFile", Member = "EntryFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "System.Char[]&", typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.ExpressionParser", Member = "LoadExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataExpression", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.LikeNode", Member = "AnalyzePattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = "WriteEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), "System.Boolean[]", "Newtonsoft.Json.StringEscapeHandling", "Newtonsoft.Json.IArrayPool`1<Char>", "System.Char[]&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", typeof(string), "System.UriFormat"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(Int32&), "System.UriFormat"}, ReturnType = "System.Char[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime), "System.Nullable`1<TimeSpan>", typeof(DateTimeKind), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl+NodeData", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Char[]", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlTextEncoder", Member = "WriteStringFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "System.Char[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextEncoder", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.File+<InternalWriteAllTextAsync>d__81", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.StreamWriter+<WriteAsyncInternal>d__59", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UriComponents", typeof(ushort), "System.UriFormat"}, ReturnType = typeof(string))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	public void CopyTo(int sourceIndex, Char[] destination, int destinationIndex, int count) { }

	[CalledBy(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static string Create(int length, TState state, SpanAction<Char, TState> action) { }

	[CalledBy(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(char), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(char), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(char), Member = "ConvertFromUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal static string CreateFromChar(char c) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	private string CreateString(Char* value, int startIndex, int length) { }

	[CalledBy(Type = typeof(TIME_DYNAMIC_ZONE_INFORMATION), Member = "GetTimeZoneKeyName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetDaylightName", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Windows.Speech.PhraseRecognizer", Member = "MarshalSemanticMeaning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(int)}, ReturnType = "UnityEngine.Windows.Speech.SemanticMeaning[]")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private string CreateString(Char* value) { }

	[CallerCount(Count = 102)]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	private string CreateString(Char[] val, int startIndex, int length) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private string CreateString(Char[] val) { }

	[CalledBy(Type = typeof(Tokenizer), Member = "ChangeFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SignatureArrayType), Member = "get_Suffix", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+Token", "System.Xml.DtdParser+Token", typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "SetIndentChars", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.NotBurstCompatible.Extensions", Member = "ReadNextNBC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Reader&", typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Indent", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "Dedent", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "EmitExits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private string CreateString(char c, int count) { }

	[CalledBy(Type = typeof(RuntimeMarshal), Member = "PtrToUtf8String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderBitArray", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetText", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	private string CreateString(SByte* value, int startIndex, int length, Encoding enc) { }

	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(char), typeof(int), typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IPv6AddressHelper", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Char>", "System.UInt16*", typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IPv4AddressHelper", Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileSystemEntry&)}, ReturnType = typeof(FileSystemInfo))]
	[CalledBy(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CompareInfo), Member = "CompareString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "CompareString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CompareInfo), Member = "CompareOptionIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string CreateString(ReadOnlySpan<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	private string CreateString(SByte* value, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string CreateStringForSByteConstructor(Byte* pb, int numBytes) { }

	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(EncodingNLS), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static string CreateStringFromEncoding(Byte* bytes, int byteLength, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private string CreateTrimmedString(int start, int end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static string Ctor(Char[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static string Ctor(char c, int count) { }

	[CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	private static string Ctor(SByte* value, int startIndex, int length, Encoding enc) { }

	[CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	private static string Ctor(SByte* value, int startIndex, int length) { }

	[CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	private static string Ctor(Char* ptr, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static string Ctor(Char* ptr) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNamesCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	private static string Ctor(Char[] value, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string Ctor(ReadOnlySpan<Char> value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ExceptionUtils", Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.IJsonLineInfo", typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool EndsWith(char value) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool EndsWith(string value) { }

	[CallerCount(Count = 25)]
	[ContainsInvalidInstructions]
	public bool EndsWith(string value, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 236)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	public override bool Equals(string value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "PanelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", "System.Linq.Expressions.Expression[]", typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "Newtonsoft.Json.DefaultJsonNameTable", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = "UnityEngine.Rendering.DebugUI+Panel")]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionSetupExtensions", Member = "ChangeCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction", typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputActionSetupExtensions+BindingSyntax")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionSetupExtensions+BindingSyntax", Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputActionSetupExtensions+BindingSyntax")]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.StringHelpers", Member = "MakeUniqueName", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TExisting"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<TExisting>", "System.Func`2<TExisting, String>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+RebindingOperation+<>c__DisplayClass32_0", Member = "<WithTargetBinding>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControlScheme"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.BanlistManager", Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.SQLiteConnectionString", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "SQLite.SQLiteOpenFlags", typeof(bool), typeof(object), "System.Action`1<SQLiteConnection>", "System.Action`1<SQLiteConnection>", typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionSetupExtensions+BindingSyntax", Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputActionSetupExtensions+BindingSyntax")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public bool Equals(string value, StringComparison comparisonType) { }

	[CallerCount(Count = 2260)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public static bool Equals(string a, string b) { }

	[CallerCount(Count = 206)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool EqualsHelper(string strA, string strB) { }

	[CalledBy(Type = typeof(string), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TState", "System.Buffers.SpanAction`2<Char, TState>"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParseNumbers), Member = "LongToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParseNumbers), Member = "IntToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "UInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "NegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "UInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "Int32ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "NegativeInt32ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(Base64FormattingOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "Int64ToHexStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	internal static string FastAllocateString(int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void FillStringChecked(string dest, int destPos, string src) { }

	[CallerCount(Count = 607)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(string format, object arg0) { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static string Format(IFormatProvider provider, string format, Object[] args) { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	[CallerCount(Count = 180)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	[CallerCount(Count = 320)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static string Format(string format, Object[] args) { }

	[CallerCount(Count = 162)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	[CallerCount(Count = 465)]
	[Calls(Type = typeof(ParamsArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static string Format(string format, object arg0, object arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[CallerCount(Count = 2105)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Intrinsic]
	public char get_Chars(int index) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int GetLegacyNonRandomizedHashCode() { }

	[CallerCount(Count = 426)]
	internal char GetRawStringData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int IndexOf(string value) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int IndexOf(string value, StringComparison comparisonType) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "FilenameInputToFileEntryIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public int IndexOf(string value, int startIndex, int count) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.TypeTranslator", Member = "ParseArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.X509PalImpl", Member = "PEM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.X509PalImpl", Member = "ConvertData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ResponseDescription", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.ResultParser", Member = "matchPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = "System.String[]")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "PEM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Byte[]"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int IndexOf(string value, int startIndex) { }

	[CallerCount(Count = 160)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOf(char value) { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOf(char value, int startIndex) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath", Member = "PathComponentCanYieldMultipleMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CookieVariant", "System.Uri", typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ListenerPrefix", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ListenerPrefix", Member = "CheckUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public int IndexOf(char value, int startIndex, int count) { }

	[CalledBy(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	[CallerCount(Count = 0)]
	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	[CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsUtils", Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "Mono.Btls.MonoBtlsX509Name", typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "Mono.Security.ASN1", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public int IndexOfAny(Char[] anyOf, int startIndex, int count) { }

	[CalledBy(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "FindNextWordBegin", ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "FindtNextWordBegin", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "MoveRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOfAny(Char[] anyOf, int startIndex) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int IndexOfAny(Char[] anyOf) { }

	[CallerCount(Count = 0)]
	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int IndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(CompareOptions), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinalCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "IndexOfCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions), typeof(Int32*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinalCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	[CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "IndexOfCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOfCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void InitializeProbabilisticMap(UInt32* charMap, ReadOnlySpan<Char> anyOf) { }

	[CalledBy(Type = typeof(PathInternal), Member = "EnsureExtendedPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(Int32&), "System.UriFormat"}, ReturnType = "System.Char[]")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public string Insert(int startIndex, string value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+Cache", Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceBuilder", Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Layouts.InputControlLayout", "UnityEngine.InputSystem.Utilities.InternedString", "UnityEngine.InputSystem.InputControl", typeof(Boolean&), "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem", typeof(int), typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.InternedString", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string Intern(string str) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string InternalIntern(string str) { }

	[CalledBy(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private string InternalSubString(int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsCharBitSet(UInt32* charMap, byte value) { }

	[CallerCount(Count = 1160)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	public static bool IsNullOrEmpty(string value) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ExecuteConsoleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "ContainsProfanity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.PropertyPath", Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Unity.Properties.PropertyPath")]
	[CalledBy(Type = "Unity.Burst.BurstString", Member = "ParseFormatToFormatOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Unity.Burst.BurstString+FormatOptions")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultDragAndDropClient", Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StartDragArgs", "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingResult&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "AddSpacesToSentence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnSaveNewButton>d__371", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnSaveButton>d__372", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "RetypeInput", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "set_LastInputSent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization", Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	public static bool IsNullOrWhiteSpace(string value) { }

	[CalledBy(Type = "SQLite.SQLiteConnection", Member = "SetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "ContainsProfanity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Serialization.JsonObjectContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>", typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateEndObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaNode", Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<JsonSchema>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputDevice", Member = "DumpControlTree", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputDevice", Member = "DumpControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.InputSystem.InputDevice+ControlBitRangeNode", typeof(uint), typeof(uint), "System.Collections.Generic.List`1<String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBinding", Member = "MaskByGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = "UnityEngine.InputSystem.InputBinding")]
	[CalledBy(Type = "Unity.Collections.CollectionExtensions", Member = "SerializedView", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Func`2<T, String>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public static string Join(string separator, IEnumerable<String> values) { }

	[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize", typeof(Int32&), "System.Net.ReadState&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string Join(string separator, String[] value, int startIndex, int count) { }

	[CalledBy(Type = "Unity.Hierarchy.HierarchySearchQueryDescriptor", Member = "BuildFilterQuery", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchySearchQueryDescriptor", Member = "BuildSystemFilterQuery", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchySearchQueryDescriptor", Member = "BuildQuery", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "JoinCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static string Join(string separator, IEnumerable<T> values) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string Join(string separator, String[] value) { }

	[CalledBy(Type = "Card.TextDataManager", Member = "ParseConfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "JoinCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static string Join(char separator, IEnumerable<T> values) { }

	[CalledBy(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "Unity.Hierarchy.HierarchySearchFilter", Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	private static string JoinCore(Char* separator, int separatorLength, IEnumerable<T> values) { }

	[CalledBy(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	private static string JoinCore(Char* separator, int separatorLength, String[] value, int startIndex, int count) { }

	[CalledBy(Type = "Extensions.General", Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Extensions.General", Member = "ReplaceLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Serialization.TypeTranslator", Member = "ParseArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int LastIndexOf(string value) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(SpanHelpers), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	public int LastIndexOf(char value) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.CookieContainer", Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri"}, ReturnType = "System.Net.CookieCollection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int LastIndexOf(char value, int startIndex) { }

	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpanHelpers), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public int LastIndexOf(char value, int startIndex, int count) { }

	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "SplitName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	[CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public int LastIndexOfAny(Char[] anyOf, int startIndex, int count) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "FindPrevWordBegin", ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "FindtPrevWordBegin", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "MoveLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int LastIndexOfAny(Char[] anyOf, int startIndex) { }

	[CalledBy(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "findExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int LastIndexOfAny(Char[] anyOf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int LastIndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(CompareOptions), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinalCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinalCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void MakeSeparatorList(string separator, ref ValueListBuilder<Int32>& sepListBuilder) { }

	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	private void MakeSeparatorList(ReadOnlySpan<Char> separators, ref ValueListBuilder<Int32>& sepListBuilder) { }

	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void MakeSeparatorList(String[] separators, ref ValueListBuilder<Int32>& sepListBuilder, ref ValueListBuilder<Int32>& lengthListBuilder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	private static void memcpy(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static void memcpy_aligned_1(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static void memcpy_aligned_2(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static void memcpy_aligned_4(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal static void memcpy_aligned_8(Byte* dest, Byte* src, int size) { }

	[CallerCount(Count = 0)]
	private static void memset(Byte* dest, int val, int len) { }

	[CalledBy(Type = typeof(IdnMapping), Member = "NamePrep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(ushort), typeof(ushort), "System.ParsingError&", "Flags&", "System.UriParser", typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), "System.UriParser", typeof(string), "Flags&", typeof(Boolean&), typeof(String&), "System.ParsingError&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), typeof(bool), typeof(bool), "System.UriParser", "Flags&", typeof(String&), "System.ParsingError&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Uri", Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ParsingError", "System.UriKind", "System.UriFormatException&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Normalization), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NormalizationForm)}, ReturnType = typeof(string))]
	public string Normalize(NormalizationForm normalizationForm) { }

	[CallerCount(Count = 2260)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public static bool op_Equality(string a, string b) { }

	[CallerCount(Count = 0)]
	public static ReadOnlySpan<Char> op_Implicit(string value) { }

	[CallerCount(Count = 355)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(string a, string b) { }

	[CalledBy(Type = "UnityEngine.UIElements.ToggleButtonGroupState", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string PadLeft(int totalWidth, char paddingChar) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexFCD", Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.RegexTree"}, ReturnType = "System.Text.RegularExpressions.RegexPrefix")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string PadRight(int totalWidth, char paddingChar) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public string Remove(int startIndex, int count) { }

	[CalledBy(Type = "Manager.Updater", Member = "set_UpdateServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+TypeData", Member = "get_typeName", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public string Remove(int startIndex) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string Replace(char oldChar, char newChar) { }

	[CallerCount(Count = 153)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public string Replace(string oldValue, string newValue) { }

	[CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<Int32> indices) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static void SetCharBit(UInt32* charMap, byte value) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListener", Member = "EndGetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.HttpListenerContext")]
	[CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.AuthenticationSchemes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerRequest", Member = "SetRequestLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	public String[] Split(Char[] separator, int count) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	public String[] Split(Char[] separator) { }

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	public String[] Split(char separator, StringSplitOptions options = 0) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ArabicSupport.ArabicFixer", Member = "Fix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Deck+<ParseYDK>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X500DistinguishedName", "System.Security.Cryptography.X509Certificates.X500DistinguishedName"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	public String[] Split(String[] separator, StringSplitOptions options) { }

	[CalledBy(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.String[]")]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaBuilder", Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchema")]
	[CalledBy(Type = "Unity.Burst.BurstString", Member = "OptsSplit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment+Hierarchy", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Loaders.MoFileParser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = "NGettext.Loaders.MoFile")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	public String[] Split(Char[] separator, StringSplitOptions options) { }

	[CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private String[] SplitInternal(ReadOnlySpan<Char> separators, int count, StringSplitOptions options) { }

	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private String[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	[CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(ValueListBuilder`1<Int32>&), typeof(ValueListBuilder`1<Int32>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.ReadOnlySpan`1<System.Int32>), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private String[] SplitInternal(string separator, String[] separators, int count, StringSplitOptions options) { }

	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private String[] SplitKeepEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private String[] SplitOmitEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playSelected|43_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass33_0", Member = "<UpdateReplayList>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "PooledScrollList.Data.IPooledData")]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass36_0", Member = "<OnClickRename>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "IsClientReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "IsServerReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "GetNewPathForReplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "GetSelectedReplayPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.TextDataManager", Member = "ParseConfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Plugins.DeepLink", Member = "ParseArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = "System.Collections.Generic.Dictionary`2<String, String>")]
	[CalledBy(Type = "Plugins.DeepLink", Member = "ParseArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Collections.Generic.Dictionary`2<String, String>")]
	[CalledBy(Type = "Plugins.DeepLink", Member = "OnDeepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.BanlistManager", Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.CopyableCardText", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	public bool StartsWith(char value) { }

	[CallerCount(Count = 71)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public bool StartsWith(string value, StringComparison comparisonType) { }

	[CallerCount(Count = 138)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool StartsWith(string value) { }

	[CalledBy(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool StartsWithOrdinalUnchecked(string value) { }

	[CallerCount(Count = 429)]
	[Calls(Type = typeof(string), Member = "InternalSubString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	public string Substring(int startIndex, int length) { }

	[CallerCount(Count = 186)]
	[ContainsInvalidInstructions]
	public string Substring(int startIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override IEnumerator<Char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(char))]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Char[] ToCharArray() { }

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string ToLower() { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public string ToLower(CultureInfo culture) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string ToLowerInvariant() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "System.Xml.Serialization.CodeIdentifier", Member = "MakePascal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaDatatype", Member = "XdrCanonizeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlNameTable", "System.Xml.Schema.SchemaNames"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.ToolboxItemAttribute", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ToolboxItemAttribute", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.EditorAttribute", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpMethodInfo", Member = "GetMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Net.FtpMethodInfo")]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "GetAttributeFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Mono.Security.X509.X520+AttributeTypeAndValue")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "PasswordToKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "PasswordToKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = "GetBytes", ReturnType = "System.Byte[]")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public string ToUpper(CultureInfo culture) { }

	[CalledBy(Type = "Card.Template", Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Common.CharacterSetECI", Member = "getCharacterSetECIByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "ZXing.Common.CharacterSetECI")]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequest", Member = "set_method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string ToUpper() { }

	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegionInfo), Member = "GetByTerritory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSettings", Member = "SetInternalFeatureFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSettings", Member = "IsFeatureEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSettings", Member = "CompareFeatureFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputSettings", "UnityEngine.InputSystem.InputSettings", typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSettings", Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputSettings", "UnityEngine.InputSystem.InputSettings"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_Method", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message", typeof(string), typeof(string), typeof(string)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string ToUpperInvariant() { }

	[CallerCount(Count = 136)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrimType)}, ReturnType = typeof(string))]
	public string Trim() { }

	[CalledBy(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string Trim(char trimChar) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Net.ListenerPrefix", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebHeaderCollection", Member = "CheckBadChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", "System.Uri", typeof(String&), typeof(Boolean&), "System.UriFormatException&"}, ReturnType = "System.Uri")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Uri&"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Uri")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrimType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(TrimType)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string Trim(Char[] trimChars) { }

	[CalledBy(Type = "UnityEngine.Rendering.BitArray16", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray32", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray64", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray128", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray256", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "PreFormatExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string TrimEnd(char trimChar) { }

	[CalledBy(Type = "Manager.Updater+<GetHash>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "ParseMD5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "ParseMenuName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlString", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrimType)}, ReturnType = typeof(string))]
	public string TrimEnd() { }

	[CalledBy(Type = typeof(MethodBase), Member = "ConstructParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[]), typeof(CallingConventions), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "FormatParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(ParameterInfo[]), typeof(CallingConventions), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimStringEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.FtpWebRequest"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParsePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<PathFilter>", typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.LikeNode", Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlElement", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(TrimType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrimType)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string TrimEnd(Char[] trimChars) { }

	[CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private string TrimHelper(Char* trimChars, int trimCharsLength, TrimType trimType) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "SendRawCommandToCompiler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string TrimStart(char trimChar) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimStringStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaBuilder", Member = "ResolveReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchema")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(TrimType)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public string TrimStart(Char[] trimChars) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Utilities.PrimitiveValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrimType)}, ReturnType = typeof(string))]
	public string TrimStart() { }

	[CalledBy(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimStart", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private string TrimWhiteSpaceHelper(TrimType trimType) { }

	[CalledBy(Type = typeof(Number), Member = "FormatFixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueStringBuilder&), typeof(NumberBuffer&), typeof(int), typeof(int), typeof(NumberFormatInfo), typeof(Int32[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Number), Member = "NumberToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&)}, ReturnType = typeof(double))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static int wcslen(Char* ptr) { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(uint)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal static void wstrcpy(Char* dmem, Char* smem, int charCount) { }

}

