namespace UnityEngine.InputSystem;

public struct InputInteractionContext
{
	[Flags]
	public enum Flags
	{
		TimerHasExpired = 2,
	}

	internal InputActionState m_State; //Field offset: 0x0
	internal Flags m_Flags; //Field offset: 0x8
	internal TriggerState m_TriggerState; //Field offset: 0xC

	public InputAction action
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&)}, ReturnType = typeof(InputAction))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 36
	}

	internal int bindingIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public InputControl control
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "GetControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&)}, ReturnType = typeof(InputControl))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 36
	}

	internal int controlIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
		internal get { } //Length: 11
	}

	internal int interactionIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
		internal get { } //Length: 11
	}

	public bool isStarted
	{
		[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool isWaiting
	{
		[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	internal int mapIndex
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 5
	}

	public InputActionPhase phase
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public double startTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public double time
	{
		[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		 get { } //Length: 6
	}

	public internal bool timerHasExpired
	{
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Canceled() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float ComputeMagnitude() { }

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputActionState), Member = "IsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(float)}, ReturnType = typeof(bool))]
	public bool ControlIsActuated(float threshold = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&)}, ReturnType = typeof(InputAction))]
	[CallsUnknownMethods(Count = 1)]
	public InputAction get_action() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_bindingIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "GetControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&)}, ReturnType = typeof(InputControl))]
	[CallsUnknownMethods(Count = 1)]
	public InputControl get_control() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	internal int get_controlIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TriggerState), Member = "get_interactionIndex", ReturnType = typeof(int))]
	internal int get_interactionIndex() { }

	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_isStarted() { }

	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_isWaiting() { }

	[CallerCount(Count = 0)]
	internal int get_mapIndex() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public InputActionPhase get_phase() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double get_startTime() { }

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	public double get_time() { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_timerHasExpired() { }

	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Performed() { }

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void PerformedAndStayPerformed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void PerformedAndStayStarted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TriggerState), Member = "get_controlIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TValue ReadValue() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_timerHasExpired(bool value) { }

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionState), Member = "StartTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TriggerState&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetTimeout(float seconds) { }

	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "SetTotalTimeoutCompletionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TriggerState&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void SetTotalTimeoutCompletionTime(float seconds) { }

	[CalledBy(Type = typeof(HoldInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PressInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SlowTapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TapInteraction), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputInteractionContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Started() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Waiting() { }

}

