namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
public class MethodCallExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

	[ExcludeFromCodeCoverage]
	public override int ArgumentCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public ReadOnlyCollection<Expression> Arguments
	{
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public MethodInfo Method
	{
		[CallerCount(Count = 106)]
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

	public Expression Object
	{
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MethodCallExpression(MethodInfo method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override int get_ArgumentCount() { }

	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodInfo get_Method() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Expression get_Object() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	public override Expression GetArgument(int index) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Expression GetInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

