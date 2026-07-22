namespace System.Xml.Schema;

internal sealed class LeafRangeNode : LeafNode
{
	private decimal min; //Field offset: 0x18
	private decimal max; //Field offset: 0x28
	private BitSet nextIteration; //Field offset: 0x38

	public virtual bool IsRangeNode
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public decimal Max
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public decimal Min
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public BitSet NextIteration
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeafRangeNode(decimal min, decimal max) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeafRangeNode(int pos, decimal min, decimal max) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_IsRangeNode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public decimal get_Max() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public decimal get_Min() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public BitSet get_NextIteration() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_NextIteration(BitSet value) { }

}

