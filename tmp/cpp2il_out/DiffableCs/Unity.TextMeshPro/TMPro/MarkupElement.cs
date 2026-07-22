namespace TMPro;

internal struct MarkupElement
{
	private MarkupAttribute[] m_Attributes; //Field offset: 0x0

	public MarkupAttribute[] Attributes
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public int NameHashCode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 119
	}

	public int ValueHashCode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 37
	}

	public int ValueLength
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 37
	}

	public int ValueStartIndex
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 37
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public MarkupElement(int nameHashCode, int startIndex, int length) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public MarkupAttribute[] get_Attributes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_NameHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_ValueHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_ValueLength() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_ValueStartIndex() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Attributes(MarkupAttribute[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void set_NameHashCode(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_ValueHashCode(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_ValueLength(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_ValueStartIndex(int value) { }

}

