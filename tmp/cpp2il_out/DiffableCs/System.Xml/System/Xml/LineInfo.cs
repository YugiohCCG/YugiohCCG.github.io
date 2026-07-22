namespace System.Xml;

internal struct LineInfo
{
	internal int lineNo; //Field offset: 0x0
	internal int linePos; //Field offset: 0x4

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public LineInfo(int lineNo, int linePos) { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public void Set(int lineNo, int linePos) { }

}

