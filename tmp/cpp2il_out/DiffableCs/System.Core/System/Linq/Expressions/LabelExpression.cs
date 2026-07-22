namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
public sealed class LabelExpression : Expression
{
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; //Field offset: 0x18

	public Expression DefaultValue
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public LabelTarget Target
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal LabelExpression(LabelTarget label, Expression defaultValue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_DefaultValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LabelTarget get_Target() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }

}

