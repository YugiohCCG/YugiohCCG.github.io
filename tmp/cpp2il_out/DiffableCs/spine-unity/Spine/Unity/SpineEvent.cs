namespace Spine.Unity;

public class SpineEvent : SpineAttributeBase
{
	public bool audioOnly; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public SpineEvent(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false, bool audioOnly = false) { }

}

