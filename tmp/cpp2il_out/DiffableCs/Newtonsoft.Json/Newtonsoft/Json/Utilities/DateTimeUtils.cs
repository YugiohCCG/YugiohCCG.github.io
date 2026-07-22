namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class DateTimeUtils
{
	internal static readonly long InitialJavaScriptDateTicks; //Field offset: 0x0
	private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK"; //Field offset: 0x0
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	private const int DaysPerYear = 365; //Field offset: 0x0
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	private static readonly Int32[] DaysToMonth365; //Field offset: 0x8
	private static readonly Int32[] DaysToMonth366; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static DateTimeUtils() { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	[CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonWriter+<WriteConstructorDateAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JavaScriptUtils), Member = "TryGetDateFromConstructorJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DateTime&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateFormatHandling), typeof(DateTimeZoneHandling)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 4)]
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static TimeSpan GetUtcOffset(DateTime d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	private static DateTime SwitchToLocalTime(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	private static DateTime SwitchToUtcTime(DateTime value) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 5)]
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	private static long ToUniversalTicks(DateTime dateTime) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReference), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReferenceExtensions), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReferenceExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeParser)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeUtils), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeKind)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReference), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReferenceExtensions), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReferenceExtensions), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeParser)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTimeOffset))]
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringReferenceExtensions), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringReference), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateFormatHandling)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateFormatHandling), typeof(DateTimeZoneHandling)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTime), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(TimeSpan), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ToUniversalTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeUtils), Member = "GetDateValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

}

