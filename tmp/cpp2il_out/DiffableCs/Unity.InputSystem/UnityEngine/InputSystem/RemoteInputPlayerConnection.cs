namespace UnityEngine.InputSystem;

internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<Message>, IObservable<Message>
{
	private class Subscriber : IDisposable
	{
		public RemoteInputPlayerConnection owner; //Field offset: 0x10
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

	public static readonly Guid kNewDeviceMsg; //Field offset: 0x0
	public static readonly Guid kNewLayoutMsg; //Field offset: 0x10
	public static readonly Guid kNewEventsMsg; //Field offset: 0x20
	public static readonly Guid kRemoveDeviceMsg; //Field offset: 0x30
	public static readonly Guid kChangeUsagesMsg; //Field offset: 0x40
	public static readonly Guid kStartSendingMsg; //Field offset: 0x50
	public static readonly Guid kStopSendingMsg; //Field offset: 0x60
	[SerializeField]
	private IEditorPlayerConnection m_Connection; //Field offset: 0x18
	private Subscriber[] m_Subscribers; //Field offset: 0x20
	[SerializeField]
	private Int32[] m_ConnectedIds; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static RemoteInputPlayerConnection() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public RemoteInputPlayerConnection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 15)]
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnChangeUsages(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnConnected(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Erase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisconnected(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnNewDevice(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnNewEvents(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnNewLayout(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnRemoveDevice(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoteInputPlayerConnection), Member = "SendToSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageType), typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	private void OnStartSending(MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void OnStopSending(MessageEventArgs args) { }

	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEditorPlayerConnection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnNewDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnNewLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnNewEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnRemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnChangeUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnStartSending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override IDisposable Subscribe(IObserver<Message> observer) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

}

