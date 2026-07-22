namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
internal class MonoLimitationAttribute : MonoTODOAttribute
{

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoLimitationAttribute(string comment) { }

}

