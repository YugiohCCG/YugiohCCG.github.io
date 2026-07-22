namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Press")]
public class PressInteraction : IInputInteraction
{
	[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to 'Default Press Point' in the global input settings.")]
	public float pressPoint; //Field offset: 0x10
	[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
	public PressBehavior behavior; //Field offset: 0x14
	private bool m_WaitingForRelease; //Field offset: 0x18

	private float pressPointOrDefault
	{
		[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		private get { } //Length: 83
	}

	private float releasePointOrDefault
	{
		[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		private get { } //Length: 118
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PressInteraction() { }

	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	private float get_pressPointOrDefault() { }

	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	private float get_releasePointOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PressInteraction), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(PressInteraction), Member = "get_releasePointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Performed", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Canceled", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_isStarted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "PerformedAndStayPerformed", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Started", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void Process(ref InputInteractionContext context) { }

	[CallerCount(Count = 0)]
	public override void Reset() { }

}

