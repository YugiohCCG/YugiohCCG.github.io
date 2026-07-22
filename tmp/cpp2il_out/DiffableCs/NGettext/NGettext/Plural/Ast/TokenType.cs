namespace NGettext.Plural.Ast;

public enum TokenType
{
	None = 0,
	TernaryIf = 1,
	TernaryElse = 2,
	Or = 3,
	And = 4,
	Equals = 5,
	NotEquals = 6,
	GreaterThan = 7,
	LessThan = 8,
	GreaterOrEquals = 9,
	LessOrEquals = 10,
	Minus = 11,
	Plus = 12,
	Multiply = 13,
	Divide = 14,
	Modulo = 15,
	Not = 16,
	N = 17,
	Number = 18,
	LeftParenthesis = 19,
	RightParenthesis = 20,
	EOF = 21,
}

