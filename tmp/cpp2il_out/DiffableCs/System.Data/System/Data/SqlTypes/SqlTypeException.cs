namespace System.Data.SqlTypes;

public class SqlTypeException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public SqlTypeException() { }

	[CalledBy(Type = typeof(SqlBytes), Member = "get_Buffer", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SqlBytes), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SqlBytes), Member = "CopyStreamToBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlBytes), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlChars), Member = "get_Buffer", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(SqlChars), Member = "get_Value", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(SqlChars), Member = "CopyStreamToBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlChars), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "FromTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(SqlDateTime))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CheckValidPrecScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlString), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(SqlString))]
	[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public SqlTypeException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public SqlTypeException(string message, Exception e) { }

	[CalledBy(Type = typeof(SqlNullValueException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlTruncateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected SqlTypeException(SerializationInfo si, StreamingContext sc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

