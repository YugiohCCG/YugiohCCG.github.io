namespace UnityEngine.InputSystem.Switch;

[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor
{
	private struct SwitchFullInputReport
	{
		public const int kSize = 25; //Field offset: 0x0
		public const byte ExpectedReportId = 48; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte buttons0; //Field offset: 0x3
		public byte buttons1; //Field offset: 0x4
		public byte buttons2; //Field offset: 0x5
		public byte left0; //Field offset: 0x6
		public byte left1; //Field offset: 0x7
		public byte left2; //Field offset: 0x8
		public byte right0; //Field offset: 0x9
		public byte right1; //Field offset: 0xA
		public byte right2; //Field offset: 0xB

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberHelpers), Member = "RemapUIntBitsToNormalizeFloatToUIntBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	private struct SwitchHIDGenericInputReport
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

	private struct SwitchInputOnlyReport
	{
		public const int kSize = 7; //Field offset: 0x0
		public byte buttons0; //Field offset: 0x0
		public byte buttons1; //Field offset: 0x1
		public byte hat; //Field offset: 0x2
		public byte leftX; //Field offset: 0x3
		public byte leftY; //Field offset: 0x4
		public byte rightX; //Field offset: 0x5
		public byte rightY; //Field offset: 0x6

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	public struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo
	{
		public const int kSize = 57; //Field offset: 0x0
		public InputDeviceCommand baseCommand; //Field offset: 0x0
		public SwitchMagicOutputReport report; //Field offset: 0x8

		public static FourCC Type
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			 get { } //Length: 58
		}

		public override FourCC typeStatic
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			 get { } //Length: 58
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public static SwitchMagicOutputHIDBluetooth Create(CommandIdType type) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public static FourCC get_Type() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override FourCC get_typeStatic() { }

	}

	public struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo
	{
		public const int kSize = 72; //Field offset: 0x0
		public InputDeviceCommand baseCommand; //Field offset: 0x0
		public SwitchMagicOutputReport report; //Field offset: 0x8

		public static FourCC Type
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			 get { } //Length: 58
		}

		public override FourCC typeStatic
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			 get { } //Length: 58
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public static SwitchMagicOutputHIDUSB Create(CommandIdType type) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public static FourCC get_Type() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override FourCC get_typeStatic() { }

	}

	public struct SwitchMagicOutputReport
	{
		internal enum CommandIdType
		{
			Status = 1,
			Handshake = 2,
			Highspeed = 3,
			ForceUSB = 4,
		}

		public enum ReportType
		{
			Magic = 128,
		}

		public const int kSize = 49; //Field offset: 0x0
		public const byte ExpectedReplyInputReportId = 129; //Field offset: 0x0
		public byte reportType; //Field offset: 0x0
		public byte commandId; //Field offset: 0x1

	}

	private struct SwitchSimpleInputReport
	{
		public const int kSize = 12; //Field offset: 0x0
		public const byte ExpectedReportId = 63; //Field offset: 0x0
		public byte reportId; //Field offset: 0x0
		public byte buttons0; //Field offset: 0x1
		public byte buttons1; //Field offset: 0x2
		public byte hat; //Field offset: 0x3
		public ushort leftX; //Field offset: 0x4
		public ushort leftY; //Field offset: 0x6
		public ushort rightX; //Field offset: 0x8
		public ushort rightY; //Field offset: 0xA

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberHelpers), Member = "RemapUIntBitsToNormalizeFloatToUIntBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[CallsUnknownMethods(Count = 1)]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	private static readonly CommandIdType[] s_HandshakeSequence; //Field offset: 0x0
	internal const byte JitterMaskLow = 120; //Field offset: 0x0
	internal const byte JitterMaskHigh = 135; //Field offset: 0x0
	[CompilerGenerated]
	private ButtonControl <captureButton>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private ButtonControl <homeButton>k__BackingField; //Field offset: 0x218
	private int m_HandshakeStepIndex; //Field offset: 0x220
	private double m_HandshakeTimer; //Field offset: 0x228

	[InputControl(name = "capture", displayName = "Capture")]
	public ButtonControl captureButton
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

	[InputControl(name = "home", displayName = "Home")]
	public ButtonControl homeButton
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SwitchProControllerHID() { }

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SwitchProControllerHID() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_captureButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_homeButton() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void HandshakeRestart() { }

	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchMagicOutputHIDBluetooth)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchMagicOutputHIDBluetooth&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchMagicOutputHIDUSB)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchMagicOutputHIDUSB&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void HandshakeTick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gamepad), Member = "OnAdded", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void OnAdded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SwitchProControllerHID), Member = "HandshakeTick", ReturnType = typeof(void))]
	public override void OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_stateFormat", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputManager), Member = "DontMakeCurrentlyUpdatingDeviceCurrent", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override bool PreProcessEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_captureButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_homeButton(ButtonControl value) { }

}

