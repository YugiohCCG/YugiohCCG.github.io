namespace System.Xml.Schema;

internal abstract class SyntaxTreeNode
{

	public abstract bool IsNullable
	{
		 get { } //Length: 0
	}

	public override bool IsRangeNode
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected SyntaxTreeNode() { }

	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public abstract bool get_IsNullable() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsRangeNode() { }

}

