namespace TMPro;

public struct CaretInfo
{
	public int index; //Field offset: 0x0
	public CaretPosition position; //Field offset: 0x4

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public CaretInfo(int index, CaretPosition position) { }

}

