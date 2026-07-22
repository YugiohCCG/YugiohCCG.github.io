namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	private static Type s_cachedTypeObjRef; //Field offset: 0x0
	private static ObjRefSurrogate _objRefSurrogate; //Field offset: 0x8
	private static RemotingSurrogate _objRemotingSurrogate; //Field offset: 0x10
	private ISurrogateSelector _next; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static RemotingSurrogateSelector() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RemotingSurrogateSelector() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

}

