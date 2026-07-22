namespace System.Dynamic.Utils;

internal static class ExpressionVisitorUtils
{

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitInvocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvocationExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodCallExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IParameterProvider), typeof(string)}, ReturnType = typeof(ParameterExpression[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 16)]
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

}

