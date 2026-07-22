namespace System.Collections.Generic;

internal sealed class TreeWalkPredicate : MulticastDelegate
{

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TreeWalkPredicate`1(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Invoke(Node<T> node) { }

}

