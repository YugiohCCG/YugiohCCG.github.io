namespace NGettext.Plural.Ast;

public class ParserException : Exception
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public ParserException() { }

	[CalledBy(Type = typeof(AstTokenParser), Member = "GetDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(TokenDefinition))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "AdvancePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ParserException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public ParserException(string message, Exception innerException) { }

}

