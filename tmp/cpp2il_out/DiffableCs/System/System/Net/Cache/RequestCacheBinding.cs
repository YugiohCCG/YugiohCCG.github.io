namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache; //Field offset: 0x10
	private RequestCacheValidator m_CacheValidator; //Field offset: 0x18

	internal RequestCache Cache
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal RequestCacheValidator Validator
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal RequestCache get_Cache() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal RequestCacheValidator get_Validator() { }

}

