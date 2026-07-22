namespace System.Xml;

internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{

	internal virtual bool IsFull
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public IncrementalReadDummyDecoder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool get_IsFull() { }

}

