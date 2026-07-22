namespace System.Threading;

internal class ReaderWriterCount
{
	public long lockID; //Field offset: 0x10
	public int readercount; //Field offset: 0x18
	public int writercount; //Field offset: 0x1C
	public int upgradecount; //Field offset: 0x20
	public ReaderWriterCount next; //Field offset: 0x28

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReaderWriterCount() { }

}

