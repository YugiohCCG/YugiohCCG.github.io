namespace TMPro;

internal struct MarkupAttribute
{
	private int m_NameHashCode; //Field offset: 0x0
	private int m_ValueHashCode; //Field offset: 0x4
	private int m_ValueStartIndex; //Field offset: 0x8
	private int m_ValueLength; //Field offset: 0xC

	public int NameHashCode
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public int ValueHashCode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int ValueLength
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int ValueStartIndex
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_NameHashCode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_ValueHashCode() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_ValueLength() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_ValueStartIndex() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_NameHashCode(int value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_ValueHashCode(int value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_ValueLength(int value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_ValueStartIndex(int value) { }

}

