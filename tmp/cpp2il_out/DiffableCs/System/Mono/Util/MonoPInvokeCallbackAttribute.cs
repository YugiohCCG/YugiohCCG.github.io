namespace Mono.Util;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("UNITY")]
[Conditional("FULL_AOT_RUNTIME")]
[Conditional("MONOTOUCH")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoPInvokeCallbackAttribute(Type t) { }

}

