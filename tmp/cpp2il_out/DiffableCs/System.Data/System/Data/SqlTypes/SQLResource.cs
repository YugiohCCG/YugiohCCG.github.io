namespace System.Data.SqlTypes;

internal static class SQLResource
{

	internal static string ArithOverflowMessage
	{
		[CallerCount(Count = 78)]
		internal get { } //Length: 44
	}

	internal static string CompareDiffCollationMessage
	{
		[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	internal static string ConcatDiffCollationMessage
	{
		[CalledBy(Type = typeof(SqlString), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(SqlString))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	internal static string ConversionOverflowMessage
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 44
	}

	internal static string DateTimeOverflowMessage
	{
		[CalledBy(Type = typeof(SqlDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SqlDateTime), Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(SqlDateTime))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 44
	}

	internal static string DivideByZeroMessage
	{
		[CalledBy(Type = typeof(SqlByte), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlByte))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "DivByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(SqlDouble), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDouble), typeof(SqlDouble)}, ReturnType = typeof(SqlDouble))]
		[CalledBy(Type = typeof(SqlInt16), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt16), typeof(SqlInt16)}, ReturnType = typeof(SqlInt16))]
		[CalledBy(Type = typeof(SqlInt32), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt32), typeof(SqlInt32)}, ReturnType = typeof(SqlInt32))]
		[CalledBy(Type = typeof(SqlInt64), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64), typeof(SqlInt64)}, ReturnType = typeof(SqlInt64))]
		[CalledBy(Type = typeof(SqlInt64), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64), typeof(SqlInt64)}, ReturnType = typeof(SqlInt64))]
		[CalledBy(Type = typeof(SqlSingle), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlSingle), typeof(SqlSingle)}, ReturnType = typeof(SqlSingle))]
		[CallerCount(Count = 9)]
		internal get { } //Length: 44
	}

	internal static string FormatMessage
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 44
	}

	internal static string InvalidPrecScaleMessage
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "CheckValidPrecScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 44
	}

	internal static string NullString
	{
		[CalledBy(Type = typeof(SqlDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDouble), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlGuid), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlInt16), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlInt32), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlInt64), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlMoney), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlSingle), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlString), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 11)]
		internal get { } //Length: 44
	}

	internal static string NullValueMessage
	{
		[CalledBy(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	internal static string TimeZoneSpecifiedMessage
	{
		[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	internal static string TruncationMessage
	{
		[CalledBy(Type = typeof(SqlTruncateException), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 44
	}

	[CallerCount(Count = 78)]
	internal static string get_ArithOverflowMessage() { }

	[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal static string get_CompareDiffCollationMessage() { }

	[CalledBy(Type = typeof(SqlString), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(SqlString))]
	[CallerCount(Count = 1)]
	internal static string get_ConcatDiffCollationMessage() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
	[CallerCount(Count = 3)]
	internal static string get_ConversionOverflowMessage() { }

	[CalledBy(Type = typeof(SqlDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(SqlDateTime))]
	[CallerCount(Count = 2)]
	internal static string get_DateTimeOverflowMessage() { }

	[CalledBy(Type = typeof(SqlByte), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlByte))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "DivByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(SqlDouble), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDouble), typeof(SqlDouble)}, ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlInt16), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt16), typeof(SqlInt16)}, ReturnType = typeof(SqlInt16))]
	[CalledBy(Type = typeof(SqlInt32), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt32), typeof(SqlInt32)}, ReturnType = typeof(SqlInt32))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64), typeof(SqlInt64)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64), typeof(SqlInt64)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlSingle), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlSingle), typeof(SqlSingle)}, ReturnType = typeof(SqlSingle))]
	[CallerCount(Count = 9)]
	internal static string get_DivideByZeroMessage() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 5)]
	internal static string get_FormatMessage() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CheckValidPrecScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static string get_InvalidPrecScaleMessage() { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDouble), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlGuid), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlInt16), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlInt32), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlInt64), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlSingle), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlString), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	internal static string get_NullString() { }

	[CalledBy(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static string get_NullValueMessage() { }

	[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static string get_TimeZoneSpecifiedMessage() { }

	[CalledBy(Type = typeof(SqlTruncateException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static string get_TruncationMessage() { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string InvalidOpStreamClosed(string method) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string InvalidOpStreamNonReadable(string method) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string InvalidOpStreamNonSeekable(string method) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "ThrowIfStreamCannotWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string InvalidOpStreamNonWritable(string method) { }

}

