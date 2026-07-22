namespace UnityEngine;

public abstract class CustomYieldInstruction : IEnumerator
{

	public override object Current
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public abstract bool keepWaiting
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CustomYieldInstruction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override object get_Current() { }

	public abstract bool get_keepWaiting() { }

	[CallerCount(Count = 82)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool MoveNext() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

