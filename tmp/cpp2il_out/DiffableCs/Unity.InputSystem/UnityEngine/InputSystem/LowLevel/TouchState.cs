namespace UnityEngine.InputSystem.LowLevel;

public struct TouchState : IInputStateTypeInfo
{
	internal const int kSizeInBytes = 56; //Field offset: 0x0
	[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = True, dontReset = True)]
	public int touchId; //Field offset: 0x0
	[InputControl(displayName = "Position", dontReset = True)]
	public Vector2 position; //Field offset: 0x4
	[InputControl(displayName = "Delta", layout = "Delta")]
	public Vector2 delta; //Field offset: 0xC
	[InputControl(displayName = "Pressure", layout = "Axis")]
	public float pressure; //Field offset: 0x14
	[InputControl(displayName = "Radius")]
	public Vector2 radius; //Field offset: 0x18
	[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = True)]
	[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
	public byte phaseId; //Field offset: 0x20
	[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
	public byte tapCount; //Field offset: 0x21
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	public byte displayIndex; //Field offset: 0x22
	[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0, synthetic = True)]
	[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4)]
	public byte flags; //Field offset: 0x23
	internal uint updateStepCount; //Field offset: 0x24
	[InputControl(displayName = "Start Time", layout = "Double", synthetic = True)]
	public double startTime; //Field offset: 0x28
	[InputControl(displayName = "Start Position", synthetic = True)]
	public Vector2 startPosition; //Field offset: 0x30

	internal bool beganInSameFrame
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 33
	}

	public override FourCC format
	{
		[CalledBy(Type = typeof(InputSystem), Member = "QueueStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState", typeof(double)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public static FourCC Format
	{
		[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touchscreen), Member = "MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public bool isIndirectTouch
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 33
	}

	public bool isInProgress
	{
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public bool isNoneEndedOrCanceled
	{
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	internal bool isOrphanedPrimaryTouch
	{
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		internal set { } //Length: 33
	}

	public bool isPrimaryTouch
	{
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 set { } //Length: 33
	}

	public bool isTap
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 33
	}

	internal bool isTapPress
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		internal set { } //Length: 33
	}

	internal bool isTapRelease
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touchscreen), Member = "TriggerTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchControl), typeof(TouchState&), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		internal set { } //Length: 33
	}

	public TouchPhase phase
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_beganInSameFrame() { }

	[CalledBy(Type = typeof(InputSystem), Member = "QueueStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState", typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_format() { }

	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touchscreen), Member = "MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Format() { }

	[CallerCount(Count = 0)]
	public bool get_isIndirectTouch() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_isInProgress() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_isNoneEndedOrCanceled() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_isOrphanedPrimaryTouch() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isPrimaryTouch() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isTap() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_isTapPress() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isTapRelease() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TouchPhase get_phase() { }

	[CallerCount(Count = 0)]
	internal void set_beganInSameFrame(bool value) { }

	[CallerCount(Count = 0)]
	public void set_isIndirectTouch(bool value) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal void set_isOrphanedPrimaryTouch(bool value) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public void set_isPrimaryTouch(bool value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_isTap(bool value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal void set_isTapPress(bool value) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "TriggerTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchControl), typeof(TouchState&), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal void set_isTapRelease(bool value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_phase(TouchPhase value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

