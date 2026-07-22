namespace System.Linq.Expressions;

internal class FullConditionalExpression : ConditionalExpression
{
	private readonly Expression _false; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal virtual Expression GetFalse() { }

}

