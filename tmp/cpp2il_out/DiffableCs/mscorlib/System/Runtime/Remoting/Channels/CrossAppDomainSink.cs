namespace System.Runtime.Remoting.Channels;

[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink
{
	private struct ProcessMessageRes
	{
		public Byte[] arrResponse; //Field offset: 0x0
		public CADMethodReturnMessage cadMrm; //Field offset: 0x8

	}

	private static Hashtable s_sinks; //Field offset: 0x0
	private static MethodInfo processMessageMethod; //Field offset: 0x8
	private int _domainID; //Field offset: 0x10

	internal int TargetDomainId
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 3)]
	private static CrossAppDomainSink() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CrossAppDomainSink(int domainID) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	private void <AsyncProcessMessage>b__10_0(object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal int get_TargetDomainId() { }

	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	internal static CrossAppDomainSink GetSink(int domainID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ErrorMessage), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static ProcessMessageRes ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SendAsyncMessage(object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(MemoryStream))]
	[Calls(Type = typeof(AppDomain), Member = "InvokeInDomainByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage), typeof(CADMethodReturnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "DeserializeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemoryStream), typeof(IMethodCallMessage)}, ReturnType = typeof(IMessage))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public override IMessage SyncProcessMessage(IMessage msgRequest) { }

}

