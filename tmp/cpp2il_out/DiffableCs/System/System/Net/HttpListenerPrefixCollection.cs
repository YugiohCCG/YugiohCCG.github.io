namespace System.Net;

public class HttpListenerPrefixCollection : ICollection<String>, IEnumerable<String>, IEnumerable
{
	private List<String> prefixes; //Field offset: 0x10
	private HttpListener listener; //Field offset: 0x18

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal HttpListenerPrefixCollection(HttpListener listener) { }

	[CalledBy(Type = "ClientAPI.WebServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyCollection`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListenerPrefix), Member = "CheckUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "AddPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Add(string uriPrefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool Contains(string uriPrefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void CopyTo(String[] array, int offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsReadOnly() { }

	[CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator<String> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HttpListener)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override bool Remove(string uriPrefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

