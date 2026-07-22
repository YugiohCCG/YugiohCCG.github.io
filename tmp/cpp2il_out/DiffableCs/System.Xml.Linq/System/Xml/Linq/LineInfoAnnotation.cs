namespace System.Xml.Linq;

internal class LineInfoAnnotation
{
	internal int lineNumber; //Field offset: 0x10
	internal int linePosition; //Field offset: 0x14

	[CallerCount(Count = 79)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LineInfoAnnotation(int lineNumber, int linePosition) { }

}

