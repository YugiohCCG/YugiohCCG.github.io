namespace UnityEngine;

public sealed class WaitWhile : CustomYieldInstruction
{
	private readonly Func<Boolean> m_Predicate; //Field offset: 0x10
	private readonly Action m_TimeoutCallback; //Field offset: 0x18
	private readonly WaitTimeoutMode m_TimeoutMode; //Field offset: 0x20
	private readonly double m_MaxExecutionTime; //Field offset: 0x28

	public virtual bool keepWaiting
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 174
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_keepWaiting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private double GetTime() { }

}

