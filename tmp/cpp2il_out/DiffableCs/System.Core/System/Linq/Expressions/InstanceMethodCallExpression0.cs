namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
{

	public virtual int ArgumentCount
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InstanceMethodCallExpression0(MethodInfo method, Expression instance) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_ArgumentCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Expression GetArgument(int index) { }

	[CallerCount(Count = 0)]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

