namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class NameValueCollection : NameObjectCollectionBase
{
	private String[] _all; //Field offset: 0x50
	private String[] _allKeys; //Field offset: 0x58

	public string Item
	{
		[CallerCount(Count = 28)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CalledBy(Type = typeof(FileWebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest+AuthorizationState", Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 17
	}

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	public NameValueCollection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(FtpWebRequest), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal NameValueCollection(DBNull dummy) { }

	[CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NameValueCollection(int capacity) { }

	[CalledBy(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override void Add(string name, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public override string Get(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public override string Get(string name) { }

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_Item(string name) { }

	[CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private static string GetAsOneString(ArrayList list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static String[] GetAsStringArray(ArrayList list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	public override string GetKey(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override String[] GetValues(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override String[] GetValues(int index) { }

	[CalledBy(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	protected void InvalidateCachedArrays() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Remove(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public override void Set(string name, string value) { }

	[CalledBy(Type = typeof(FileWebRequest), Member = "set_ContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+AuthorizationState", Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListenerContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Item(string name, string value) { }

}

