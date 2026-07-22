//Type is in global namespace

internal class TashkeelLocation
{
	public char tashkeel; //Field offset: 0x10
	public int position; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TashkeelLocation(char tashkeel, int position) { }

}

