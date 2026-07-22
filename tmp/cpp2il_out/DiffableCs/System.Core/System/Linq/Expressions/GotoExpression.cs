namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
public sealed class GotoExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; //Field offset: 0x28

	public GotoExpressionKind Kind
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public LabelTarget Target
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Expression Value
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GotoExpressionKind get_Kind() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LabelTarget get_Target() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public GotoExpression Update(LabelTarget target, Expression value) { }

}

