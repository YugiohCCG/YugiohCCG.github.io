namespace System;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
public sealed class CLSCompliantAttribute : Attribute
{
	private bool _compliant; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CLSCompliantAttribute(bool isCompliant) { }

}

