namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
public class BlockExpression : Expression
{

	[ExcludeFromCodeCoverage]
	internal override int ExpressionCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 39
	}

	public ReadOnlyCollection<Expression> Expressions
	{
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal BlockExpression() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal override int get_ExpressionCount() { }

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_Type() { }

	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override Expression GetExpression(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[CallerCount(Count = 0)]
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[CalledBy(Type = typeof(Block2), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block3), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block4), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Block5), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CalledBy(Type = typeof(Scope1), Member = "GetOrMakeExpressions", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

