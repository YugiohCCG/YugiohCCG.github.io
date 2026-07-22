namespace System.Linq.Expressions;

internal class MethodBinaryExpression : SimpleBinaryExpression
{
	private readonly MethodInfo _method; //Field offset: 0x30

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal virtual MethodInfo GetMethod() { }

}

