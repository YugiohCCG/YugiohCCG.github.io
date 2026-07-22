namespace UnityEngine.InputSystem;

public sealed class InputRemoting : IObservable<Message>, IObserver<Message>
{
	private static class ChangeUsageMsg
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<InternedString, String> <>9__1_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = "UnityEngine.InputSystem.InputManager+<ListControlLayouts>d__100", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 7)]
			[CallsUnknownMethods(Count = 2)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <Create>b__1_0(InternedString x) { }

		}

		internal struct Data
		{
			public int deviceId; //Field offset: 0x0
			public String[] usages; //Field offset: 0x8

		}


		[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(InputRemoting), Member = "SerializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+Data"}, ReturnType = typeof(Byte[]))]
		[CallsUnknownMethods(Count = 4)]
		public static Message Create(InputDevice device) { }

		[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputRemoting), Member = "DeserializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+Data")]
		[Calls(Type = typeof(InputRemoting), Member = "TryGetDeviceByRemoteId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(InputDevice))]
		[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	private static class ConnectMsg
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputRemoting), Member = "StartSending", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public static void Process(InputRemoting receiver) { }

	}

	private static class DisconnectMsg
	{

		[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputRemoting), Member = "StopSending", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Flags]
	private enum Flags
	{
		Sending = 1,
		StartSendingOnConnect = 2,
	}

	internal struct Message
	{
		public int participantId; //Field offset: 0x0
		public MessageType type; //Field offset: 0x4
		public Byte[] data; //Field offset: 0x8

	}

	internal enum MessageType
	{
		Connect = 0,
		Disconnect = 1,
		NewLayout = 2,
		NewDevice = 3,
		NewEvents = 4,
		RemoveDevice = 5,
		RemoveLayout = 6,
		ChangeUsages = 7,
		StartSending = 8,
		StopSending = 9,
	}

	private static class NewDeviceMsg
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<InternedString, String> <>9__1_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <Create>b__1_0(InternedString x) { }

		}

		internal struct Data
		{
			public string name; //Field offset: 0x0
			public string layout; //Field offset: 0x8
			public int deviceId; //Field offset: 0x10
			public String[] usages; //Field offset: 0x18
			public InputDeviceDescription description; //Field offset: 0x20

		}


		[CalledBy(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(InputRemoting), Member = "SerializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewDeviceMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewDeviceMsg+Data"}, ReturnType = typeof(Byte[]))]
		[CallsUnknownMethods(Count = 7)]
		public static Message Create(InputDevice device) { }

		[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputRemoting), Member = "DeserializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewDeviceMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg+Data")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
		[Calls(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteInputDevice)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteInputDevice[]&), typeof(RemoteInputDevice)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 29)]
		[ContainsUnimplementedInstructions]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	private static class NewEventsMsg
	{

		[CalledBy(Type = typeof(NewEventsMsg), Member = "CreateResetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(Message))]
		[CalledBy(Type = typeof(NewEventsMsg), Member = "CreateStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InputEventPtr), Member = "get_sizeInBytes", ReturnType = typeof(uint))]
		[Calls(Type = typeof(InputEventPtr), Member = "Next", ReturnType = typeof(InputEventPtr))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public static Message Create(InputEvent* events, int eventCount) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DeviceResetEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(double)}, ReturnType = typeof(DeviceResetEvent))]
		[Calls(Type = typeof(NewEventsMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
		[CallsUnknownMethods(Count = 1)]
		public static Message CreateResetEvent(InputDevice device, bool isHardReset) { }

		[CalledBy(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
		[Calls(Type = typeof(NewEventsMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public static Message CreateStateEvent(InputDevice device) { }

		[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputEventPtr), Member = "get_deviceId", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputEventPtr), Member = "set_deviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventPtr), Member = "Next", ReturnType = typeof(InputEventPtr))]
		[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	private static class NewLayoutMsg
	{
		internal struct Data
		{
			public string name; //Field offset: 0x0
			public string layoutJson; //Field offset: 0x8
			public bool isOverride; //Field offset: 0x10

		}


		[CalledBy(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputRemoting), Member = "SendLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlLayoutChange)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(InputControlLayout), Member = "ToJson", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputControlLayout), Member = "get_isOverride", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputRemoting), Member = "SerializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewLayoutMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewLayoutMsg+Data"}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		public static Nullable<Message> Create(InputRemoting sender, string layoutName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputRemoting), Member = "DeserializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputRemoting+NewLayoutMsg+Data"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg+Data")]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	public struct RemoteInputDevice
	{
		public int remoteId; //Field offset: 0x0
		public int localId; //Field offset: 0x4
		public InputDeviceDescription description; //Field offset: 0x8

	}

	public struct RemoteSender
	{
		public int senderId; //Field offset: 0x0
		public InternedString[] layouts; //Field offset: 0x8
		public RemoteInputDevice[] devices; //Field offset: 0x10

	}

	private static class RemoveDeviceMsg
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CallsUnknownMethods(Count = 2)]
		public static Message Create(InputDevice device) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputRemoting), Member = "TryGetDeviceByRemoteId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(InputDevice))]
		[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	private static class StartSendingMsg
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputRemoting), Member = "StartSending", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public static void Process(InputRemoting receiver) { }

	}

	private static class StopSendingMsg
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputRemoting), Member = "StopSending", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public static void Process(InputRemoting receiver) { }

	}

	public class Subscriber : IDisposable
	{
		public InputRemoting owner; //Field offset: 0x10
		public IObserver<Message> observer; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Subscriber() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "Erase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	private Flags m_Flags; //Field offset: 0x10
	private InputManager m_LocalManager; //Field offset: 0x18
	private Subscriber[] m_Subscribers; //Field offset: 0x20
	private RemoteSender[] m_Senders; //Field offset: 0x28

	internal InputManager manager
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public private bool sending
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal InputRemoting(InputManager manager, bool startSendingOnConnect = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static InternedString BuildLayoutNamespace(int senderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static TData DeserializeData(Byte[] data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	[CalledBy(Type = typeof(DisconnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewLayoutMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewDeviceMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NewEventsMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChangeUsageMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoveDeviceMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "RemoveRemoteDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteSender)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteSender[]&), typeof(RemoteSender)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int FindOrCreateSenderRecord(int senderId) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal InputManager get_manager() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool get_sending() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveRemoteDevices(int participantId) { }

	[CalledBy(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlLayoutChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Send(Message msg) { }

	[CalledBy(Type = typeof(ConnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "StartSending", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendInitialMessages", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputDevice), Member = "get_remote", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewDeviceMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewEventsMsg), Member = "CreateStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void SendAllDevices() { }

	[CalledBy(Type = typeof(ConnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "StartSending", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "SendInitialMessages", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewLayoutMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SendAllGeneratedLayouts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_remote", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewDeviceMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewEventsMsg), Member = "CreateStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CallsUnknownMethods(Count = 1)]
	private void SendDevice(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_remote", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewDeviceMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DeviceResetEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(double)}, ReturnType = typeof(DeviceResetEvent))]
	[Calls(Type = typeof(NewEventsMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(ChangeUsageMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_remote", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewEventsMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int)}, ReturnType = typeof(Message))]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
	private void SendInitialMessages() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewLayoutMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	private void SendLayout(string layoutName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "IsGeneratedLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewLayoutMsg), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputRemoting), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static Byte[] SerializeData(TData data) { }

	[CallerCount(Count = 0)]
	private void set_sending(bool value) { }

	[CalledBy(Type = typeof(ConnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StartSendingMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StartSending() { }

	[CalledBy(Type = typeof(StopSendingMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisconnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void StopSending() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override IDisposable Subscribe(IObserver<Message> observer) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputRemoting), Member = "StopSending", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "StartSending", ReturnType = typeof(void))]
	[Calls(Type = typeof(ChangeUsageMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "TryGetDeviceByRemoteId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(NewEventsMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NewDeviceMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "FindOrCreateSenderRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputRemoting), Member = "DeserializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Data)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Data))]
	[Calls(Type = typeof(DisconnectMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllDevices", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputRemoting), Member = "SendAllGeneratedLayouts", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	[CalledBy(Type = typeof(ChangeUsageMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoveDeviceMsg), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 2)]
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

}

