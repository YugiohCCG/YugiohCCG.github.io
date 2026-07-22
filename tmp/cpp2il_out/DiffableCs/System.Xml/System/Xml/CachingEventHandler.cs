namespace System.Xml;

internal sealed class CachingEventHandler : MulticastDelegate
{

	[CallerCount(Count = 412)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public CachingEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(XsdCachingReader cachingReader) { }

}

