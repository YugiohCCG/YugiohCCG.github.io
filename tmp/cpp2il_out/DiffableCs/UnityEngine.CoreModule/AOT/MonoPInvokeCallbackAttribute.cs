namespace AOT;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class MonoPInvokeCallbackAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoPInvokeCallbackAttribute(Type type) { }

}

