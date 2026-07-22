namespace UnityEngine.InputSystem.LowLevel;

public struct InputEventBuffer : IEnumerable<InputEventPtr>, IEnumerable, IDisposable, ICloneable
{
	private struct Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		private readonly InputEvent* m_Buffer; //Field offset: 0x0
		private readonly int m_EventCount; //Field offset: 0x8
		private InputEvent* m_CurrentEvent; //Field offset: 0x10
		private int m_CurrentIndex; //Field offset: 0x18

		public override InputEventPtr Current
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 69
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Enumerator(InputEventBuffer buffer) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public override InputEventPtr get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	public const long BufferSizeUnknown = -1; //Field offset: 0x0
	private NativeArray<Byte> m_Buffer; //Field offset: 0x0
	private long m_SizeInBytes; //Field offset: 0x10
	private int m_EventCount; //Field offset: 0x18
	private bool m_WeOwnTheBuffer; //Field offset: 0x1C

	public InputEventPtr bufferPtr
	{
		[CalledBy(Type = "UnityEngine.InputSystem.Utilities.InputActionTrace+Enumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionTrace)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.Utilities.InputActionTrace+ActionEventPtr>))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 68
	}

	public long capacityInBytes
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime+<>c__DisplayClass7_0", Member = "<set_onUpdate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngineInternal.Input.NativeInputUpdateType", typeof(NativeInputEventBuffer*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 61
	}

	public NativeArray<Byte> data
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	public int eventCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public long sizeInBytes
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(InputEventStream), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime+<>c__DisplayClass7_0", Member = "<set_onUpdate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngineInternal.Input.NativeInputUpdateType", typeof(NativeInputEventBuffer*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public InputEventBuffer(NativeArray<Byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = false) { }

	[CalledBy(Type = typeof(InputEventStream), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(InputEvent*))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	internal void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) { }

	[CalledBy(Type = typeof(InputEventBuffer), Member = "AppendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "set_sizeInBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventBuffer), Member = "AllocateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	[CalledBy(Type = typeof(InputEventBuffer), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	public InputEventBuffer Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Contains(InputEvent* eventPtr) { }

	[CalledBy(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.InputActionTrace+Enumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionTrace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.Utilities.InputActionTrace+ActionEventPtr>))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputEventPtr get_bufferPtr() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime+<>c__DisplayClass7_0", Member = "<set_onUpdate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngineInternal.Input.NativeInputUpdateType", typeof(NativeInputEventBuffer*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public long get_capacityInBytes() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public NativeArray<Byte> get_data() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_eventCount() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public long get_sizeInBytes() { }

	[CalledBy(Type = typeof(InputEventBuffer), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override IEnumerator<InputEventPtr> GetEnumerator() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime+<>c__DisplayClass7_0", Member = "<set_onUpdate>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngineInternal.Input.NativeInputUpdateType", typeof(NativeInputEventBuffer*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventBuffer), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventBuffer), Member = "Clone", ReturnType = typeof(InputEventBuffer))]
	private override object System.ICloneable.Clone() { }

}

