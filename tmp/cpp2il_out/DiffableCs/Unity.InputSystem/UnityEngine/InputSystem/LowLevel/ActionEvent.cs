namespace UnityEngine.InputSystem.LowLevel;

internal struct ActionEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_ValueData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public InputEvent baseEvent; //Field offset: 0x0
	private ushort m_ControlIndex; //Field offset: 0x14
	private ushort m_BindingIndex; //Field offset: 0x16
	private ushort m_InteractionIndex; //Field offset: 0x18
	private byte m_StateIndex; //Field offset: 0x1A
	private byte m_Phase; //Field offset: 0x1B
	private double m_StartTime; //Field offset: 0x1C
	[FixedBuffer(typeof(byte), 1)]
	public <m_ValueData>e__FixedBuffer m_ValueData; //Field offset: 0x24

	public int bindingIndex
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 103
	}

	public int controlIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 103
	}

	public int interactionIndex
	{
		[CalledBy(Type = typeof(ActionEventPtr), Member = "get_interaction", ReturnType = typeof(IInputInteraction))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		 get { } //Length: 22
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 119
	}

	public InputActionPhase phase
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public double startTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 6
	}

	public int stateIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 102
	}

	public static FourCC Type
	{
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public override FourCC typeStatic
	{
		[CalledBy(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOtherEvent"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public Byte* valueData
	{
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 get { } //Length: 5
	}

	public int valueSizeInBytes
	{
		[CalledBy(Type = typeof(ActionEventPtr), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CallerCount(Count = 4)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOtherEvent"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static ActionEvent* From(InputEventPtr ptr) { }

	[CallerCount(Count = 0)]
	public int get_bindingIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_controlIndex() { }

	[CalledBy(Type = typeof(ActionEventPtr), Member = "get_interaction", ReturnType = typeof(IInputInteraction))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	public int get_interactionIndex() { }

	[CallerCount(Count = 0)]
	public InputActionPhase get_phase() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double get_startTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_stateIndex() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Type() { }

	[CalledBy(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOtherEvent"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public Byte* get_valueData() { }

	[CalledBy(Type = typeof(ActionEventPtr), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 4)]
	public int get_valueSizeInBytes() { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_bindingIndex(int value) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_controlIndex(int value) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_interactionIndex(int value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_phase(InputActionPhase value) { }

	[CallerCount(Count = 0)]
	public void set_startTime(double value) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_stateIndex(int value) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public InputEventPtr ToEventPtr() { }

}

