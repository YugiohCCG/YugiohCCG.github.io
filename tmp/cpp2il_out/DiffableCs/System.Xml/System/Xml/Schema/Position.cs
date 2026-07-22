namespace System.Xml.Schema;

internal struct Position
{
	public int symbol; //Field offset: 0x0
	public object particle; //Field offset: 0x8

	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Position(int symbol, object particle) { }

}

