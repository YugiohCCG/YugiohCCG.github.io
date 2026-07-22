namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlString : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlString Null; //Field offset: 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; //Field offset: 0x20
	public static readonly int IgnoreCase; //Field offset: 0x28
	public static readonly int IgnoreWidth; //Field offset: 0x2C
	public static readonly int IgnoreNonSpace; //Field offset: 0x30
	public static readonly int IgnoreKanaType; //Field offset: 0x34
	public static readonly int BinarySort; //Field offset: 0x38
	public static readonly int BinarySort2; //Field offset: 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; //Field offset: 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; //Field offset: 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; //Field offset: 0x48
	internal static readonly int s_lcidUSEnglish; //Field offset: 0x4C
	private static readonly int s_lcidBinary; //Field offset: 0x50
	private string m_value; //Field offset: 0x0
	private CompareInfo m_cmpInfo; //Field offset: 0x8
	private int m_lcid; //Field offset: 0x10
	private SqlCompareOptions m_flag; //Field offset: 0x14
	private bool m_fNotNull; //Field offset: 0x18

	public override bool IsNull
	{
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string Value
	{
		[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(SqlChars), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SqlStringStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SqlStringStorage), Member = "GetStringLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 129
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static SqlString() { }

	[CalledBy(Type = typeof(SqlString), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(SqlString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlString), Member = "ValidateSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private SqlString(bool fNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlString), Member = "ValidateSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public SqlString(string data, int lcid, SqlCompareOptions compareOptions) { }

	[CalledBy(Type = typeof(SqlString), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SqlString), Member = "ValidateSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public SqlString(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static int CompareBinary(SqlString x, SqlString y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private static int CompareBinary2(SqlString x, SqlString y) { }

	[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlString), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlString), Member = "ValidateSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ADP), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 5)]
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	[CalledBy(Type = typeof(SqlString), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlString value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlString), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "get_Value", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool FBinarySort() { }

	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CalledBy(Type = typeof(DataColumn), Member = "IsMaxLengthViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlChars), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlStringStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlStringStorage), Member = "GetStringLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlString), Member = "SetCompareInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlString), Member = "CompareOptionsFromSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(CompareOptions))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SqlBinary), Member = "HashByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SqlCompareOptions), typeof(string), typeof(CompareInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ConcatDiffCollationMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlString))]
	[CalledBy(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static SqlString op_Implicit(string x) { }

	[CalledBy(Type = typeof(SqlString), Member = "StringCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlString), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCompareInfo() { }

	[CalledBy(Type = typeof(SqlString), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString), typeof(EComparison)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlString), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SqlString), Member = "SetCompareInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SqlString), Member = "CompareOptionsFromSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(CompareOptions))]
	[Calls(Type = typeof(SqlString), Member = "CompareBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlString), typeof(SqlString)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SQLResource), Member = "get_CompareDiffCollationMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static int StringCompare(SqlString x, SqlString y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(SqlString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SqlCompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SqlCompareOptions), typeof(string), typeof(CompareInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlString), Member = "CompareOptionsFromSqlCompareOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlCompareOptions)}, ReturnType = typeof(CompareOptions))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

}

