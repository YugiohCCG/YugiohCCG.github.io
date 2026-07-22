namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _methodName; //Field offset: 0x10
	private string _uri; //Field offset: 0x18
	private string _typeName; //Field offset: 0x20
	private MethodBase _methodBase; //Field offset: 0x28
	private object _returnValue; //Field offset: 0x30
	private Exception _exception; //Field offset: 0x38
	private Type[] _methodSignature; //Field offset: 0x40
	private ArgInfo _inArgInfo; //Field offset: 0x48
	private Object[] _args; //Field offset: 0x50
	private Object[] _outArgs; //Field offset: 0x58
	private IMethodCallMessage _callMsg; //Field offset: 0x60
	private LogicalCallContext _callContext; //Field offset: 0x68
	private Identity _targetIdentity; //Field offset: 0x70
	protected IDictionary ExternalProperties; //Field offset: 0x78
	protected IDictionary InternalProperties; //Field offset: 0x80

	public override int ArgCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 18
	}

	public override Object[] Args
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Exception Exception
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override LogicalCallContext LogicalCallContext
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	public override MethodBase MethodBase
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(MethodBase))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 348
	}

	public override string MethodName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 98
	}

	public override object MethodSignature
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 210
	}

	public override Object[] OutArgs
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(MethodBase))]
		[Calls(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgInfo), Member = "GetInOutArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Object[]))]
		[CallsUnknownMethods(Count = 9)]
		 get { } //Length: 522
	}

	public override IDictionary Properties
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 184
	}

	public override object ReturnValue
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private override string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 98
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public override string TypeName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 98
	}

	public override string Uri
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 98
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(ChannelServices), Member = "CheckReturnMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CalledBy(Type = typeof(AppDomainLevelActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CalledBy(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal MethodResponse(Exception e, IMethodCallMessage msg) { }

	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal MethodResponse(object returnValue, Object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(ArrayList)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(int), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(MethodResponse), Member = "InitMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MethodResponse(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	public override int get_ArgCount() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public override Object[] get_Args() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public override Exception get_Exception() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override LogicalCallContext get_LogicalCallContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(MethodBase))]
	[CallsUnknownMethods(Count = 7)]
	public override MethodBase get_MethodBase() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override string get_MethodName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override object get_MethodSignature() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgInfo), Member = "GetInOutArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 9)]
	public override Object[] get_OutArgs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override IDictionary get_Properties() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override object get_ReturnValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override string get_TypeName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override string get_Uri() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetArg(int argNum) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 21)]
	internal void InitMethodProperty(string key, object value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Uri(string value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private override Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

}

