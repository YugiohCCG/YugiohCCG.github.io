namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable
{
	private static readonly double s_SQLTicksPerMillisecond; //Field offset: 0x0
	public static readonly int SQLTicksPerSecond; //Field offset: 0x8
	public static readonly int SQLTicksPerMinute; //Field offset: 0xC
	public static readonly int SQLTicksPerHour; //Field offset: 0x10
	private static readonly int s_SQLTicksPerDay; //Field offset: 0x14
	private static readonly long s_ticksPerSecond; //Field offset: 0x18
	private static readonly DateTime s_SQLBaseDate; //Field offset: 0x20
	private static readonly long s_SQLBaseDateTicks; //Field offset: 0x28
	private static readonly int s_minYear; //Field offset: 0x30
	private static readonly int s_maxYear; //Field offset: 0x34
	private static readonly int s_minDay; //Field offset: 0x38
	private static readonly int s_maxDay; //Field offset: 0x3C
	private static readonly int s_minTime; //Field offset: 0x40
	private static readonly int s_maxTime; //Field offset: 0x44
	private static readonly int s_dayBase; //Field offset: 0x48
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x50
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x58
	private static readonly DateTime s_minDateTime; //Field offset: 0x60
	private static readonly DateTime s_maxDateTime; //Field offset: 0x68
	private static readonly TimeSpan s_minTimeSpan; //Field offset: 0x70
	private static readonly TimeSpan s_maxTimeSpan; //Field offset: 0x78
	private static readonly string s_ISO8601_DateTimeFormat; //Field offset: 0x80
	private static readonly String[] s_dateTimeFormats; //Field offset: 0x88
	public static readonly SqlDateTime MinValue; //Field offset: 0x90
	public static readonly SqlDateTime MaxValue; //Field offset: 0x9C
	public static readonly SqlDateTime Null; //Field offset: 0xA8
	private bool m_fNotNull; //Field offset: 0x0
	private int m_day; //Field offset: 0x4
	private int m_time; //Field offset: 0x8

	public int DayTicks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 83
	}

	public override bool IsNull
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int TimeTicks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 83
	}

	public DateTime Value
	{
		[CalledBy(Type = typeof(SqlDateTime), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SqlDateTime), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 164
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(SqlDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private static SqlDateTime() { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(SqlDateTime))]
	[CalledBy(Type = typeof(SqlDateTime), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLResource), Member = "get_DateTimeOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public SqlDateTime(int dayTicks, int timeTicks) { }

	[CallerCount(Count = 0)]
	private SqlDateTime(bool fNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDateTime), Member = "FromDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SqlDateTime))]
	public SqlDateTime(DateTime value) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDateTimeStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDateTimeStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime), typeof(SqlDateTime)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(SqlBoolean), Member = "op_True", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime), typeof(SqlDateTime)}, ReturnType = typeof(SqlBoolean))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlDateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "get_Value", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SqlDateTime))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(SqlDateTime), Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(SqlDateTime))]
	private static SqlDateTime FromDateTime(DateTime value) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "FromDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SqlDateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Days", ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_DateTimeOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_DayTicks() { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_TimeTicks() { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlDateTime), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public DateTime get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDateTime), Member = "get_Value", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlDateTimeStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	[CalledBy(Type = typeof(SqlDateTimeStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlDateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDateTime), Member = "FromDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SqlDateTime))]
	public static SqlDateTime op_Implicit(DateTime value) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(SqlDateTime), Member = "FromDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(SqlDateTime))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_TimeZoneSpecifiedMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDateTime), Member = "get_Value", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "get_Value", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	private static DateTime ToDateTime(SqlDateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDateTime), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

}

