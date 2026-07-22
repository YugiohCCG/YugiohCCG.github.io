namespace System;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = True, AllowMultiple = False)]
public sealed class ParamArrayAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParamArrayAttribute() { }

}

