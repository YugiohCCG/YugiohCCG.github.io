namespace Mono.Interop;

[AttributeUsage(AttributeTargets::Method (64))]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoPInvokeCallbackAttribute(Type t) { }

}

