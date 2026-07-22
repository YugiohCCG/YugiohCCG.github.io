namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
internal class MonoTODOAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoTODOAttribute() { }

}

