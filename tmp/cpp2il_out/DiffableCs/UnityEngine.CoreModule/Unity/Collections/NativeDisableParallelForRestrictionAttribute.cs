namespace Unity.Collections;

[AttributeUsage(AttributeTargets::Field (256))]
[RequiredByNativeCode]
public sealed class NativeDisableParallelForRestrictionAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeDisableParallelForRestrictionAttribute() { }

}

