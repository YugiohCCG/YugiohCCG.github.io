namespace UnityEngine.InputSystem.Interactions;

public class MultiTapInteraction : IInputInteraction<Single>, IInputInteraction
{
	private enum TapPhase
	{
		None = 0,
		WaitingForNextRelease = 1,
		WaitingForNextPress = 2,
	}

	[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
	public float tapTime; //Field offset: 0x10
	[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
	public float tapDelay; //Field offset: 0x14
	[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
	public int tapCount; //Field offset: 0x18
	public float pressPoint; //Field offset: 0x1C
	private TapPhase m_CurrentTapPhase; //Field offset: 0x20
	private int m_CurrentTapCount; //Field offset: 0x24
	private double m_CurrentTapStartTime; //Field offset: 0x28
	private double m_LastTapReleaseTime; //Field offset: 0x30

	private float pressPointOrDefault
	{
		[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		private get { } //Length: 83
	}

	private float releasePointOrDefault
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 118
	}

	internal float tapDelayOrDefault
	{
		[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 108
	}

	private float tapTimeOrDefault
	{
		[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 108
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MultiTapInteraction() { }

	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private float get_pressPointOrDefault() { }

	[CallerCount(Count = 0)]
	private float get_releasePointOrDefault() { }

	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	internal float get_tapDelayOrDefault() { }

	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	private float get_tapTimeOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiTapInteraction), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputInteractionContext), Member = "ControlIsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(MultiTapInteraction), Member = "get_tapDelayOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(MultiTapInteraction), Member = "get_tapTimeOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputInteractionContext), Member = "SetTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Canceled", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Performed", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Started", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "SetTotalTimeoutCompletionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Process(ref InputInteractionContext context) { }

	[CallerCount(Count = 0)]
	public override void Reset() { }

}

