namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x20

	private int EventId
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public EventKeywords Keywords
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public EventLevel Level
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string Message
	{
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EventAttribute(int eventId) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_EventId(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Keywords(EventKeywords value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Level(EventLevel value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Message(string value) { }

}

