namespace Unity.Burst.CompilerServices;

[AttributeUsage(10240)]
public class AssumeRangeAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AssumeRangeAttribute(long min, long max) { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AssumeRangeAttribute(ulong min, ulong max) { }

}

