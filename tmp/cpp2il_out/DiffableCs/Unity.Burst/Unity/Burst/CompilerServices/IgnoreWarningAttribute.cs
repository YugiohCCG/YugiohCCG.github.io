namespace Unity.Burst.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class IgnoreWarningAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public IgnoreWarningAttribute(int warning) { }

}

