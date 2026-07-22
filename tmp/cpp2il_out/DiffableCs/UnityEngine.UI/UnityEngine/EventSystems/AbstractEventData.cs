namespace UnityEngine.EventSystems;

public abstract class AbstractEventData
{
	protected bool m_Used; //Field offset: 0x10

	public override bool used
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AbstractEventData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_used() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public override void Use() { }

}

