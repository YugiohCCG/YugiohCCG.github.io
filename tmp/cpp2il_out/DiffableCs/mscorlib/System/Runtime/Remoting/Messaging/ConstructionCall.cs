namespace System.Runtime.Remoting.Messaging;

[CLSCompliant(False)]
[ComVisible(True)]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	private IActivator _activator; //Field offset: 0x68
	private Object[] _activationAttributes; //Field offset: 0x70
	private IList _contextProperties; //Field offset: 0x78
	private Type _activationType; //Field offset: 0x80
	private string _activationTypeName; //Field offset: 0x88
	private bool _isContextOk; //Field offset: 0x90
	private RemotingProxy _sourceProxy; //Field offset: 0x98

	public override Type ActivationType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 188
	}

	public override string ActivationTypeName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override IActivator Activator
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public override Object[] CallSiteActivationAttributes
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override IList ContextProperties
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	internal bool IsContextOk
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public virtual IDictionary Properties
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 52
	}

	internal RemotingProxy SourceProxy
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal ConstructionCall(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ConstructionCall(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override Type get_ActivationType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_ActivationTypeName() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public override IActivator get_Activator() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override Object[] get_CallSiteActivationAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override IList get_ContextProperties() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsContextOk() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual IDictionary get_Properties() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal RemotingProxy get_SourceProxy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodCall), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual void InitDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodCall), Member = "InitMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	internal virtual void InitMethodProperty(string key, object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Activator(IActivator value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsContextOk(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SourceProxy(RemotingProxy value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetActivationAttributes(Object[] attributes) { }

}

