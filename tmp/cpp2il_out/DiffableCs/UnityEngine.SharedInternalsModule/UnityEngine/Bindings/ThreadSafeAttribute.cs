namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ThreadSafeAttribute() { }

}

