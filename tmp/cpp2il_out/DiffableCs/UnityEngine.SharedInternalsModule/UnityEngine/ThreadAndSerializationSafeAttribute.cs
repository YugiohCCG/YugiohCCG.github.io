namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class ThreadAndSerializationSafeAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ThreadAndSerializationSafeAttribute() { }

}

