namespace System.Linq.Expressions;

internal class ExpressionN : Expression<TDelegate>
{
	private IReadOnlyList<ParameterExpression> _parameters; //Field offset: 0x0

	internal virtual int ParameterCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 70
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ExpressionN`1(Expression body, IReadOnlyList<ParameterExpression> parameters) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal virtual int get_ParameterCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal virtual ParameterExpression GetParameter(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

