namespace System.Xml.Schema;

internal sealed class SequenceNode : InteriorNode
{
	private struct SequenceConstructPosContext
	{
		public SequenceNode this_; //Field offset: 0x0
		public BitSet firstpos; //Field offset: 0x8
		public BitSet lastpos; //Field offset: 0x10
		public BitSet lastposLeft; //Field offset: 0x18
		public BitSet firstposRight; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

	}


	public virtual bool IsNullable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 393
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SequenceNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Xml.Schema.SequenceNode+SequenceConstructPosContext>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SequenceConstructPosContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Xml.Schema.SequenceNode+SequenceConstructPosContext>), Member = "Pop", ReturnType = typeof(SequenceConstructPosContext))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteriorNode), Member = "ExpandTreeNoRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool get_IsNullable() { }

}

