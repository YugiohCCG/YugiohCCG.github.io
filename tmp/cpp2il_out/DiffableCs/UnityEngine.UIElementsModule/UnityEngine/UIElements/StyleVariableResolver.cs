namespace UnityEngine.UIElements;

internal class StyleVariableResolver
{
	private struct ResolveContext
	{
		public StyleSheet sheet; //Field offset: 0x0
		public StyleValueHandle[] handles; //Field offset: 0x8

	}

	private enum Result
	{
		Valid = 0,
		Invalid = 1,
		NotFound = 2,
	}

	internal const int kMaxResolves = 100; //Field offset: 0x0
	private static StyleSyntaxParser s_SyntaxParser; //Field offset: 0x0
	private StylePropertyValueMatcher m_Matcher; //Field offset: 0x10
	private List<StylePropertyValue> m_ResolvedValues; //Field offset: 0x18
	private Stack<String> m_ResolvedVarStack; //Field offset: 0x20
	private StyleProperty m_Property; //Field offset: 0x28
	private Stack<ResolveContext> m_ContextStack; //Field offset: 0x30
	private ResolveContext m_CurrentContext; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleVariableContext <variableContext>k__BackingField; //Field offset: 0x48

	private StyleValueHandle[] currentHandles
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private StyleSheet currentSheet
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public List<StylePropertyValue> resolvedValues
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public StyleVariableContext variableContext
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleSyntaxParser), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static StyleVariableResolver() { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyValueMatcher), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public StyleVariableResolver() { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void AddValue(StyleValueHandle handle) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	private StyleValueHandle[] get_currentHandles() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	private StyleSheet get_currentSheet() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public List<StylePropertyValue> get_resolvedValues() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public StyleVariableContext get_variableContext() { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.StyleVariableResolver+ResolveContext>), Member = "Pop", ReturnType = typeof(ResolveContext))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private void PopContext() { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleProperty), typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.StyleVariableResolver+ResolveContext>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResolveContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "IsVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ParseVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[]), typeof(Int32&), typeof(Int32&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private Result ResolveFallback(ref int index, bool appendValues) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dimension[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(StyleSheet), Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(StyleValueType), typeof(StyleValueHandle)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool ResolveVarFunction(ref int index) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(Result))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private Result ResolveVarFunction(ref int index, int argc, string varName) { }

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheetExtensions), Member = "IsVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "ResolveVarFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(string)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(StyleVariableResolver), Member = "PopContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private Result ResolveVariable(string variableName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_variableContext(StyleVariableContext value) { }

	[CalledBy(Type = typeof(StylePropertyReader), Member = "LoadProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyCache), Member = "TryGetSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSyntaxParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[Calls(Type = typeof(MatchResult), Member = "get_success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool ValidateResolvedValues() { }

}

