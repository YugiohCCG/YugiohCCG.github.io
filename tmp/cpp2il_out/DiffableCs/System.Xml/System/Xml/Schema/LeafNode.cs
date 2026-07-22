namespace System.Xml.Schema;

internal class LeafNode : SyntaxTreeNode
{
	private int pos; //Field offset: 0x10

	public virtual bool IsNullable
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int Pos
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LeafNode(int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsNullable() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Pos() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_Pos(int value) { }

}

