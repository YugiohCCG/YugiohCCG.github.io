namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
public sealed class LoopExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; //Field offset: 0x20

	public Expression Body
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public LabelTarget BreakLabel
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public LabelTarget ContinueLabel
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 87
	}

	[CalledBy(Type = typeof(Expression), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(LoopExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal LoopExpression(Expression body, LabelTarget break, LabelTarget continue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Body() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LabelTarget get_BreakLabel() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LabelTarget get_ContinueLabel() { }

	[CallerCount(Count = 0)]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(LoopExpression))]
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }

}

