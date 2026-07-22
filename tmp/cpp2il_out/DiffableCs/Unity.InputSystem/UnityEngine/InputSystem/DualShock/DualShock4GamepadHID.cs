namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = True, isNoisy = True)]
public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver
{
	public struct DualShock4HIDGenericInputReport
	{
		public byte leftStickX; //Field offset: 0x0
		public byte leftStickY; //Field offset: 0x1
		public byte rightStickX; //Field offset: 0x2
		public byte rightStickY; //Field offset: 0x3
		public byte buttons0; //Field offset: 0x4
		public byte buttons1; //Field offset: 0x5
		public byte buttons2; //Field offset: 0x6
		public byte leftTrigger; //Field offset: 0x7
		public byte rightTrigger; //Field offset: 0x8

		public static FourCC Format
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			 get { } //Length: 58
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public static FourCC get_Format() { }

		[CallerCount(Count = 0)]
		public DualShock4HIDInputReport ToHIDInputReport() { }

	}

	internal const byte JitterMaskLow = 120; //Field offset: 0x0
	internal const byte JitterMaskHigh = 135; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; //Field offset: 0x288
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; //Field offset: 0x298
	private Nullable<Single> m_LowFrequencyMotorSpeed; //Field offset: 0x2A0
	private Nullable<Single> m_HighFrequenceyMotorSpeed; //Field offset: 0x2A8
	private Nullable<Color> m_LightBarColor; //Field offset: 0x2B0

	public ButtonControl leftTriggerButton
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ButtonControl playStationButton
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ButtonControl rightTriggerButton
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DualShock4GamepadHID() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(DualShockGamepad), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_leftTriggerButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_playStationButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_rightTriggerButton() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputManager), Member = "DontMakeCurrentlyUpdatingDeviceCurrent", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public virtual void PauseHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public virtual void ResetHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public virtual void ResumeHaptics() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftTriggerButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_playStationButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightTriggerButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual void SetLightBarColor(Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualShockHIDOutputReport&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

}

