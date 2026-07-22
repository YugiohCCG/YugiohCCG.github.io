namespace System.Runtime.Remoting.Proxies;

[AttributeUsage(AttributeTargets::Class (4))]
[ComVisible(True)]
public class ProxyAttribute : Attribute, IContextAttribute
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override MarshalByRefObject CreateInstance(Type serverType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemotingServices), Member = "GetProxyForRemoteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RemotingServices), Member = "GetRealProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RealProxy))]
	[CallsUnknownMethods(Count = 1)]
	public override RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[CallerCount(Count = 13327)]
	[ComVisible(True)]
	[DeduplicatedMethod]
	public override void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[CallerCount(Count = 23)]
	[ComVisible(True)]
	[DeduplicatedMethod]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

