namespace System;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class STAThreadAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public STAThreadAttribute() { }

}

