namespace MS.Internal.Xml.XPath;

internal abstract class ResetableIterator : XPathNodeIterator
{

	public abstract int CurrentPosition
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ResetableIterator() { }

	[CallerCount(Count = 35)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ResetableIterator(ResetableIterator other) { }

	public abstract int get_CurrentPosition() { }

	public abstract void Reset() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void ResetCount() { }

}

