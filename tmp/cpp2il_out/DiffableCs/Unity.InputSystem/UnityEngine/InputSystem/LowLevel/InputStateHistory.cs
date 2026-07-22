namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
public class InputStateHistory : IDisposable, IEnumerable<Record>, IEnumerable, IInputStateChangeMonitor
{
	private struct Enumerator : IEnumerator<Record>, IEnumerator, IDisposable
	{
		private readonly InputStateHistory m_History; //Field offset: 0x0
		private int m_Index; //Field offset: 0x8

		public override Record Current
		{
			[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 309
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Record))]
			private get { } //Length: 84
		}

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator(InputStateHistory history) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public override Record get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Record))]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal struct Record : IEquatable<Record>
	{
		private readonly InputStateHistory m_Owner; //Field offset: 0x0
		private readonly int m_IndexPlusOne; //Field offset: 0x8
		private uint m_Version; //Field offset: 0xC

		public InputControl control
		{
			[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
			[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 269
		}

		internal RecordHeader* header
		{
			[CalledBy(Type = typeof(Record), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 1)]
			internal get { } //Length: 37
		}

		public int index
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 65
		}

		public Record next
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 3)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 235
		}

		public InputStateHistory owner
		{
			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public Record previous
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 3)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 249
		}

		internal int recordIndex
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 6
		}

		public double time
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 57
		}

		public bool valid
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 70
		}

		internal uint version
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Record(InputStateHistory owner, int index, RecordHeader* header) { }

		[CalledBy(Type = typeof(Record), Member = "get_index", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Record), Member = "get_time", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(Record), Member = "get_control", ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(Record), Member = "get_next", ReturnType = typeof(Record))]
		[CalledBy(Type = typeof(Record), Member = "get_previous", ReturnType = typeof(Record))]
		[CalledBy(Type = typeof(Record), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(Record), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		internal void CheckValid() { }

		[CalledBy(Type = typeof(InputStateHistory), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Record)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateHistory), Member = "AddRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(Record))]
		[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Record), Member = "get_control", ReturnType = typeof(InputControl))]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		public void CopyFrom(Record record) { }

		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool Equals(Record other) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public InputControl get_control() { }

		[CalledBy(Type = typeof(Record), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 1)]
		internal RecordHeader* get_header() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public int get_index() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public Record get_next() { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public InputStateHistory get_owner() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public Record get_previous() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal int get_recordIndex() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 1)]
		public double get_time() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_valid() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal uint get_version() { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		public Void* GetUnsafeExtraMemoryPtr() { }

		[CalledBy(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtr", ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal Void* GetUnsafeExtraMemoryPtrUnchecked() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(Record), Member = "GetUnsafeMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		public Void* GetUnsafeMemoryPtr() { }

		[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtr", ReturnType = typeof(Void*))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Void* GetUnsafeMemoryPtrUnchecked() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(Record), Member = "get_header", ReturnType = typeof(RecordHeader*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public TValue ReadValue() { }

		[CalledBy(Type = typeof(Record), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public object ReadValueAsObject() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(Record), Member = "get_control", ReturnType = typeof(InputControl))]
		[Calls(Type = typeof(Record), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(Record), Member = "CheckValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		public virtual string ToString() { }

	}

	private struct RecordHeader
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <m_StateWithControlIndex>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <m_StateWithoutControlIndex>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		public const int kSizeWithControlIndex = 16; //Field offset: 0x0
		public const int kSizeWithoutControlIndex = 12; //Field offset: 0x0
		public double time; //Field offset: 0x0
		public uint version; //Field offset: 0x8
		public int controlIndex; //Field offset: 0xC
		[FixedBuffer(typeof(byte), 1)]
		private <m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex; //Field offset: 0xC
		[FixedBuffer(typeof(byte), 1)]
		private <m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex; //Field offset: 0x10

		public Byte* statePtrWithControlIndex
		{
			[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtrUnchecked", ReturnType = typeof(Void*))]
			[CallerCount(Count = 3)]
			 get { } //Length: 5
		}

		public Byte* statePtrWithoutControlIndex
		{
			[CallerCount(Count = 43)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		[CallerCount(Count = 3)]
		public Byte* get_statePtrWithControlIndex() { }

		[CallerCount(Count = 43)]
		[DeduplicatedMethod]
		public Byte* get_statePtrWithoutControlIndex() { }

	}

	private const int kDefaultHistorySize = 128; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Record> <onRecordAdded>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Func<InputControl, Double, InputEventPtr, Boolean> <onShouldRecordStateChange>k__BackingField; //Field offset: 0x18
	internal InputControl[] m_Controls; //Field offset: 0x20
	internal int m_ControlCount; //Field offset: 0x28
	private NativeArray<Byte> m_RecordBuffer; //Field offset: 0x30
	private int m_StateSizeInBytes; //Field offset: 0x40
	private int m_RecordCount; //Field offset: 0x44
	private int m_HistoryDepth; //Field offset: 0x48
	private int m_ExtraMemoryPerRecord; //Field offset: 0x4C
	internal int m_HeadIndex; //Field offset: 0x50
	internal uint m_CurrentVersion; //Field offset: 0x54
	private Nullable<InputUpdateType> m_UpdateMask; //Field offset: 0x58
	internal readonly bool m_AddNewControls; //Field offset: 0x60

	internal int bytesPerRecord
	{
		[CalledBy(Type = typeof(Finger), Member = "OnTouchRecorded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		[CallerCount(Count = 4)]
		internal get { } //Length: 63
	}

	public ReadOnlyArray<InputControl> controls
	{
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(Record), Member = "get_control", ReturnType = "UnityEngine.InputSystem.InputControl`1<TValue>")]
		[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtrUnchecked", ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 95
	}

	public override int Count
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int extraMemoryPerRecord
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 215
	}

	public int historyDepth
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 215
	}

	public Record Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 280
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
		[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 313
	}

	public Action<Record> onRecordAdded
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Func<InputControl, Double, InputEventPtr, Boolean> onShouldRecordStateChange
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public InputUpdateType updateMask
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 146
		[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 185
	}

	public uint version
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputStateHistory(IEnumerable<InputControl> controls) { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public InputStateHistory(InputControl control) { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystem), Member = "FindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(InputControlList`1), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TControl[]")]
	[Calls(Type = typeof(InputControlList`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public InputStateHistory(string path) { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public InputStateHistory(int maxStateSizeInBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "AllocateRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public Record AddRecord(Record record) { }

	[CalledBy(Type = typeof(InputStateHistory), Member = "AllocateRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(RecordHeader*))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Allocate() { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "AddRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(Record))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(double)}, ReturnType = typeof(Record))]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "AddRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputStateHistory), Member = "Allocate", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected private RecordHeader* AllocateRecord(out int index) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void Clear() { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	protected void Destroy() { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "RemoveFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "Destroy", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputStateHistory), Member = "StopRecording", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputStateHistory), Member = "StopRecording", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(Finger), Member = "OnTouchRecorded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Record), Member = "GetUnsafeExtraMemoryPtrUnchecked", ReturnType = typeof(Void*))]
	[CallerCount(Count = 4)]
	internal int get_bytesPerRecord() { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(Record), Member = "get_control", ReturnType = "UnityEngine.InputSystem.InputControl`1<TValue>")]
	[CalledBy(Type = typeof(Record), Member = "GetUnsafeMemoryPtrUnchecked", ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReadOnlyArray<InputControl> get_controls() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public int get_extraMemoryPerRecord() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public int get_historyDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public Record get_Item(int index) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<Record> get_onRecordAdded() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<InputControl, Double, InputEventPtr, Boolean> get_onShouldRecordStateChange() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public InputUpdateType get_updateMask() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public uint get_version() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator<Record> GetEnumerator() { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected private RecordHeader* GetRecord(int index) { }

	[CalledBy(Type = typeof(Finger), Member = "OnTouchRecorded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal RecordHeader* GetRecordUnchecked(int index) { }

	[CalledBy(Type = typeof(Record), Member = "ReadValue", ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateHistory), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(RecordHeader), Member = "get_statePtrWithControlIndex", ReturnType = typeof(Byte*))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.InputSystem.LowLevel.TouchState>), Member = "ReadValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(TouchState))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetNiceTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected TValue ReadValue(RecordHeader* data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected object ReadValueAsObject(RecordHeader* data) { }

	[CalledBy(Type = typeof(Record), Member = "get_index", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Record), Member = "get_next", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CalledBy(Type = typeof(Record), Member = "get_previous", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 3)]
	protected private int RecordIndexToUserIndex(int index) { }

	[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(double)}, ReturnType = typeof(Record))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public Record RecordStateChange(InputControl control, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Record))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(double), typeof(InputEventPtr), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateHistory), Member = "AllocateRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public Record RecordStateChange(InputControl control, Void* statePtr, double time) { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void set_extraMemoryPerRecord(int value) { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void set_historyDepth(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateHistory), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RecordHeader*))]
	[Calls(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void set_Item(int index, Record value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_onRecordAdded(Action<Record> value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_onShouldRecordStateChange(Func<InputControl, Double, InputEventPtr, Boolean> value) { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_updateMask(InputUpdateType value) { }

	[CalledBy(Type = typeof(Finger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen), typeof(int), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void StartRecording() { }

	[CalledBy(Type = typeof(InputStateHistory), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputManager), Member = "RemoveStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void StopRecording() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(double)}, ReturnType = typeof(Record))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Record), Member = "get_next", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CalledBy(Type = typeof(Record), Member = "get_previous", ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected private int UserIndexToRecordIndex(int index) { }

}

