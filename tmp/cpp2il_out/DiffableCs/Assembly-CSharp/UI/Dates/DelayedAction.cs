namespace UI.Dates;

public class DelayedAction
{
	public float timeToExecute; //Field offset: 0x10
	public Action action; //Field offset: 0x18
	public MonoBehaviour target; //Field offset: 0x20
	public bool forceEvenIfTargetIsInactive; //Field offset: 0x28

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DelayedAction() { }

}

