namespace System.Linq.Expressions;

internal class ScopeExpression : BlockExpression
{
	private IReadOnlyList<ParameterExpression> _variables; //Field offset: 0x10

	protected IReadOnlyList<ParameterExpression> VariablesList
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ScopeExpression(IReadOnlyList<ParameterExpression> variables) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyList`1<T>&"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }

}

