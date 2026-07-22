namespace System.Reflection;

public sealed class TypeFilter : MulticastDelegate
{

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public TypeFilter(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Invoke(Type m, object filterCriteria) { }

}

