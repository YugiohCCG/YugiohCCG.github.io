namespace UnityEngine.Networking.PlayerConnection;

internal class PlayerEditorConnectionEvents
{
	internal class ConnectionChangeEvent : UnityEvent<Int32>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ConnectionChangeEvent() { }

	}

	internal class MessageEvent : UnityEvent<MessageEventArgs>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public MessageEvent() { }

	}

	internal class MessageTypeSubscribers
	{
		[SerializeField]
		private string m_messageTypeId; //Field offset: 0x10
		public int subscriberCount; //Field offset: 0x18
		public MessageEvent messageCallback; //Field offset: 0x20

		public Guid MessageTypeId
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			 get { } //Length: 54
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public MessageTypeSubscribers() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		public Guid get_MessageTypeId() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		public void set_MessageTypeId(Guid value) { }

	}

	[SerializeField]
	private List<MessageTypeSubscribers> m_MessageTypeSubscribers; //Field offset: 0x10
	private Dictionary<Guid, MessageTypeSubscribers> m_SubscriberLookup; //Field offset: 0x18
	[SerializeField]
	public ConnectionChangeEvent connectionEvent; //Field offset: 0x20
	[SerializeField]
	public ConnectionChangeEvent disconnectionEvent; //Field offset: 0x28

	public IReadOnlyList<MessageTypeSubscribers> messageTypeSubscribers
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public PlayerEditorConnectionEvents() { }

	[CalledBy(Type = typeof(PlayerConnection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	[CalledBy(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "MessageCallbackInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(ulong), typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "InvokeMessageIdSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "AddAndCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "UnregisterManagedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void BuildLookup() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public IReadOnlyList<MessageTypeSubscribers> get_messageTypeSubscribers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

