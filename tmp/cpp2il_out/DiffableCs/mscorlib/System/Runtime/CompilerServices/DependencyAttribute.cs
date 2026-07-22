namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public sealed class DependencyAttribute : Attribute
{
	private string dependentAssembly; //Field offset: 0x10
	private LoadHint loadHint; //Field offset: 0x18

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument) { }

}

