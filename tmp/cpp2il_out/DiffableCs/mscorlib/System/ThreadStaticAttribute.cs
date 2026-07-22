namespace System;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
public class ThreadStaticAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ThreadStaticAttribute() { }

}

