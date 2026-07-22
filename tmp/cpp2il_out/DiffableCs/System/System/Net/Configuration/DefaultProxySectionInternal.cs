namespace System.Net.Configuration;

internal sealed class DefaultProxySectionInternal
{
	private static object classSyncObject; //Field offset: 0x0
	private IWebProxy webProxy; //Field offset: 0x10

	internal static object ClassSyncObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 149
	}

	internal IWebProxy WebProxy
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultProxySectionInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static object get_ClassSyncObject() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal IWebProxy get_WebProxy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[DeduplicatedMethod]
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	[CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static DefaultProxySectionInternal GetSection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[DeduplicatedMethod]
	private static IWebProxy GetSystemWebProxy() { }

}

