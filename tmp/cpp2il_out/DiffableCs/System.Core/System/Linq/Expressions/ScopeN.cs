namespace System.Linq.Expressions;

internal class ScopeN : ScopeExpression
{
	private IReadOnlyList<Expression> _body; //Field offset: 0x18

	protected IReadOnlyList<Expression> Body
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal virtual int ExpressionCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 70
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected IReadOnlyList<Expression> get_Body() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual int get_ExpressionCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual Expression GetExpression(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

