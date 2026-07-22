namespace Unity.Collections.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Field (256))]
[RequiredByNativeCode]
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeDisableUnsafePtrRestrictionAttribute() { }

}

