namespace System.Runtime.Remoting.Messaging;

internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	private string _uri; //Field offset: 0x10

	public override int ArgCount
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Object[] Args
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override LogicalCallContext LogicalCallContext
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override MethodBase MethodBase
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string MethodName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public override object MethodSignature
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override IDictionary Properties
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string TypeName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public override string Uri
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ErrorMessage() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_ArgCount() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Object[] get_Args() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override LogicalCallContext get_LogicalCallContext() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override MethodBase get_MethodBase() { }

	[CallerCount(Count = 0)]
	public override string get_MethodName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override object get_MethodSignature() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override IDictionary get_Properties() { }

	[CallerCount(Count = 0)]
	public override string get_TypeName() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override string get_Uri() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override object GetArg(int arg_num) { }

}

