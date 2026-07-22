namespace UnityEngine.Rendering;

internal class DebugActionState
{
	private enum DebugActionKeyType
	{
		Button = 0,
		Axis = 1,
		Key = 2,
	}

	private DebugActionKeyType m_Type; //Field offset: 0x10
	private InputAction inputAction; //Field offset: 0x18
	private Boolean[] m_TriggerPressedUp; //Field offset: 0x20
	private float m_Timer; //Field offset: 0x28
	[CompilerGenerated]
	private bool <runningAction>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <actionState>k__BackingField; //Field offset: 0x30

	internal float actionState
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 6
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	internal bool runningAction
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugActionState() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal float get_actionState() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_runningAction() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Reset() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_actionState(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_runningAction(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void Trigger(int triggerCount, float state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[CallsUnknownMethods(Count = 4)]
	public void TriggerWithButton(InputAction action, float state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 4)]
	public void Update(DebugActionDesc desc) { }

}

