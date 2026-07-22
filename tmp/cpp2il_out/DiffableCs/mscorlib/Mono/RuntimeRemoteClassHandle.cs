namespace Mono;

internal struct RuntimeRemoteClassHandle
{
	private RemoteClass* value; //Field offset: 0x0

	internal RuntimeClassHandle ProxyClass
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 26
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal RuntimeClassHandle get_ProxyClass() { }

}

