namespace Unity.Burst.CompilerServices;

public static class Constant
{

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool IsConstantExpression(T t) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool IsConstantExpression(Void* t) { }

}

