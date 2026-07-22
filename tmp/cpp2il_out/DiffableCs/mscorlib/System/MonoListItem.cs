namespace System;

internal sealed class MonoListItem
{
	private MonoListItem next; //Field offset: 0x10
	private object data; //Field offset: 0x18

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public MonoListItem() { }

}

