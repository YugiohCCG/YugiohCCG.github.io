namespace System.Xml;

internal abstract class IncrementalReadDecoder
{

	internal abstract bool IsFull
	{
		internal get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IncrementalReadDecoder() { }

	internal abstract int Decode(Char[] chars, int startPos, int len) { }

	internal abstract bool get_IsFull() { }

}

