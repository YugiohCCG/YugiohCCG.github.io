namespace System.Data.Common;

internal static class ADP
{
	private static readonly Type s_stackOverflowType; //Field offset: 0x0
	private static readonly Type s_outOfMemoryType; //Field offset: 0x8
	private static readonly Type s_threadAbortType; //Field offset: 0x10
	private static readonly Type s_nullReferenceType; //Field offset: 0x18
	private static readonly Type s_accessViolationType; //Field offset: 0x20
	private static readonly Type s_securityType; //Field offset: 0x28
	internal static readonly string StrEmpty; //Field offset: 0x30
	internal static readonly String[] AzureSqlServerEndpoints; //Field offset: 0x38
	internal static readonly IntPtr PtrZero; //Field offset: 0x40
	internal static readonly int PtrSize; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private static ADP() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal static ArgumentException Argument(string error) { }

	[CalledBy(Type = typeof(SqlString), Member = "CompareOptionsFromSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(CompareOptions))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	[CalledBy(Type = typeof(ADP), Member = "InvalidEnumerationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CalledBy(Type = typeof(ADP), Member = "InvalidSeekOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "set_AcceptRejectRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AcceptRejectRule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[ContainsInvalidInstructions]
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	[CalledBy(Type = typeof(ADP), Member = "InvalidMissingSchemaAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MissingSchemaAction)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CalledBy(Type = typeof(ADP), Member = "InvalidRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ADP), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	[CalledBy(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "InvalidEnumerationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	[CalledBy(Type = typeof(ObjectStorage), Member = "VerifyIDynamicMetaObjectProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal static InvalidOperationException InvalidOperation(string error) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "set_DeleteRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "set_UpdateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "InvalidEnumerationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	[CalledBy(Type = typeof(SqlXmlStreamWrapper), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ADP), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	[CalledBy(Type = typeof(NameNode), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataColumn>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlXml), Member = "CreateSqlXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsCatchableExceptionType(Exception e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	[CalledBy(Type = typeof(ExceptionBuilder), Member = "ColumnTypeNotSupported", ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal static NotSupportedException NotSupported(string error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void TraceException(string trace, Exception e) { }

	[CalledBy(Type = typeof(ADP), Member = "Argument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CalledBy(Type = typeof(ADP), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CalledBy(Type = typeof(ADP), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CalledBy(Type = typeof(ADP), Member = "InvalidOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InvalidOperationException))]
	[CalledBy(Type = typeof(ADP), Member = "NotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NotSupportedException))]
	[CalledBy(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	[CalledBy(Type = "Mono.Unity.UnityTls+unitytls_interface_struct+unitytls_x509verify_explicit_ca_t", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "set_XmlText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataCommonEventSource), Member = "Trace", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	[CalledBy(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlString), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlSingle), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlMoney), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt32), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt16), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt64), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDouble), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlByte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlBoolean), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlGuid), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "TraceExceptionAsReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static Exception WrongType(Type got, Type expected) { }

}

