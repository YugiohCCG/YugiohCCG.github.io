namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct LocalDefinition
{
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; //Field offset: 0x8

	public int Index
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public ParameterExpression Parameter
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal LocalDefinition(int localIndex, ParameterExpression parameter) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ParameterExpression get_Parameter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

}

