namespace System.Linq.Expressions;

internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	private readonly Expression _instance; //Field offset: 0x18

	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public InstanceMethodCallExpression(MethodInfo method, Expression instance) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual Expression GetInstance() { }

}

