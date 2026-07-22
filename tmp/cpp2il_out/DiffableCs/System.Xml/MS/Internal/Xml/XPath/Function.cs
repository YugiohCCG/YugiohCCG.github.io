namespace MS.Internal.Xml.XPath;

internal class Function : AstNode
{
	internal enum FunctionType
	{
		FuncLast = 0,
		FuncPosition = 1,
		FuncCount = 2,
		FuncID = 3,
		FuncLocalName = 4,
		FuncNameSpaceUri = 5,
		FuncName = 6,
		FuncString = 7,
		FuncBoolean = 8,
		FuncNumber = 9,
		FuncTrue = 10,
		FuncFalse = 11,
		FuncNot = 12,
		FuncConcat = 13,
		FuncStartsWith = 14,
		FuncContains = 15,
		FuncSubstringBefore = 16,
		FuncSubstringAfter = 17,
		FuncSubstring = 18,
		FuncStringLength = 19,
		FuncNormalize = 20,
		FuncTranslate = 21,
		FuncLang = 22,
		FuncSum = 23,
		FuncFloor = 24,
		FuncCeiling = 25,
		FuncRound = 26,
		FuncUserDefined = 27,
	}

	internal static XPathResultType[] ReturnTypes; //Field offset: 0x0
	private FunctionType _functionType; //Field offset: 0x10
	private List<AstNode> _argumentList; //Field offset: 0x18
	private string _name; //Field offset: 0x20
	private string _prefix; //Field offset: 0x28

	public List<AstNode> ArgumentList
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Prefix
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XPathResultType ReturnType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 113
	}

	public virtual AstType Type
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public FunctionType TypeOfFunction
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Function() { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Function(FunctionType ftype, List<AstNode> argumentList) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Function(string prefix, string name, List<AstNode> argumentList) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Function(FunctionType ftype, AstNode arg) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public List<AstNode> get_ArgumentList() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathResultType get_ReturnType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual AstType get_Type() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public FunctionType get_TypeOfFunction() { }

}

