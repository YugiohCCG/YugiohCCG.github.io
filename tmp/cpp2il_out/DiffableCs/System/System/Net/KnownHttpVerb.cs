namespace System.Net;

internal class KnownHttpVerb
{
	private static ListDictionary NamedHeaders; //Field offset: 0x0
	internal static KnownHttpVerb Get; //Field offset: 0x8
	internal static KnownHttpVerb Connect; //Field offset: 0x10
	internal static KnownHttpVerb Head; //Field offset: 0x18
	internal static KnownHttpVerb Put; //Field offset: 0x20
	internal static KnownHttpVerb Post; //Field offset: 0x28
	internal static KnownHttpVerb MkCol; //Field offset: 0x30
	internal string Name; //Field offset: 0x10
	internal bool RequireContentBody; //Field offset: 0x18
	internal bool ContentBodyNotAllowed; //Field offset: 0x19
	internal bool ConnectRequest; //Field offset: 0x1A
	internal bool ExpectNoContentResponse; //Field offset: 0x1B

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListDictionary), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	private static KnownHttpVerb() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	[CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebRequest), Member = "CanGetRequestStream", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListDictionary), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static KnownHttpVerb Parse(string name) { }

}

