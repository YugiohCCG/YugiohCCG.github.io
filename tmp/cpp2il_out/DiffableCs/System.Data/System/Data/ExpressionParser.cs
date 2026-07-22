namespace System.Data;

internal sealed class ExpressionParser
{
	[IsReadOnly]
	private struct ReservedWords
	{
		internal readonly string _word; //Field offset: 0x0
		internal readonly Tokens _token; //Field offset: 0x8
		internal readonly int _op; //Field offset: 0xC

		[CallerCount(Count = 94)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ReservedWords(string word, Tokens token, int op) { }

	}

	private static readonly ReservedWords[] s_reservedwords; //Field offset: 0x0
	private char _escape; //Field offset: 0x10
	private char _decimalSeparator; //Field offset: 0x12
	private char _listSeparator; //Field offset: 0x14
	private char _exponentL; //Field offset: 0x16
	private char _exponentU; //Field offset: 0x18
	internal Char[] _text; //Field offset: 0x20
	internal int _pos; //Field offset: 0x28
	internal int _start; //Field offset: 0x2C
	internal Tokens _token; //Field offset: 0x30
	internal int _op; //Field offset: 0x34
	internal OperatorInfo[] _ops; //Field offset: 0x38
	internal int _topOperator; //Field offset: 0x40
	internal int _topNode; //Field offset: 0x44
	private readonly DataTable _table; //Field offset: 0x48
	internal ExpressionNode[] _nodeStack; //Field offset: 0x50
	internal int _prevOperand; //Field offset: 0x58
	internal ExpressionNode _expression; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 27)]
	private static ExpressionParser() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal ExpressionParser(DataTable table) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ZeroOpNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnaryNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(ExpressionNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "UnsupportedOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "ExpressionTooComplex", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void BuildExpression(int pri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens), typeof(Tokens), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void CheckToken(Tokens token) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsAlpha(char ch) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "ScanName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "ScanReserved", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsInvalidInstructions]
	private bool IsAlphaNumeric(char ch) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsDigit(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsWhiteSpace(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void LoadExpression(string data) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ExpressionNode NodePeek() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private ExpressionNode NodePop() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExprException), Member = "ExpressionTooComplex", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	private void NodePush(ExpressionNode node) { }

	[CalledBy(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnaryNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(int), typeof(ExpressionNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "ParseAggregateArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId)}, ReturnType = typeof(ExpressionNode))]
	[Calls(Type = typeof(FunctionNode), Member = "get_Aggregate", ReturnType = typeof(FunctionId))]
	[Calls(Type = typeof(FunctionNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExpressionParser), Member = "NodePeek", ReturnType = typeof(ExpressionNode))]
	[Calls(Type = typeof(ExpressionParser), Member = "NodePush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionNode), Member = "AddArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "NodePop", ReturnType = typeof(ExpressionNode))]
	[Calls(Type = typeof(ExpressionParser), Member = "BuildExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[Calls(Type = typeof(FunctionNode), Member = "Check", ReturnType = typeof(void))]
	[Calls(Type = typeof(Operators), Member = "Priority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	internal ExpressionNode Parse() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[Calls(Type = typeof(NameNode), Member = "ParseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AggregateNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(FunctionId), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "AggregateArgument", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens), typeof(Tokens), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 18)]
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "ParseAggregateArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId)}, ReturnType = typeof(ExpressionNode))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "ScanToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ExpressionParser), Member = "ScanWhite", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "ScanName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "ScanNumeric", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "ScanReserved", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionParser), Member = "IsAlphaNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "InvalidDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "InvalidString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens), typeof(Tokens), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 23)]
	internal Tokens Scan() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void ScanBinaryConstant() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "InvalidDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 9)]
	private void ScanDate() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "InvalidNameBracketing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionParser), Member = "IsAlphaNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void ScanName() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void ScanNumeric() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionParser), Member = "IsAlphaNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ScanReserved() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "InvalidString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	private void ScanString(char escape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[Calls(Type = typeof(ExprException), Member = "UnknownToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokens), typeof(Tokens), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void ScanToken(Tokens token) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Scan", ReturnType = typeof(Tokens))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ScanWhite() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void StartScan() { }

}

