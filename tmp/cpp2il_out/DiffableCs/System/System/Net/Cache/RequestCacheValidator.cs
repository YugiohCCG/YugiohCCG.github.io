namespace System.Net.Cache;

internal class RequestCacheValidator
{

	[CalledBy(Type = typeof(WebRequest), Member = "set_CachePolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestCachePolicy)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequest), Member = "InternalSetCachePolicy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RequestCachePolicy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public object CreateValidator() { }

}

