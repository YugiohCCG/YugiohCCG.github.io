namespace UnityEngine;

public sealed class AddComponentMenu : Attribute
{
	private string m_AddComponentMenu; //Field offset: 0x10
	private int m_Ordering; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AddComponentMenu(string menuName) { }

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AddComponentMenu(string menuName, int order) { }

}

