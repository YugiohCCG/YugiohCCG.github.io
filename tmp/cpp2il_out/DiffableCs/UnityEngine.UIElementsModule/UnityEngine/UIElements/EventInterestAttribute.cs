namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class EventInterestAttribute : Attribute
{
	internal Type[] eventTypes; //Field offset: 0x10
	internal EventCategoryFlags categoryFlags; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public EventInterestAttribute(Type[] eventTypes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EventInterestAttribute(EventInterestOptions interests) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal EventInterestAttribute(EventInterestOptionsInternal interests) { }

}

