namespace System;

[IsReadOnly]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	public static readonly DateTimeOffset UnixEpoch; //Field offset: 0x20
	private readonly DateTime _dateTime; //Field offset: 0x0
	private readonly short _offsetMinutes; //Field offset: 0x8

	private DateTime ClockDateTime
	{
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Millisecond", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		private get { } //Length: 508
	}

	public DateTime DateTime
	{
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDateTime", ReturnType = "System.Nullable`1<DateTime>")]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTime>")]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "set_LastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
		[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchiveEntry", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		 get { } //Length: 73
	}

	public int Day
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 179
	}

	public int Hour
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 231
	}

	public DateTime LocalDateTime
	{
		[CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DateTimeOffsetToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		 get { } //Length: 176
	}

	public int Millisecond
	{
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 232
	}

	public int Minute
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 232
	}

	public int Month
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 179
	}

	public static DateTimeOffset Now
	{
		[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		 get { } //Length: 94
	}

	public TimeSpan Offset
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		 get { } //Length: 46
	}

	public int Second
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 232
	}

	public long Ticks
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		 get { } //Length: 172
	}

	public TimeSpan TimeOfDay
	{
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 190
	}

	public DateTime UtcDateTime
	{
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 257
	}

	public static DateTimeOffset UtcNow
	{
		[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 164
	}

	public long UtcTicks
	{
		[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		 get { } //Length: 172
	}

	public int Year
	{
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		 get { } //Length: 176
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	private static DateTimeOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTimeOffset(long ticks, TimeSpan offset) { }

	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", "System.IO.Compression.ZipCentralDirectoryFileHeader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.JavaScriptDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTimeOffset>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToUniversalTime", ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_UtcNow", ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDateTimeOffset", ReturnType = "System.Nullable`1<DateTimeOffset>")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	public DateTimeOffset(DateTime dateTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(int))]
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(DateTimeOffset other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(DateTimeOffset other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(FILE_TIME), Member = "ToDateTimeOffset", ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static DateTimeOffset FromFileTime(long fileTime) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Millisecond", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private DateTime get_ClockDateTime() { }

	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDateTime", ReturnType = "System.Nullable`1<DateTime>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTime>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "set_LastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "WriteCentralDirectoryFileHeader", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = "WriteLocalFileHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "ExtractToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchiveEntry", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	public DateTime get_DateTime() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Day() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public int get_Hour() { }

	[CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DateTimeOffsetToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	public DateTime get_LocalDateTime() { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public int get_Millisecond() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public int get_Minute() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Month() { }

	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.IO.Compression.ZipArchiveEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	public static DateTimeOffset get_Now() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonToken"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.FunctionNode", Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.FunctionId", "System.Object[]", "System.Data.DataRow", "System.Data.DataRowVersion"}, ReturnType = typeof(object))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public TimeSpan get_Offset() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public int get_Second() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	public long get_Ticks() { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public TimeSpan get_TimeOfDay() { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public DateTime get_UtcDateTime() { }

	[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static DateTimeOffset get_UtcNow() { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "BindParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(object), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	public long get_UtcTicks() { }

	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "XsdKatmaiDateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.BinXmlDateTime", Member = "GetFractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDateTimeString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public int get_Year() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	[CalledBy(Type = typeof(File), Member = "SetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetMicrosoft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StringReference", typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.ZipFileExtensions", Member = "DoCreateEntryFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Compression.ZipArchive", typeof(string), typeof(string), "System.Nullable`1<CompressionLevel>"}, ReturnType = "System.IO.Compression.ZipArchiveEntry")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<DateTimeOffset>")]
	[CalledBy(Type = "System.Data.Common.SqlConvert", Member = "ConvertStringToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private override int System.IComparable.CompareTo(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(FileSystem), Member = "SetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToFileTimeUtc", ReturnType = typeof(long))]
	public long ToFileTime() { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), "Newtonsoft.Json.DateFormatHandling", typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	public string ToString(IFormatProvider formatProvider) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.IsoDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.JavaScriptDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.UnixDateTimeConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	public DateTimeOffset ToUniversalTime() { }

	[CalledBy(Type = "Manager.DiscordController+<UpdateRichPresence>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	public long ToUnixTimeSeconds() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Nullable`1<DateTimeOffset>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static short ValidateOffset(TimeSpan offset) { }

	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

