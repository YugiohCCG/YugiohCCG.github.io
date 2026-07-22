namespace System.Linq.Expressions.Interpreter;

internal sealed class RuntimeVariables : IRuntimeVariables
{
	private readonly IStrongBox[] _boxes; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private RuntimeVariables(IStrongBox[] boxes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }

}

