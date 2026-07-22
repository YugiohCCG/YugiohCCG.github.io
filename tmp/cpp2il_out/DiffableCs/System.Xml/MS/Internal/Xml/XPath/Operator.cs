namespace MS.Internal.Xml.XPath;

internal class Operator : AstNode
{
	internal enum Op
	{
		INVALID = 0,
		OR = 1,
		AND = 2,
		EQ = 3,
		NE = 4,
		LT = 5,
		LE = 6,
		GT = 7,
		GE = 8,
		PLUS = 9,
		MINUS = 10,
		MUL = 11,
		DIV = 12,
		MOD = 13,
		UNION = 14,
	}

	private static Op[] s_invertOp; //Field offset: 0x0
	private Op _opType; //Field offset: 0x10
	private AstNode _opnd1; //Field offset: 0x18
	private AstNode _opnd2; //Field offset: 0x20

	public AstNode Operand1
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AstNode Operand2
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Op OperatorType
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual XPathResultType ReturnType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 27
	}

	public virtual AstType Type
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Operator() { }

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Operator(Op op, AstNode opnd1, AstNode opnd2) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public AstNode get_Operand1() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AstNode get_Operand2() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public Op get_OperatorType() { }

	[CallerCount(Count = 0)]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Op InvertOperator(Op op) { }

}

