namespace System.Xml.Schema;

internal class Asttree
{
	private ArrayList _fAxisArray; //Field offset: 0x10
	private string _xpathexpr; //Field offset: 0x18
	private bool _isField; //Field offset: 0x20
	private XmlNamespaceManager _nsmgr; //Field offset: 0x28

	internal ArrayList SubtreeArray
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(CompiledIdentityConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	[CalledBy(Type = typeof(Asttree), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompiledIdentityConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathParser), Member = "ParseXPathExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(Asttree), Member = "SetURN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleLinkAxis), Member = "ConvertTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis)}, ReturnType = typeof(DoubleLinkAxis))]
	[Calls(Type = typeof(ForwardAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleLinkAxis), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 49)]
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal ArrayList get_SubtreeArray() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsAttribute(Axis ast) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsDescendantOrSelf(Axis ast) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsNameTest(Axis ast) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsSelf(Axis ast) { }

	[CalledBy(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

