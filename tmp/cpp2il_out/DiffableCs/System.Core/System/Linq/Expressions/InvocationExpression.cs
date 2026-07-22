namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18

	[ExcludeFromCodeCoverage]
	public override int ArgumentCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public Expression Expression
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

	public virtual Type Type
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(InvocationExpressionN), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression0), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InvocationExpression5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal InvocationExpression(Expression expression, Type returnType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override int get_ArgumentCount() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Expression() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	public override Expression GetArgument(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

