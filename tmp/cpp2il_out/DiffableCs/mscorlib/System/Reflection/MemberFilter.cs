namespace System.Reflection;

public sealed class MemberFilter : MulticastDelegate
{

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public MemberFilter(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Invoke(MemberInfo m, object filterCriteria) { }

}

