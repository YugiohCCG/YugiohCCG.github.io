namespace System;

[IsReadOnly]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
{
	private const long TicksPerMillisecond = 10000; //Field offset: 0x0
	private const string DateDataField = "dateData"; //Field offset: 0x0
	private const double OADateMinAsDouble = -657435; //Field offset: 0x0
	private const double OADateMaxAsDouble = 2958466; //Field offset: 0x0
	private const int DatePartYear = 0; //Field offset: 0x0
	private const int DatePartDayOfYear = 1; //Field offset: 0x0
	private const int DatePartMonth = 2; //Field offset: 0x0
	private const int DatePartDay = 3; //Field offset: 0x0
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x0
	private const long DoubleDateOffset = 599264352000000000; //Field offset: 0x0
	private const ulong TicksMask = 4611686018427387903; //Field offset: 0x0
	private const ulong LocalMask = 9223372036854775808; //Field offset: 0x0
	private const long TicksCeiling = 4611686018427387904; //Field offset: 0x0
	private const ulong KindUnspecified = 0; //Field offset: 0x0
	private const ulong KindUtc = 4611686018427387904; //Field offset: 0x0
	private const ulong KindLocal = 9223372036854775808; //Field offset: 0x0
	private const ulong KindLocalAmbiguousDst = 13835058055282163712; //Field offset: 0x0
	private const int KindShift = 62; //Field offset: 0x0
	private const string TicksField = "ticks"; //Field offset: 0x0
	private const ulong FlagsMask = 13835058055282163712; //Field offset: 0x0
	private const long FileTimeOffset = 504911232000000000; //Field offset: 0x0
	private const long OADateMinAsTicks = 31241376000000000; //Field offset: 0x0
	private const long MaxMillis = 315537897600000; //Field offset: 0x0
	private const long TicksPerHour = 36000000000; //Field offset: 0x0
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	private const int MillisPerSecond = 1000; //Field offset: 0x0
	private const int MillisPerMinute = 60000; //Field offset: 0x0
	private const int MillisPerHour = 3600000; //Field offset: 0x0
	private const int MillisPerDay = 86400000; //Field offset: 0x0
	private const int DaysPerYear = 365; //Field offset: 0x0
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	internal const long UnixEpochTicks = 621355968000000000; //Field offset: 0x0
	private const long TicksPerMinute = 600000000; //Field offset: 0x0
	private const long TicksPerSecond = 10000000; //Field offset: 0x0
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	private const int DaysTo1601 = 584388; //Field offset: 0x0
	private const int DaysTo1899 = 693593; //Field offset: 0x0
	internal const int DaysTo1970 = 719162; //Field offset: 0x0
	private const int DaysTo10000 = 3652059; //Field offset: 0x0
	internal const long MinTicks = 0; //Field offset: 0x0
	internal const long MaxTicks = 3155378975999999999; //Field offset: 0x0
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x8
	public static readonly DateTime MinValue; //Field offset: 0x10
	public static readonly DateTime MaxValue; //Field offset: 0x18
	public static readonly DateTime UnixEpoch; //Field offset: 0x20
	private readonly ulong _dateData; //Field offset: 0x0

	public DateTime Date
	{
		[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_1", Member = "<_UpdateDisplay>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.SerializableDate"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
		[CalledBy(Type = "Card.Card", Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Card.Card", Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = "Card.Card", Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
		[CalledBy(Type = "Card.Card", Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 22)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 120
	}

	public int Day
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Day", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Manager.Packet", Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "Manager.Packet", Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(ushort))]
		[CalledBy(Type = "Manager.Packet", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DateTime), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 79
	}

	public DayOfWeek DayOfWeek
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 134
	}

	public int Hour
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Hour", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
		[CallerCount(Count = 21)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 139
	}

	private ulong InternalKind
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 17
	}

	internal long InternalTicks
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 17
	}

	public DateTimeKind Kind
	{
		[CallerCount(Count = 50)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 110
	}

	public int Millisecond
	{
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "SqlDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 140
	}

	public int Minute
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Minute", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 140
	}

	public int Month
	{
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 79
	}

	public static DateTime Now
	{
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 386
	}

	public int Second
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Second", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 140
	}

	public long Ticks
	{
		[CallerCount(Count = 120)]
		 get { } //Length: 80
	}

	public TimeSpan TimeOfDay
	{
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 98
	}

	public static DateTime Today
	{
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "get_VisibleDate", ReturnType = "UI.Dates.SerializableDate")]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "UI.Dates.DatePickerDayButtonType")]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), "UnityEngine.Transform"}, ReturnType = "UnityEngine.GameObject")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 173
	}

	public static DateTime UtcNow
	{
		[CallerCount(Count = 73)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 89
	}

	public int Year
	{
		[CallerCount(Count = 70)]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 76
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static DateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private DateTime(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = "TryGetDateFromConstructorJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(DateTime&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DosTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTime(long ticks) { }

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	public DateTime(int year, int month, int day) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "Newtonsoft.Json.DateTimeZoneHandling"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "Newtonsoft.Json.DateTimeZoneHandling"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeKind)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public DateTime(long ticks, DateTimeKind kind) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	private DateTime(ulong dateData) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime+Parser"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XsdDateTimeFlags", "System.Xml.Schema.XsdDateTime&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = "System.IO.Compression.ZipArchiveEntry")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	public DateTime(int year, int month, int day, int hour, int minute, int second) { }

	[CalledBy(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private DateTime Add(double value, int scale) { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "SqlDateTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlDateTime"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	public DateTime Add(TimeSpan value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "DateFallsWithinMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Calendar), Member = "GetWeekOfYearFullDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	public DateTime AddDays(double value) { }

	[CalledBy(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	public DateTime AddMilliseconds(double value) { }

	[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundStartTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundTimeLeft", ReturnType = typeof(double))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	public DateTime AddMinutes(double value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "ShowPreviousMonth", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "ShowNextMonth", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Packet", Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public DateTime AddMonths(int months) { }

	[CalledBy(Type = "Mono.Nat.Mapping", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Protocol", typeof(int), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<>c", Member = "<StartAuth>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound", Member = "DefineTimeForNextTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Tournament", Member = "get_RoundEndTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundStartTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Data.Tournament", Member = "get_NextRoundTimeLeft", ReturnType = typeof(double))]
	[CalledBy(Type = "Data.Tournament", Member = "get_RoundTimeLeft", ReturnType = typeof(double))]
	[CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	public DateTime AddSeconds(double value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XsdDateTimeFlags", "System.Xml.Schema.XsdDateTime&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime+Parser"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "CreateDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.Utilities.DateTimeParser"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "DateFallsWithinMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTime AddTicks(long value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "ShowPreviousYear", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "ShowNextYear", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Packet", Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Manager.Packet", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTime AddYears(int value) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static int Compare(DateTime t1, DateTime t2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "DateFallsWithinMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePickerDateRangeConfig", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[ContainsInvalidInstructions]
	public override int CompareTo(DateTime value) { }

	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static long DateToTicks(int year, int month, int day) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "DateFallsWithinMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeParser", Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime+Parser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime+Parser", Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeParser", Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static int DaysInMonth(int year, int month) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "UI.Dates.DatePickerDayButtonType")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "IsMinMaxDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "DateSortRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(long))]
	[CallerCount(Count = 20)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(DateTime value) { }

	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static DateTime FromBinary(long dateData) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static DateTime FromBinaryRaw(long dateData) { }

	[CalledBy(Type = "UnityEngine.Windows.Speech.PhraseRecognizer", Member = "InvokePhraseRecognizedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "UnityEngine.Windows.Speech.ConfidenceLevel", "UnityEngine.Windows.Speech.SemanticMeaning[]", typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static DateTime FromFileTime(long fileTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static DateTime FromFileTimeUtc(long fileTime) { }

	[CalledBy(Type = "UI.Dates.DatePicker+<>c__DisplayClass70_1", Member = "<_UpdateDisplay>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.SerializableDate"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = "Card.Card", Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Card.Card", Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Card", Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Card", Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 22)]
	[ContainsUnimplementedInstructions]
	public DateTime get_Date() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Packet", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(DateTime), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Packet", Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "Manager.Packet", Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Day() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	public DayOfWeek get_DayOfWeek() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Hour", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 21)]
	[ContainsUnimplementedInstructions]
	public int get_Hour() { }

	[CallerCount(Count = 0)]
	private ulong get_InternalKind() { }

	[CallerCount(Count = 0)]
	internal long get_InternalTicks() { }

	[CallerCount(Count = 50)]
	[ContainsUnimplementedInstructions]
	public DateTimeKind get_Kind() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "SqlDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public int get_Millisecond() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Minute", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public int get_Minute() { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Month() { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	public static DateTime get_Now() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDefaultIsoDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Second", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.ZipHelper", Member = "DateTimeToDosTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public int get_Second() { }

	[CallerCount(Count = 120)]
	public long get_Ticks() { }

	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public TimeSpan get_TimeOfDay() { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "get_VisibleDate", ReturnType = "UI.Dates.SerializableDate")]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayTypeForDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "UI.Dates.DatePickerDayButtonType")]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), "UnityEngine.Transform"}, ReturnType = "UnityEngine.GameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public static DateTime get_Today() { }

	[CallerCount(Count = 73)]
	[CallsUnknownMethods(Count = 1)]
	public static DateTime get_UtcNow() { }

	[CallerCount(Count = 70)]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Year() { }

	[CalledBy(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void GetDatePart(out int year, out int month, out int day) { }

	[CalledBy(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int GetDatePart(int part) { }

	[CalledBy(Type = typeof(AdjustmentRule), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static long GetSystemTimeAsFileTime() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsAmbiguousDaylightSavingTime() { }

	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool IsLeapYear(int year) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), "System.String[]", typeof(string), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HostEntry", ReturnType = "System.Net.IPHostEntry")]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILease)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lease), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Data.RoomData", Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Card", Member = "get_HasTCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Card", Member = "get_HasOCGRelease", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Deck", Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Banlist", typeof(byte), typeof(DateTime), typeof(DateTime), "Enumerator.DuelRules", "Enumerator.ExtraRules", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Certificate"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation"}, ReturnType = "System.Net.WebConnection")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_IsCurrent", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "EnableButtonsForUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(DateTime), "System.Nullable`1<TimeSpan>", typeof(DateTimeKind), "Newtonsoft.Json.DateFormatHandling"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	[CallerCount(Count = 29)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", "System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = typeof(Calendar), Member = "GetWeekOfYearFullDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Certificate"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Card", Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ClientAPI.Packs", "ClientAPI.Relations"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Card", Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Card.Card", Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Data.RoomData", Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "GetDateRangeForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Collections.Generic.List`1<DateTime>")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_IsCurrent", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	[CallerCount(Count = 30)]
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.ConstNode", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Data.ValueType", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime Parse(string s, IFormatProvider provider) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__DisplayClass0_0`1", Member = "<GetFastSetter>b__8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime Parse(string s) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	[CalledBy(Type = "UI.Dates.DatePicker_InputField", Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.SerializableDate"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.SerializableDate", Member = "get_Date", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.String[]"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static DateTime ParseExact(string s, String[] formats, IFormatProvider provider, DateTimeStyles style) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", "Newtonsoft.Json.DateTimeZoneHandling", typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "SetStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "SetStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "FromDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "System.Data.SqlTypes.SqlDateTime")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public TimeSpan Subtract(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TimeSpan), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static long TimeToTicks(int hour, int minute, int second) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal long ToBinaryRaw() { }

	[CalledBy(Type = "Scenes.Menu.ReplayList", Member = "OnClickExportAll", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToFileTimeUtc", ReturnType = typeof(long))]
	public long ToFileTime() { }

	[CalledBy(Type = "Data.CustomTheme+<SaveToDisk>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "ToFileTime", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToFileTime", ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public long ToFileTimeUtc() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	public DateTime ToLocalTime() { }

	[CalledBy(Type = typeof(DateTime), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToShortDateString() { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToShortTimeString() { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<DateTime>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.MemoryTraceWriter", Member = "Trace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceLevel", typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTime), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemoryStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlCustomFormatter", Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "SqlSmallDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(ushort)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "SqlDateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", "Data.Banlist"}, ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "ClickOnHostSettingSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "OnTextFieldValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerUtilities", Member = "ToDateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UI.Dates.DatePicker_InputField", Member = "set_SelectedDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.SerializableDate"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_InputField", Member = "UpdateInputFieldText", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "Extensions.RoomCard"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<BackupPlayerData>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network", Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

	[CalledBy(Type = "UI.Dates.SerializableDate", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "CopyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(BitArray), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.JavaScriptDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "Newtonsoft.Json.DateTimeZoneHandling"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "Newtonsoft.Json.DateTimeZoneHandling"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "TicksFromDateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	public DateTime ToUniversalTime() { }

	[CalledBy(Type = typeof(GregorianCalendar), Member = "TryToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 2)]
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Nullable`1<DateTime>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__DisplayClass0_0`1", Member = "<GetFastSetter>b__8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.DateTimeUtils", Member = "TryParseDateTimeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.DerSequenceReader+DerTag", typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.DateTimeZoneHandling", typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

}

