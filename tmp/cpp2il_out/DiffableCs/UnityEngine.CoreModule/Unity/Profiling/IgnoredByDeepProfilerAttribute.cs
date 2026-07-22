namespace Unity.Profiling;

[AttributeUsage(76, AllowMultiple = False)]
[RequiredByNativeCode]
public sealed class IgnoredByDeepProfilerAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public IgnoredByDeepProfilerAttribute() { }

}

