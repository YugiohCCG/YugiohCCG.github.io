namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	private static Dictionary<String, Object> type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress; //Field offset: 0x80000008
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000010
	private static string _process_guid; //Field offset: 0x0
	private IntPtr _mono_app_domain; //Field offset: 0x18
	private object _evidence; //Field offset: 0x20
	private object _granted; //Field offset: 0x28
	private int _principalPolicy; //Field offset: 0x30
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; //Field offset: 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; //Field offset: 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x68
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x70
	private object _domain_manager; //Field offset: 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x80
	private object _activation; //Field offset: 0x88
	private object _applicationIdentity; //Field offset: 0x90
	private List<String> compatibility_switch; //Field offset: 0x98

	public override event EventHandler DomainUnload
	{
		[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public static AppDomain CurrentDomain
	{
		[CallerCount(Count = 19)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[MonoTODO]
	public bool IsHomogenous
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private AppDomain() { }

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_DomainUnload(EventHandler value) { }

	[CalledBy(Type = "UnityEngine.UnhandledExceptionHandler", Member = "RegisterUECatcher", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssemblyLoadEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DoAssemblyLoad(Assembly assembly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolveEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DoDomainUnload() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolveEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal Assembly DoTypeResolve(string name) { }

	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static AppDomain get_CurrentDomain() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_IsFullyTrusted() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_IsHomogenous() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUtils", Member = "Preserver", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "RegisterCustomTypes", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetAllAssemblyTypes", ReturnType = "System.Collections.Generic.IEnumerable`1<Type>")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = "GetTypeFromTypeNameKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<String, String>"}, ReturnType = typeof(Type))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "TriggerUnsafeStaticMethodRecompilation", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenUtils", Member = "GetLooseScriptType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public override Assembly[] GetAssemblies() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Assembly[] GetAssemblies(bool refOnly) { }

	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static AppDomain getCurDomain() { }

	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Data.TypeLimiter+Scope", Member = "IsAllowedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetData(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	private int getDomainID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private string getFriendlyName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(string), typeof(Type)}, ReturnType = typeof(ObjRef))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Byte[] GetMarshalledDomainObjRef() { }

	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static string GetProcessGuid() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual object InitializeLifetimeService() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static Context InternalGetContext() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static Context InternalGetDefaultContext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static string InternalGetProcessGuid(string newguid) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void InternalPopDomainRef() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void InternalPushDomainRefByID(int domain_id) { }

	[CalledBy(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CalledBy(Type = typeof(Context), Member = "SwitchToContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[CalledBy(Type = typeof(Context), Member = "DoCallBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CrossContextDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel+ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	internal static Context InternalSetContext(Context context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static AppDomain InternalSetDomain(AppDomain context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(Exception&)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 12)]
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, Object[] args) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	[Intrinsic]
	internal static bool IsAppXModel() { }

	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetDomainID", ReturnType = typeof(int))]
	public bool IsFinalizingForUnload() { }

	[CalledBy(Type = typeof(Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	[CalledBy(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public override Assembly Load(string assemblyString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CADMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "DeserializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream), typeof(IMethodCallMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(ChannelServices), Member = "SyncDispatchMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[Calls(Type = typeof(CADMethodReturnMessage), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(CADMethodReturnMessage))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg, out Byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_DomainUnload(EventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

