namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Tap")]
public class TapInteraction : IInputInteraction
{
	public float duration; //Field offset: 0x10
	public float pressPoint; //Field offset: 0x14
	private double m_TapStartTime; //Field offset: 0x18
	private bool canceledFromTimerExpired; //Field offset: 0x20

	private float durationOrDefault
	{
		[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 108
	}

	private float pressPointOrDefault
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 83
	}

	private float releasePointOrDefault
	{
		[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		private get { } //Length: 118
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TapInteraction() { }

	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	private float get_durationOrDefault() { }

	[CallerCount(Count = 0)]
	private float get_pressPointOrDefault() { }

	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private float get_releasePointOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_isWaiting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "ControlIsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Started", ReturnType = typeof(void))]
	[Calls(Type = typeof(TapInteraction), Member = "get_durationOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputInteractionContext), Member = "SetTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_isStarted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TapInteraction), Member = "get_releasePointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Canceled", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Performed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Process(ref InputInteractionContext context) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

