namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class NoThrowExpressionVisitor : ExpressionVisitor
{
	internal static readonly object ErrorResult; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static NoThrowExpressionVisitor() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NoThrowExpressionVisitor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitConditional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConditionalExpression)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual Expression VisitConditional(ConditionalExpression node) { }

}

