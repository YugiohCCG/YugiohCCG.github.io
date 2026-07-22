namespace System.Linq.Expressions;

internal sealed class InvocationExpression2 : InvocationExpression
{
	private object _arg0; //Field offset: 0x20
	private readonly Expression _arg1; //Field offset: 0x28

	public virtual int ArgumentCount
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvocationExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_ArgumentCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Expression GetArgument(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

