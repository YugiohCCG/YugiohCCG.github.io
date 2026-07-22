namespace System.Linq.Expressions;

internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
{
	private readonly LambdaExpression _conversion; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal virtual LambdaExpression GetConversion() { }

}

