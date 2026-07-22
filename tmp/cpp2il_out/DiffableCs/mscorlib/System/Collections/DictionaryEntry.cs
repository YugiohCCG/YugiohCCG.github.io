namespace System.Collections;

public struct DictionaryEntry
{
	private object _key; //Field offset: 0x0
	private object _value; //Field offset: 0x8

	public object Key
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public object Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 68)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DictionaryEntry(object key, object value) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public object get_Key() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public object get_Value() { }

}

