namespace UI.Dates;

internal class DelayedEditorAction
{
	internal double TimeToExecute; //Field offset: 0x10
	internal Action Action; //Field offset: 0x18
	internal MonoBehaviour ActionTarget; //Field offset: 0x20
	internal bool ForceEvenIfTargetIsGone; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DelayedEditorAction(double timeToExecute, Action action, MonoBehaviour actionTarget, bool forceEvenIfTargetIsGone = false) { }

}

