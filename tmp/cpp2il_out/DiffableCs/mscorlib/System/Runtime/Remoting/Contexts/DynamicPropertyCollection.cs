namespace System.Runtime.Remoting.Contexts;

internal class DynamicPropertyCollection
{
	private class DynamicPropertyReg
	{
		public IDynamicProperty Property; //Field offset: 0x10
		public IDynamicMessageSink Sink; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DynamicPropertyReg() { }

	}

	private ArrayList _properties; //Field offset: 0x10

	public bool HasProperties
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 44
	}

	[CalledBy(Type = typeof(Context), Member = "RegisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicProperty), typeof(ContextBoundObject), typeof(Context)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Context), Member = "UnregisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ContextBoundObject), typeof(Context)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Context), Member = "GetDynamicPropertyCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextBoundObject), typeof(Context)}, ReturnType = typeof(DynamicPropertyCollection))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DynamicPropertyCollection() { }

	[CalledBy(Type = typeof(DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicPropertyCollection), Member = "UnregisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private int FindProperty(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasProperties() { }

	[CalledBy(Type = typeof(Identity), Member = "NotifyClientDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Identity), Member = "NotifyServerDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(Context), Member = "NotifyGlobalDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Context), Member = "NotifyDynamicSinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	[CalledBy(Type = typeof(Context), Member = "RegisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicProperty), typeof(ContextBoundObject), typeof(Context)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "FindProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	[CalledBy(Type = typeof(Context), Member = "UnregisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ContextBoundObject), typeof(Context)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "FindProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public bool UnregisterDynamicProperty(string name) { }

}

