namespace System.Linq.Expressions;

internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
{

	public virtual int ArgumentCount
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public MethodCallExpression0(MethodInfo method) { }

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
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

