namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver
{
	public struct DualSenseHIDBluetoothInputReport
	{
		public const int ExpectedReportId = 49; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x2
		public byte leftStickY; //Field offset: 0x3
		public byte rightStickX; //Field offset: 0x4
		public byte rightStickY; //Field offset: 0x5
		public byte leftTrigger; //Field offset: 0x6
		public byte rightTrigger; //Field offset: 0x7
		public byte buttons0; //Field offset: 0x9
		public byte buttons1; //Field offset: 0xA
		public byte buttons2; //Field offset: 0xB

		[CallerCount(Count = 0)]
		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	public struct DualSenseHIDGenericInputReport
	{
		public byte reportId; //Field offset: 0x0

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

	}

	public struct DualSenseHIDMinimalInputReport
	{
		public static int ExpectedSize1; //Field offset: 0x0
		public static int ExpectedSize2; //Field offset: 0x4
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x1
		public byte leftStickY; //Field offset: 0x2
		public byte rightStickX; //Field offset: 0x3
		public byte rightStickY; //Field offset: 0x4
		public byte buttons0; //Field offset: 0x5
		public byte buttons1; //Field offset: 0x6
		public byte buttons2; //Field offset: 0x7
		public byte leftTrigger; //Field offset: 0x8
		public byte rightTrigger; //Field offset: 0x9

		[CallerCount(Count = 0)]
		private static DualSenseHIDMinimalInputReport() { }

		[CallerCount(Count = 0)]
		public DualSenseHIDInputReport ToHIDInputReport() { }

	}

	public struct DualSenseHIDUSBInputReport
	{
		public const int ExpectedReportId = 1; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte leftStickX; //Field offset: 0x1
		public byte leftStickY; //Field offset: 0x2
		public byte rightStickX; //Field offset: 0x3
		public byte rightStickY; //Field offset: 0x4
		public byte leftTrigger; //Field offset: 0x5
		public byte rightTrigger; //Field offset: 0x6
		public byte buttons0; //Field offset: 0x8
		public byte buttons1; //Field offset: 0x9
		public byte buttons2; //Field offset: 0xA

		[CallerCount(Count = 0)]
		public DualSenseHIDInputReport ToHIDInputReport() { }

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
	protected Nullable<Color> m_LightBarColor; //Field offset: 0x2B0
	private byte outputSequenceId; //Field offset: 0x2C4

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
	public DualSenseGamepadHID() { }

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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState) { }

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
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeedsAndLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	public virtual void PauseHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeedsAndLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	public virtual void ResetHaptics() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeedsAndLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
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
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeedsAndLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	public virtual void SetLightBarColor(Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeedsAndLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<System.Single>), typeof(System.Nullable`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency) { }

	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "PauseHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "ResetHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "ResumeHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "SetLightBarColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "SetMotorSpeeds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualSenseHIDUSBOutputReport)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualSenseHIDUSBOutputReport&)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public bool SetMotorSpeedsAndLightBarColor(Nullable<Single> lowFrequency, Nullable<Single> highFrequency, Nullable<Color> color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr) { }

}

