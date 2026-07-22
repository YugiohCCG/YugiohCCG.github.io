namespace UnityEngine.UIElements.StyleSheets.Syntax;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleSyntaxParser
{
	private List<Expression> m_ProcessExpressionList; //Field offset: 0x10
	private Stack<Expression> m_ExpressionStack; //Field offset: 0x18
	private Stack<ExpressionCombinator> m_CombinatorStack; //Field offset: 0x20
	private Dictionary<String, Expression> m_ParsedExpressionCache; //Field offset: 0x28

	[CalledBy(Type = typeof(StyleVariableResolver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public StyleSyntaxParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[CallsUnknownMethods(Count = 1)]
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsCombinator(StyleSyntaxToken token) { }

	[CallerCount(Count = 0)]
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	[CallerCount(Count = 0)]
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseNonTerminalValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Expression Parse(string syntax) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StylePropertyCache), Member = "TryGetNonTerminalValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 32)]
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseCombinatorType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(ExpressionCombinator))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ProcessCombinatorStack", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseTerm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[ContainsInvalidInstructions]
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private Expression ParseNonTerminalValue(string syntax) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StylePropertyCache), Member = "TryGetSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 32)]
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "get_current", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSyntaxTokenizer), Member = "MoveNext", ReturnType = typeof(StyleSyntaxToken))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "ParseMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer), typeof(ExpressionMultiplier&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void ProcessCombinatorStack() { }

}

