namespace System;

internal sealed class LocalDataStoreElement
{
	private object m_value; //Field offset: 0x10
	private long m_cookie; //Field offset: 0x18

	public long Cookie
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public object Value
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LocalDataStoreElement(long cookie) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public long get_Cookie() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public object get_Value() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Value(object value) { }

}

