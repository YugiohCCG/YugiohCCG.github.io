namespace UnityEngine.InputSystem.EnhancedTouch;

public class Finger
{
	[CompilerGenerated]
	private readonly Touchscreen <screen>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <index>k__BackingField; //Field offset: 0x18
	internal readonly InputStateHistory<TouchState> m_StateHistory; //Field offset: 0x20

	public Touch currentTouch
	{
		[CalledBy(Type = typeof(Finger), Member = "get_isActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 564
	}

	public int index
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool isActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		 get { } //Length: 159
	}

	public Touch lastTouch
	{
		[CalledBy(Type = typeof(Finger), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 244
	}

	public Touchscreen screen
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Vector2 screenPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
		[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		 get { } //Length: 308
	}

	public TouchHistory touchHistory
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 117
	}

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "AddFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "set_historyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "set_extraMemoryPerRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "set_updateMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "StartRecording", ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchControl), Member = "get_isInProgress", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.InputSystem.LowLevel.TouchState>), Member = "get_value", ReturnType = typeof(TouchState&))]
	[Calls(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal Finger(Touchscreen screen, int index, InputUpdateType updateMask) { }

	[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateHistory`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<Record<TValue>>")]
	[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtrUnchecked", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private Touch FindTouch(uint uniqueId) { }

	[CalledBy(Type = typeof(Finger), Member = "get_isActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Touch get_currentTouch() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_index() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	public bool get_isActive() { }

	[CalledBy(Type = typeof(Finger), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallsUnknownMethods(Count = 4)]
	public Touch get_lastTouch() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Touchscreen get_screen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	public Vector2 get_screenPosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public TouchHistory get_touchHistory() { }

	[CalledBy(Type = typeof(Touch), Member = "get_history", ReturnType = typeof(TouchHistory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Touch), Member = "get_uniqueId", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Finger), Member = "FindTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Touch))]
	[Calls(Type = typeof(Record), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Touch), Member = "get_touchId", ReturnType = typeof(int))]
	[Calls(Type = typeof(Record), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(Record), Member = "get_previous", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 4)]
	internal TouchHistory GetTouchHistory(Touch touch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "GetRecordUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(InputStateHistory), Member = "get_bytesPerRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTouchRecorded(Record record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr) { }

}

