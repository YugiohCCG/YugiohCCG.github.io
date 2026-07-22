namespace UnityEngine.UIElements.StyleSheets;

internal abstract class BaseStyleMatcher
{
	private struct MatchContext
	{
		public int valueIndex; //Field offset: 0x0
		public int matchedVariableCount; //Field offset: 0x4

	}

	protected static readonly Regex s_CustomIdentRegex; //Field offset: 0x0
	private Stack<MatchContext> m_ContextStack; //Field offset: 0x10
	private MatchContext m_CurrentContext; //Field offset: 0x18

	public int currentIndex
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool hasCurrent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 36
	}

	public abstract bool isCurrentComma
	{
		 get { } //Length: 0
	}

	public abstract bool isCurrentVariable
	{
		 get { } //Length: 0
	}

	public int matchedVariableCount
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public abstract int valueCount
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BaseStyleMatcher() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected BaseStyleMatcher() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public void DropContext() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_currentIndex() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_hasCurrent() { }

	public abstract bool get_isCurrentComma() { }

	public abstract bool get_isCurrentVariable() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_matchedVariableCount() { }

	public abstract int get_valueCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void Initialize() { }

	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchManyByOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Int32*)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchJuxtaposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool Match(Expression exp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool MatchAndAnd(Expression exp) { }

	protected abstract bool MatchAngle() { }

	protected abstract bool MatchColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "RestoreContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool MatchCombinator(Expression exp) { }

	protected abstract bool MatchCustomIdent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private bool MatchDataType(Expression exp) { }

	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchExpressionWithMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private bool MatchExpression(Expression exp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool MatchGroup(Expression exp) { }

	protected abstract bool MatchInteger() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool MatchJuxtaposition(Expression exp) { }

	protected abstract bool MatchKeyword(string keyword) { }

	protected abstract bool MatchLength() { }

	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOrOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchAndAnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchManyByOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Int32*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int MatchMany(Expression exp) { }

	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	protected abstract bool MatchNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "RestoreContext", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool MatchOr(Expression exp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStyleMatcher), Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool MatchOrOr(Expression exp) { }

	protected abstract bool MatchPercentage() { }

	protected abstract bool MatchResource() { }

	protected abstract bool MatchTime() { }

	protected abstract bool MatchUrl() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MoveNext() { }

	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseStyleMatcher), Member = "MatchOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public void RestoreContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SaveContext() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_currentIndex(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_matchedVariableCount(int value) { }

}

