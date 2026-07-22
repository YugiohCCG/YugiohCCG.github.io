namespace NGettext.Plural.Ast;

public class AstTokenParser
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static NullDenotationGetterDelegate <>9__4_1; //Field offset: 0x8
		public static NullDenotationGetterDelegate <>9__4_2; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Token <.ctor>b__4_1(Token self) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Token <.ctor>b__4_2(Token self) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public AstTokenParser <>4__this; //Field offset: 0x10
		public int leftBindingPower; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
		[CallsUnknownMethods(Count = 10)]
		internal Token <RegisterLeftInfixTokenDefinition>b__0(Token self, Token left) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public AstTokenParser <>4__this; //Field offset: 0x10
		public int leftBindingPower; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
		[CallsUnknownMethods(Count = 10)]
		internal Token <RegisterRightInfixTokenDefinition>b__0(Token self, Token left) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public AstTokenParser <>4__this; //Field offset: 0x10
		public int leftBindingPower; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass8_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
		[CallsUnknownMethods(Count = 7)]
		internal Token <RegisterPrefixTokenDefinition>b__0(Token self) { }

	}

	protected readonly Dictionary<TokenType, TokenDefinition> TokenDefinitions; //Field offset: 0x10
	protected string Input; //Field offset: 0x18
	protected int Position; //Field offset: 0x20
	protected Token CurrentToken; //Field offset: 0x28

	[CalledBy(Type = typeof(AstPluralRuleGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AstPluralRuleGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(MoFileParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MoFileParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(MoFileParser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoAstPluralLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AstTokenParser), Member = "RegisterTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[Calls(Type = typeof(AstTokenParser), Member = "RegisterLeftInfixTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	public AstTokenParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(AstTokenParser), Member = "AdvancePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[CompilerGenerated]
	private Token <.ctor>b__4_0(Token self, Token left) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(AstTokenParser), Member = "AdvancePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private Token <.ctor>b__4_3(Token self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 1)]
	protected void AdvancePosition() { }

	[CalledBy(Type = typeof(AstTokenParser), Member = "<.ctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "<.ctor>b__4_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParserException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected void AdvancePosition(TokenType expectedTokenType) { }

	[CalledBy(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParserException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	protected TokenDefinition GetDefinition(TokenType tokenType) { }

	[CalledBy(Type = typeof(AstPluralRuleGenerator), Member = "CreateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(IPluralRule))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "AdvancePosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "AdvancePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ParserException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	protected Token GetNextToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[Calls(Type = typeof(AstTokenParser), Member = "ParseNextExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Token))]
	[CallsUnknownMethods(Count = 2)]
	public Token Parse(string input) { }

	[CalledBy(Type = typeof(AstPluralRuleGenerator), Member = "CreateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(IPluralRule))]
	[CalledBy(Type = typeof(<>c__DisplayClass6_0), Member = "<RegisterLeftInfixTokenDefinition>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<RegisterRightInfixTokenDefinition>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(<>c__DisplayClass8_0), Member = "<RegisterPrefixTokenDefinition>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "<.ctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(Token)}, ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "<.ctor>b__4_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(Token))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AstTokenParser), Member = "GetNextToken", ReturnType = typeof(Token))]
	[Calls(Type = typeof(AstTokenParser), Member = "GetDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType)}, ReturnType = typeof(TokenDefinition))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	protected Token ParseNextExpression(int rightBindingPower = 0) { }

	[CalledBy(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(AstTokenParser), Member = "RegisterTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected TokenDefinition RegisterLeftInfixTokenDefinition(TokenType tokenType, int leftBindingPower) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = "RegisterTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected TokenDefinition RegisterPrefixTokenDefinition(TokenType tokenType, int leftBindingPower) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = "RegisterTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected TokenDefinition RegisterRightInfixTokenDefinition(TokenType tokenType, int leftBindingPower) { }

	[CalledBy(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "RegisterLeftInfixTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "RegisterRightInfixTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CalledBy(Type = typeof(AstTokenParser), Member = "RegisterPrefixTokenDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(int)}, ReturnType = typeof(TokenDefinition))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected TokenDefinition RegisterTokenDefinition(TokenType tokenType, int leftBindingPower = 0) { }

}

