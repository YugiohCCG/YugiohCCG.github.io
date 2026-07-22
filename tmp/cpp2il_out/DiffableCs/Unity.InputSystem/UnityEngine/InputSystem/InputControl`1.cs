namespace UnityEngine.InputSystem;

public abstract class InputControl : InputControl
{
	internal InlinedArray<InputProcessor`1<TValue>> m_ProcessorStack; //Field offset: 0x0
	private TValue m_CachedValue; //Field offset: 0x0
	private TValue m_UnprocessedCachedValue; //Field offset: 0x0
	internal bool evaluateProcessorsEveryRead; //Field offset: 0x0

	internal InputProcessor<TValue>[] processors
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(Object[]))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 95
	}

	[IsReadOnly]
	internal TValue unprocessedValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 214
	}

	[IsReadOnly]
	public TValue value
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 259
	}

	public virtual int valueSizeInBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual Type valueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		 get { } //Length: 56
	}

	[CalledBy(Type = typeof(PoseControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EyesControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AxisControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DoubleControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IntegerControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuaternionControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchPhaseControl), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector2Control), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3Control), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected InputControl`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	internal virtual void AddProcessor(object processor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool CompareValue(ref TValue firstValue, ref TValue secondValue) { }

	[CalledBy(Type = typeof(BoneControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal InputProcessor<TValue>[] get_processors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal TValue get_unprocessedValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public TValue get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_valueSizeInBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public virtual Type get_valueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void ProcessValue(ref TValue value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue ProcessValue(TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TValue ReadDefaultValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue ReadUnprocessedValue() { }

	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TValue ReadUnprocessedValueFromStateWithCaching(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue ReadValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public virtual object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_previousFrameStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TValue ReadValueFromPreviousFrame() { }

	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TValue ReadValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public virtual object ReadValueFromStateAsObject(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public virtual void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public TValue ReadValueFromStateWithCaching(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	internal TProcessor TryGetProcessor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void WriteValueIntoState(TValue value, Void* statePtr) { }

}

