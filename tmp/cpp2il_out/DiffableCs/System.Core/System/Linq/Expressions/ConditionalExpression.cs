namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
public class ConditionalExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; //Field offset: 0x18

	public Expression IfFalse
	{
		[CallerCount(Count = 44)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public Expression IfTrue
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public Expression Test
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(ConditionalExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(FullConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullConditionalExpressionWithType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ConditionalExpression(Expression test, Expression ifTrue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Expression get_IfFalse() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_IfTrue() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Test() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 0)]
	internal override Expression GetFalse() { }

	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallsDeduplicatedMethods(Count = 2)]
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }

}

