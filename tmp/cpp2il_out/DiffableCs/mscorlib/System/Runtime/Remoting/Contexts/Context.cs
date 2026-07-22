namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public class Context
{
	[ContextStatic]
	private static Object[] local_slots; //Field offset: 0x0
	private static IMessageSink default_server_context_sink; //Field offset: 0x8
	private static int global_count; //Field offset: 0x10
	private static LocalDataStoreMgr _localDataStoreMgr; //Field offset: 0x18
	private static DynamicPropertyCollection global_dynamic_properties; //Field offset: 0x20
	private int domain_id; //Field offset: 0x10
	private int context_id; //Field offset: 0x14
	private UIntPtr static_data; //Field offset: 0x18
	private UIntPtr data; //Field offset: 0x20
	private IMessageSink server_context_sink_chain; //Field offset: 0x28
	private IMessageSink client_context_sink_chain; //Field offset: 0x30
	private List<IContextProperty> context_properties; //Field offset: 0x38
	private LocalDataStoreHolder _localDataStore; //Field offset: 0x40
	private DynamicPropertyCollection context_dynamic_properties; //Field offset: 0x48
	private ContextCallbackObject callback_object; //Field offset: 0x50

	public override int ContextID
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override IContextProperty[] ContextProperties
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		 get { } //Length: 96
	}

	public static Context DefaultContext
	{
		[CallerCount(Count = 25)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	internal bool HasDynamicSinks
	{
		[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 62
	}

	internal bool HasExitSinks
	{
		[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 359
	}

	internal static bool HasGlobalDynamicSinks
	{
		[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 158
	}

	internal bool IsDefaultContext
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	private LocalDataStore MyLocalStore
	{
		[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(LocalDataStoreHolder))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		private get { } //Length: 374
	}

	internal bool NeedsContextSink
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 223
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Context() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Context() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "AllocateDataSlot", ReturnType = typeof(LocalDataStoreSlot))]
	[CallsUnknownMethods(Count = 1)]
	public static LocalDataStoreSlot AllocateDataSlot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "AllocateNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LocalDataStoreSlot))]
	[CallsUnknownMethods(Count = 1)]
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	[CalledBy(Type = typeof(ContextLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 37)]
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientActivatedIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingletonIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StackBuilderSink), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DoCallBack(CrossContextDelegate deleg) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "FreeNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void FreeNamedDataSlot(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void Freeze() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_ContextID() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	public override IContextProperty[] get_ContextProperties() { }

	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Context get_DefaultContext() { }

	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasDynamicSinks() { }

	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Context), Member = "GetClientContextSinkChain", ReturnType = typeof(IMessageSink))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasExitSinks() { }

	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool get_HasGlobalDynamicSinks() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_IsDefaultContext() { }

	[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(LocalDataStoreHolder))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private LocalDataStore get_MyLocalStore() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_NeedsContextSink() { }

	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(Context), Member = "get_HasExitSinks", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ActivationServices), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemotingProxy), typeof(ConstructionCall)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(EnvoyTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(EnvoyTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal IMessageSink GetClientContextSinkChain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(LocalDataStore))]
	[Calls(Type = typeof(LocalDataStore), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static object GetData(LocalDataStoreSlot slot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LocalDataStoreSlot))]
	[CallsUnknownMethods(Count = 1)]
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public override IContextProperty GetProperty(string name) { }

	[CalledBy(Type = typeof(ConstructionLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal IMessageSink GetServerContextSinkChain() { }

	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ClientContextTerminatorSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(ClientContextReplySink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "NotifyMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(IMessage), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void RegisterContext(Context ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicProperty)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void ReleaseContext(Context ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Context), Member = "get_MyLocalStore", ReturnType = typeof(LocalDataStore))]
	[Calls(Type = typeof(LocalDataStore), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public override void SetProperty(IContextProperty prop) { }

	[CalledBy(Type = typeof(ContextLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	internal static Context SwitchToContext(Context newContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicPropertyCollection), Member = "UnregisterDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

}

