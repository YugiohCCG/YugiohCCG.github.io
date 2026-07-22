namespace MS.Internal.Xml.XPath;

internal class XPathParser
{
	private class ParamInfo
	{
		private FunctionType _ftype; //Field offset: 0x10
		private int _minargs; //Field offset: 0x14
		private int _maxargs; //Field offset: 0x18
		private XPathResultType[] _argTypes; //Field offset: 0x20

		public XPathResultType[] ArgTypes
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public FunctionType FType
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int Maxargs
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int Minargs
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ParamInfo(FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public XPathResultType[] get_ArgTypes() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public FunctionType get_FType() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public int get_Maxargs() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_Minargs() { }

	}

	private static readonly XPathResultType[] s_temparray1; //Field offset: 0x0
	private static readonly XPathResultType[] s_temparray2; //Field offset: 0x8
	private static readonly XPathResultType[] s_temparray3; //Field offset: 0x10
	private static readonly XPathResultType[] s_temparray4; //Field offset: 0x18
	private static readonly XPathResultType[] s_temparray5; //Field offset: 0x20
	private static readonly XPathResultType[] s_temparray6; //Field offset: 0x28
	private static readonly XPathResultType[] s_temparray7; //Field offset: 0x30
	private static readonly XPathResultType[] s_temparray8; //Field offset: 0x38
	private static readonly XPathResultType[] s_temparray9; //Field offset: 0x40
	private static Dictionary<String, ParamInfo> s_functionTable; //Field offset: 0x48
	private static Dictionary<String, AxisType> s_AxesTable; //Field offset: 0x50
	private XPathScanner _scanner; //Field offset: 0x10
	private int _parseDepth; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "CreateFunctionTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, MS.Internal.Xml.XPath.XPathParser+ParamInfo>))]
	[Calls(Type = typeof(XPathParser), Member = "CreateAxesTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, MS.Internal.Xml.XPath.Axis+AxisType>))]
	[CallsUnknownMethods(Count = 16)]
	private static XPathParser() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private XPathParser(XPathScanner scanner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void CheckNodeSet(XPathResultType t) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseNodeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(AxisType), typeof(XPathNodeType)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "PassToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LexKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void CheckToken(LexKind t) { }

	[CalledBy(Type = typeof(XPathParser), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Dictionary<String, AxisType> CreateAxesTable() { }

	[CalledBy(Type = typeof(XPathParser), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 28)]
	private static Dictionary<String, ParamInfo> CreateFunctionTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private AxisType GetAxis() { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseNodeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(AxisType), typeof(XPathNodeType)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "IsPrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathScanner)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsNodeType(XPathScanner scaner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathParser), Member = "IsNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathScanner)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsStep(LexKind lexKind) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void NextLex() { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseRelationalExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathParser), Member = "ParseMultiplicativeExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseOrExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XPathParser), Member = "ParseEqualityExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseAndExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseAndExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathParser), Member = "ParseRelationalExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseXPathExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XPathParser), Member = "ParseAndExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private AstNode ParseExpression(AstNode qyInput) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathParser), Member = "ParsePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "ParseRelativeLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private AstNode ParseLocationPath(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Function), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionType), typeof(AstNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Function), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionType), typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Function), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 31)]
	private AstNode ParseMethod(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseAdditiveExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathParser), Member = "ParseUnaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "IsNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathScanner)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "CheckToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LexKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathParser), Member = "ParseAndExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseOrExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseUnionExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathParser), Member = "IsNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathScanner)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathParser), Member = "ParsePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathParser), Member = "ParseRelativeLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private AstNode ParsePathExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseFilterExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private AstNode ParsePredicate(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseFilterExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Operand), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "IsNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathScanner)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(Operand), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "CheckToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LexKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseEqualityExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathParser), Member = "ParseAdditiveExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathParser), Member = "ParseStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseRelativeLocationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseNodeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(AxisType), typeof(XPathNodeType)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathParser), Member = "ParsePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private AstNode ParseStep(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseMultiplicativeExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseUnionExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(Operand), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseUnaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathParser), Member = "ParsePathExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	[CalledBy(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathParser), Member = "CheckToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LexKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void PassToken(LexKind t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool TestOp(string op) { }

}

