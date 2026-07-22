namespace UnityEngine;

[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected StateMachineBehaviour() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

}

