namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Long Tap")]
public class SlowTapInteraction : IInputInteraction
{
	public float duration; //Field offset: 0x10
	public float pressPoint; //Field offset: 0x14
	private double m_SlowTapStartTime; //Field offset: 0x18

	private float durationOrDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 108
	}

	private float pressPointOrDefault
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 83
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SlowTapInteraction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	private float get_durationOrDefault() { }

	[CallerCount(Count = 0)]
	private float get_pressPointOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_isWaiting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "ControlIsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Started", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "get_isStarted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Canceled", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputInteractionContext), Member = "Performed", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Process(ref InputInteractionContext context) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

