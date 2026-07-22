namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(PointerState), isGenericTypeOfDevice = True)]
public class Pointer : InputDevice, IInputStateCallbackReceiver
{
	[CompilerGenerated]
	private static Pointer <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector2Control <position>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private DeltaControl <delta>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private Vector2Control <radius>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private AxisControl <pressure>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <press>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private IntegerControl <displayIndex>k__BackingField; //Field offset: 0x1B8

	public internal static Pointer current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal set { } //Length: 81
	}

	public DeltaControl delta
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

	public IntegerControl displayIndex
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

	public Vector2Control position
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ButtonControl press
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

	public AxisControl pressure
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

	public Vector2Control radius
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
	public Pointer() { }

	[CalledBy(Type = typeof(Mouse), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pen), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Pointer get_current() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DeltaControl get_delta() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_displayIndex() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Control get_position() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_press() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_pressure() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Control get_radius() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MakeCurrent() { }

	[CalledBy(Type = typeof(Mouse), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mouse), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pointer), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	protected void OnNextUpdate() { }

	[CalledBy(Type = typeof(Mouse), Member = "OnRemoved", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pen), Member = "OnRemoved", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnRemoved", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "AccumulateValueInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), typeof(Void*), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void set_current(Pointer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_delta(DeltaControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_displayIndex(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_position(Vector2Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_press(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_pressure(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_radius(Vector2Control value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "OnNextUpdate", ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "AccumulateValueInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), typeof(Void*), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

