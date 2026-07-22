namespace System.Xml.Schema;

internal class NamespaceListNode : SyntaxTreeNode
{
	protected NamespaceList namespaceList; //Field offset: 0x10
	protected object particle; //Field offset: 0x18

	public virtual bool IsNullable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NamespaceListNode(NamespaceList namespaceList, object particle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool get_IsNullable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(ICollection))]
	[CallsUnknownMethods(Count = 1)]
	public override ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

}

