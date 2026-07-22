namespace UnityEngine.InputSystem.LowLevel;

public sealed class InputEventTrace : IDisposable, IEnumerable<InputEventPtr>, IEnumerable
{
	internal struct DeviceInfo
	{
		[SerializeField]
		internal int m_DeviceId; //Field offset: 0x0
		[SerializeField]
		internal string m_Layout; //Field offset: 0x8
		[SerializeField]
		internal FourCC m_StateFormat; //Field offset: 0x10
		[SerializeField]
		internal int m_StateSizeInBytes; //Field offset: 0x14
		[SerializeField]
		internal string m_FullLayoutJson; //Field offset: 0x18

		public int deviceId
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public string layout
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public FourCC stateFormat
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public int stateSizeInBytes
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public int get_deviceId() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public string get_layout() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public FourCC get_stateFormat() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_stateSizeInBytes() { }

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public void set_deviceId(int value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void set_layout(string value) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public void set_stateFormat(FourCC value) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public void set_stateSizeInBytes(int value) { }

	}

	private class Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		private InputEventTrace m_Trace; //Field offset: 0x10
		private int m_ChangeCounter; //Field offset: 0x18
		internal InputEventPtr m_Current; //Field offset: 0x20

		public override InputEventPtr Current
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 69
		}

		[CalledBy(Type = typeof(InputEventTrace), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Enumerator(InputEventTrace trace) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public override InputEventPtr get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventTrace), Member = "GetNextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Flags]
	private enum FileFlags
	{
		FixedUpdate = 1,
	}

	internal class ReplayController : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Comparison<InputEventPtr> <>9__38_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputEventPtr), Member = "get_time", ReturnType = typeof(double))]
			[Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
			internal int <PlayAllEventsAccordingToTimestamps>b__38_0(InputEventPtr a, InputEventPtr b) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			public int originalDeviceId; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass43_0() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal bool <ApplyDeviceMapping>b__0(DeviceInfo x) { }

		}

		[CompilerGenerated]
		private bool <finished>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <paused>k__BackingField; //Field offset: 0x11
		[CompilerGenerated]
		private int <position>k__BackingField; //Field offset: 0x14
		private InputEventTrace m_EventTrace; //Field offset: 0x18
		private Enumerator m_Enumerator; //Field offset: 0x20
		private InlinedArray<KeyValuePair`2<Int32, Int32>> m_DeviceIDMappings; //Field offset: 0x28
		private bool m_CreateNewDevices; //Field offset: 0x40
		private InlinedArray<InputDevice> m_CreatedDevices; //Field offset: 0x48
		private Action m_OnFinished; //Field offset: 0x60
		private Action<InputEventPtr> m_OnEvent; //Field offset: 0x68
		private double m_StartTimeAsPerFirstEvent; //Field offset: 0x70
		private double m_StartTimeAsPerRuntime; //Field offset: 0x78
		private int m_AllEventsByTimeIndex; //Field offset: 0x80
		private List<InputEventPtr> m_AllEventsByTime; //Field offset: 0x88

		public IEnumerable<InputDevice> createdDevices
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 80
		}

		public private bool finished
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 370
		}

		public bool paused
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public private int position
		{
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public InputEventTrace trace
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(InputEventTrace), Member = "Replay", ReturnType = typeof(ReplayController))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal ReplayController(InputEventTrace trace) { }

		[CalledBy(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputEventTrace), Member = "get_deviceInfos", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.LowLevel.InputEventTrace+DeviceInfo>))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.LowLevel.InputEventTrace+DeviceInfo>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<UnityEngine.InputSystem.LowLevel.InputEventTrace+DeviceInfo>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.LowLevel.InputEventTrace+DeviceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DeviceInfo))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection), Member = "HasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputDevice))]
		[Calls(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private int ApplyDeviceMapping(int originalDeviceId) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Object>))]
		[Calls(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		public override void Dispose() { }

		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEvents", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "OnBeginFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		private void Finished() { }

		[CallerCount(Count = 0)]
		public IEnumerable<InputDevice> get_createdDevices() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_finished() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_paused() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_position() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public InputEventTrace get_trace() { }

		[CalledBy(Type = typeof(ReplayController), Member = "PlayOneEvent", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEvents", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEventsAccordingToTimestamps", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "OnBeginFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(InputEventTrace), Member = "GetNextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(InputEventTrace), Member = "get_FrameMarkerEvent", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_internalTime", ReturnType = typeof(double))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		private bool MoveNext(bool skipFrameEvents, out InputEventPtr eventPtr) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(InputEventTrace), Member = "get_FrameMarkerEvent", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReplayController), Member = "Finished", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private void OnBeginFrame() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ReplayController OnEvent(Action<InputEventPtr> action) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ReplayController OnFinished(Action action) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReplayController), Member = "Finished", ReturnType = typeof(void))]
		[Calls(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ReplayController PlayAllEvents() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public ReplayController PlayAllEventsAccordingToTimestamps() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public ReplayController PlayAllFramesOneByOne() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReplayController), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public ReplayController PlayOneEvent() { }

		[CalledBy(Type = typeof(ReplayController), Member = "PlayOneEvent", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "PlayAllEvents", ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "OnBeginFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InputEventPtr), Member = "get_internalTime", ReturnType = typeof(double))]
		[Calls(Type = typeof(InputEventPtr), Member = "set_internalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_id", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_deviceId", ReturnType = typeof(int))]
		[Calls(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputEventPtr), Member = "set_deviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventPtr), Member = "set_id", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private void QueueEvent(InputEventPtr eventPtr) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public ReplayController Rewind() { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_finished(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_paused(bool value) { }

		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_position(int value) { }

		[CallerCount(Count = 0)]
		public ReplayController WithAllDevicesMappedToNewInstances() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public ReplayController WithDeviceMappedFromTo(InputDevice recordedDevice, InputDevice playbackDevice) { }

		[CalledBy(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDevice)}, ReturnType = typeof(ReplayController))]
		[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InlinedArray`1), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InlinedArray`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		public ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId) { }

	}

	private const int kDefaultBufferSize = 1048576; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputEvenTraceMarker; //Field offset: 0x0
	private static int kFileVersion; //Field offset: 0x8
	private int m_ChangeCounter; //Field offset: 0x10
	private bool m_Enabled; //Field offset: 0x14
	private Func<InputEventPtr, InputDevice, Boolean> m_OnFilterEvent; //Field offset: 0x18
	[SerializeField]
	private int m_DeviceId; //Field offset: 0x20
	private CallbackArray<Action`1<InputEventPtr>> m_EventListeners; //Field offset: 0x28
	[SerializeField]
	private long m_EventBufferSize; //Field offset: 0x78
	[SerializeField]
	private long m_MaxEventBufferSize; //Field offset: 0x80
	[SerializeField]
	private long m_GrowIncrementSize; //Field offset: 0x88
	[SerializeField]
	private long m_EventCount; //Field offset: 0x90
	[SerializeField]
	private long m_EventSizeInBytes; //Field offset: 0x98
	[SerializeField]
	private ulong m_EventBufferStorage; //Field offset: 0xA0
	[SerializeField]
	private ulong m_EventBufferHeadStorage; //Field offset: 0xA8
	[SerializeField]
	private ulong m_EventBufferTailStorage; //Field offset: 0xB0
	[SerializeField]
	private bool m_HasWrapped; //Field offset: 0xB8
	[SerializeField]
	private bool m_RecordFrameMarkers; //Field offset: 0xB9
	[SerializeField]
	private DeviceInfo[] m_DeviceInfos; //Field offset: 0xC0

	public event Action<InputEventPtr> onEvent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 73
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 73
	}

	public long allocatedSizeInBytes
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 18
	}

	public int deviceId
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ReadOnlyArray<DeviceInfo> deviceInfos
	{
		[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
		 get { } //Length: 90
	}

	public bool enabled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public long eventCount
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public static FourCC FrameMarkerEvent
	{
		[CalledBy(Type = typeof(ReplayController), Member = "OnBeginFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	private static FourCC kFileFormat
	{
		[CalledBy(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		private get { } //Length: 58
	}

	private Byte* m_EventBuffer
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	private Byte* m_EventBufferHead
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	private Byte* m_EventBufferTail
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public long maxSizeInBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Func<InputEventPtr, InputDevice, Boolean> onFilterEvent
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool recordFrameMarkers
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		 set { } //Length: 223
	}

	public long totalEventSizeInBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputEventTrace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputEventTrace(long bufferSizeInBytes = 1048576, bool growBuffer = false, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public InputEventTrace(InputDevice device, long bufferSizeInBytes = 1048576, bool growBuffer = false, long maxBufferSizeInBytes = -1, long growIncrementSizeInBytes = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onEvent(Action<InputEventPtr> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	private void Allocate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "Replay", ReturnType = typeof(ReplayController))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Disable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventTrace), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Enable() { }

	[CallerCount(Count = 0)]
	public long get_allocatedSizeInBytes() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_deviceId() { }

	[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
	public ReadOnlyArray<DeviceInfo> get_deviceInfos() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_enabled() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public long get_eventCount() { }

	[CalledBy(Type = typeof(ReplayController), Member = "OnBeginFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_FrameMarkerEvent() { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	private static FourCC get_kFileFormat() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private Byte* get_m_EventBuffer() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	private Byte* get_m_EventBufferHead() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private Byte* get_m_EventBufferTail() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public long get_maxSizeInBytes() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Func<InputEventPtr, InputDevice, Boolean> get_onFilterEvent() { }

	[CallerCount(Count = 0)]
	public bool get_recordFrameMarkers() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public long get_totalEventSizeInBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventTrace)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override IEnumerator<InputEventPtr> GetEnumerator() { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReplayController), Member = "MoveNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputEventPtr&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public bool GetNextEvent(ref InputEventPtr current) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static InputEventTrace LoadFrom(string filePath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static InputEventTrace LoadFrom(Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnBeforeUpdate() { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "OnBeforeUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputEventTrace), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Collection), Member = "IsGeneratedLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "LoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(InputControlLayout), Member = "ToJson", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceInfo)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceInfo[]&), typeof(DeviceInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`1<TValue>>&", "TValue", typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void OnInputEvent(InputEventPtr inputEvent, InputDevice device) { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "LoadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputEventTrace))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "LoadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(InputEventTrace))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventTrace), Member = "get_kFileFormat", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 34)]
	public void ReadFrom(Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(InputEventTrace), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void ReadFrom(string filePath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onEvent(Action<InputEventPtr> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventTrace), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReplayController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventTrace)}, ReturnType = typeof(void))]
	public ReplayController Replay() { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool Resize(long newBufferSize, long newMaxBufferSize = -1) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_deviceId(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void set_m_EventBuffer(Byte* value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void set_m_EventBufferHead(Byte* value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void set_m_EventBufferTail(Byte* value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_onFilterEvent(Func<InputEventPtr, InputDevice, Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void set_recordFrameMarkers(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventTrace)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "OpenWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(InputEventTrace), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void WriteTo(string filePath) { }

	[CalledBy(Type = typeof(InputEventTrace), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventTrace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public void WriteTo(Stream stream) { }

}

