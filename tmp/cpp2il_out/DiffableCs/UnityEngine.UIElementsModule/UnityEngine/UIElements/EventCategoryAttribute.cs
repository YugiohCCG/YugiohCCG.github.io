namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4))]
internal class EventCategoryAttribute : Attribute
{
	internal EventCategory category; //Field offset: 0x10

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EventCategoryAttribute(EventCategory category) { }

}

