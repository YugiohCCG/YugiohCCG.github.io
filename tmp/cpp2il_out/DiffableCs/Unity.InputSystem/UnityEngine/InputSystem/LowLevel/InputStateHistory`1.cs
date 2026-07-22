namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
public class InputStateHistory : InputStateHistory, IReadOnlyList<Record<TValue>>, IEnumerable<Record<TValue>>, IEnumerable, IReadOnlyCollection<Record<TValue>>
{
	private struct Enumerator : IEnumerator<Record<TValue>>, IEnumerator, IDisposable
	{
		private readonly InputStateHistory<TValue> m_History; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override Record<TValue> Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 109
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			private get { } //Length: 190
		}

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator(InputStateHistory<TValue> history) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override Record<TValue> get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct Record : IEquatable<Record<TValue>>
	{
		private readonly InputStateHistory<TValue> m_Owner; //Field offset: 0x0
		private readonly int m_IndexPlusOne; //Field offset: 0x0
		private uint m_Version; //Field offset: 0x0

		public InputControl<TValue> control
		{
			[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
			[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 11)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 580
		}

		internal RecordHeader* header
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 70
		}

		public int index
		{
			[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			 get { } //Length: 123
		}

		public Record<TValue> next
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 296
		}

		public InputStateHistory<TValue> owner
		{
			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public Record<TValue> previous
		{
			[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 292
		}

		internal int recordIndex
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 6
		}

		public double time
		{
			[CalledBy(Type = typeof(Touch), Member = "get_time", ReturnType = typeof(double))]
			[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			 get { } //Length: 155
		}

		public bool valid
		{
			[CalledBy(Type = typeof(Finger), Member = "get_isActive", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(Finger), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[CalledBy(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
			[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
			[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Touch), Member = "get_valid", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(Touch), Member = "get_history", ReturnType = typeof(TouchHistory))]
			[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 3)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 138
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Record(InputStateHistory<TValue> owner, int index) { }

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Record(InputStateHistory<TValue> owner, int index, RecordHeader* header) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private void CheckValid() { }

		[CalledBy(Type = typeof(InputStateHistory`1), Member = "AddRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CalledBy(Type = typeof(InputStateHistory`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		public void CopyFrom(Record<TValue> record) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Equals(Record<TValue> other) { }

		[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public InputControl<TValue> get_control() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal RecordHeader* get_header() { }

		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public int get_index() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public Record<TValue> get_next() { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public InputStateHistory<TValue> get_owner() { }

		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory), Member = "RecordIndexToUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public Record<TValue> get_previous() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal int get_recordIndex() { }

		[CalledBy(Type = typeof(Touch), Member = "get_time", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public double get_time() { }

		[CalledBy(Type = typeof(Finger), Member = "get_isActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Finger), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveFingers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Touch), Member = "get_valid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "get_history", ReturnType = typeof(TouchHistory))]
		[CalledBy(Type = typeof(Touch), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_valid() { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

		[CalledBy(Type = typeof(Touch), Member = "get_uniqueId", ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(Touch), Member = "get_extraData", ReturnType = typeof(ExtraDataPerTouchState&))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Void* GetUnsafeExtraMemoryPtr() { }

		[CalledBy(Type = typeof(Finger), Member = "FindTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Touch))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InputStateHistory), Member = "get_bytesPerRecord", ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

		[CalledBy(Type = typeof(Touch), Member = "get_startTime", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(Touch), Member = "get_displayIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Touch), Member = "get_isTap", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Touch), Member = "get_tapCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Touch), Member = "get_delta", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Touch), Member = "get_startScreenPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Touch), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Touch), Member = "get_updateStepCount", ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(Touch), Member = "get_radius", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Touch), Member = "get_touchId", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Finger), Member = "GetTouchHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch)}, ReturnType = typeof(TouchHistory))]
		[CalledBy(Type = typeof(Finger), Member = "get_currentTouch", ReturnType = typeof(Touch))]
		[CalledBy(Type = typeof(Finger), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(Touch), Member = "get_pressure", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Touch), Member = "get_state", ReturnType = typeof(TouchState&))]
		[CallerCount(Count = 18)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Void* GetUnsafeMemoryPtr() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(RecordHeader), Member = "get_statePtrWithControlIndex", ReturnType = typeof(Byte*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal Void* GetUnsafeMemoryPtrUnchecked() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public TValue ReadValue() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "get_control", ReturnType = "UnityEngine.InputSystem.InputControl`1<TValue>")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public virtual string ToString() { }

	}


	public override Record<TValue> Item
	{
		[CalledBy(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
		[CalledBy(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 297
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 set { } //Length: 353
	}

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public InputStateHistory`1(Nullable<Int32> maxStateSizeInBytes = null) { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public InputStateHistory`1(InputControl<TValue> control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetNiceTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	public InputStateHistory`1(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "AllocateRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Record<TValue> AddRecord(Record<TValue> record) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "Destroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "Finalize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(Finger), Member = "get_lastTouch", ReturnType = typeof(Touch))]
	[CalledBy(Type = typeof(TouchHistory), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override Record<TValue> get_Item(int index) { }

	[CalledBy(Type = typeof(Finger), Member = "FindTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Touch))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator<Record<TValue>> GetEnumerator() { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(StateEvent*))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputEventPtr), Member = "set_time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Record))]
	[Calls(Type = typeof(Record), Member = "get_header", ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public Record<TValue> RecordStateChange(InputControl<TValue> control, TValue value, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "UserIndexToRecordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void set_Item(int index, Record<TValue> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

